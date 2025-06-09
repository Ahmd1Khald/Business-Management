using Stationery_Store.Entities;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Stationery_Store.Forms
{
    public partial class CategoryForm : Form
    {
        private Context dbContext;
        private Timer statusTimer;
        private int blinkCount = 0;

        public CategoryForm()
        {
            InitializeComponent();
            dbContext = new Context();
            LoadCategories();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            searchBox.TextChanged += searchBox_TextChanged;
            this.FormClosed += CategoryForm_FormClosed;
        }

        private void LoadCategories(string filter = "")
        {
            var categories = dbContext.Categories
                .Where(c => string.IsNullOrEmpty(filter) || c.Name.Contains(filter))
                .Select(c => new
                {
                    c.ID,
                    c.Name,
                    c.Description
                })
                .ToList();

            dataGridView1.DataSource = categories;

            dataGridView1.Columns["ID"].HeaderText = "المعرف";
            dataGridView1.Columns["Name"].HeaderText = "اسم الصنف";
            dataGridView1.Columns["Description"].HeaderText = "الوصف";

            dataGridView1.Columns["ID"].Width = 60;
            dataGridView1.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Description"].Width = 200;
            dataGridView1.AllowUserToResizeColumns = false;

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.Resizable = DataGridViewTriState.False;

            }
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (i % 2 == 0)
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightCyan;
                else
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            }

            dataGridView1.ClearSelection();
        }

        private void ClearInputFields()
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void AddCategoryBtn_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string description = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                SetStatus("يرجى إدخال اسم الصنف", Color.Red);
                return;
            }

            if (dbContext.Categories.Any(c => c.Name == name))
            {
                SetStatus("هذا الصنف موجود بالفعل", Color.Red);
                return;
            }

            var newCategory = new Category
            {
                Name = name,
                Description = description
            };

            dbContext.Categories.Add(newCategory);
            dbContext.SaveChanges();
            LoadCategories();
            ClearInputFields();
            SetStatus("تمت إضافة الصنف بنجاح", Color.Green);
        }

        private void UpdateCategoryBtn_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedCategoryId(out int selectedId))
            {
                SetStatus("اختر صنف للتحديث", Color.Red);
                return;
            }

            string name = textBox1.Text.Trim();
            string description = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                SetStatus("يرجى إدخال اسم الصنف", Color.Red);
                return;
            }

            if (dbContext.Categories.Any(c => c.Name == name && c.ID != selectedId))
            {
                SetStatus("يوجد صنف آخر بنفس الاسم", Color.Red);
                return;
            }

            var category = dbContext.Categories.Find(selectedId);
            if (category != null)
            {
                category.Name = name;
                category.Description = description;
                dbContext.SaveChanges();
                LoadCategories();
                ClearInputFields();
                SetStatus("تم تحديث الصنف", Color.Green);
            }
            else
            {
                SetStatus("الصنف غير موجود", Color.Red);
            }
        }

        private void RemoveCategoryBtn_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedCategoryId(out int selectedId))
            {
                SetStatus("اختر صنف صالح للإزالة", Color.Red);
                return;
            }

            var category = dbContext.Categories.Find(selectedId);
            if (category != null)
            {
                // ✅ تحقق هل في منتجات مرتبطة
                bool hasRelatedProducts = dbContext.Products.Any(p => p.CategoryId == selectedId);
                if (hasRelatedProducts)
                {
                    MessageBox.Show("لا يمكن حذف هذا الصنف لأنه يحتوي على منتجات مرتبطة به.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var result = MessageBox.Show($"هل أنت متأكد أنك تريد حذف الصنف '{category.Name}'؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    dbContext.Categories.Remove(category);
                    dbContext.SaveChanges();
                    LoadCategories();
                    ClearInputFields();
                    SetStatus("تم حذف الصنف", Color.Green);
                }
            }
            else
            {
                SetStatus("الصنف غير موجود", Color.Red);
            }
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null &&
                !dataGridView1.CurrentRow.IsNewRow &&
                dataGridView1.CurrentRow.Cells["Name"].Value != null)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells["Description"].Value?.ToString();
            }
        }
        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            var hit = dataGridView1.HitTest(e.X, e.Y);

            if (hit.Type == DataGridViewHitTestType.None ||
                hit.Type == DataGridViewHitTestType.ColumnHeader ||
                hit.Type == DataGridViewHitTestType.RowHeader)
            {
                dataGridView1.ClearSelection();
                ClearInputFields();
            }
        }


        private bool TryGetSelectedCategoryId(out int categoryId)
        {
            categoryId = -1;

            if (dataGridView1.CurrentRow == null ||
                dataGridView1.CurrentRow.IsNewRow ||
                dataGridView1.CurrentRow.Cells["ID"].Value == null)
            {
                return false;
            }

            return int.TryParse(dataGridView1.CurrentRow.Cells["ID"].Value.ToString(), out categoryId);
        }

        private void SetStatus(string message, Color color)
        {
            CategoryStatuslbl.Text = message;
            CategoryStatuslbl.ForeColor = color;
            blinkCount = 0;

            if (statusTimer == null)
            {
                statusTimer = new Timer();
                statusTimer.Interval = 200;
                statusTimer.Tick += BlinkStatus;
            }

            statusTimer.Start();
        }

        private void BlinkStatus(object sender, EventArgs e)
        {
            if (blinkCount < 6)
            {
                CategoryStatuslbl.Visible = !CategoryStatuslbl.Visible;
                blinkCount++;
            }
            else
            {
                statusTimer.Stop();
                CategoryStatuslbl.Visible = true;
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            LoadCategories(searchBox.Text.Trim());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Placeholder if needed
        }


        private void CategoryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dbContext.Dispose();
        }

        private void CategoryForm_Load_1(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
