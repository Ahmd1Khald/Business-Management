using Stationery_Store.Entities;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Stationery_Store.Forms
{
    public partial class CategoryForm : Form
    {
        private Context dbContext;

        public CategoryForm()
        {
            InitializeComponent();
            dbContext = new Context();
            LoadCategories();
        }

        private void LoadCategories()
        {
            var categories = dbContext.Categories
                .Select(c => new
                {
                    c.ID,
                    c.Name,
                    c.Description
                })
                .ToList();

            dataGridView1.DataSource = categories;

            // Customizing look
            dataGridView1.Columns["ID"].HeaderText = "المعرف";
            dataGridView1.Columns["Name"].HeaderText = "اسم الصنف";
            dataGridView1.Columns["Description"].HeaderText = "الوصف";

            dataGridView1.Columns["ID"].Width = 60;
            dataGridView1.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Description"].Width = 200;

            dataGridView1.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
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
                SetStatus("ادخل اسم الصنف", Color.Red);
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
            SetStatus("تمت إضافة الصنف بنجاح", Color.Green);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void UpdateCategoryBtn_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedCategoryId(out int selectedId))
            {
                SetStatus("اختر صنف صالح للتحديث", Color.Red);
                return;
            }

            var category = dbContext.Categories.Find(selectedId);
            if (category != null)
            {
                category.Name = textBox1.Text.Trim();
                category.Description = textBox2.Text.Trim();

                dbContext.SaveChanges();
                LoadCategories();
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
                dbContext.Categories.Remove(category);
                dbContext.SaveChanges();
                LoadCategories();
                SetStatus("تم حذف الصنف", Color.Green);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // لا حاجة للكود هنا في الوقت الحالي
        }

        // ✅ دالة مساعدة للحصول على ID من الصف المحدد بأمان
        private bool TryGetSelectedCategoryId(out int categoryId)
        {
            categoryId = -1;

            if (dataGridView1.CurrentRow == null ||
                dataGridView1.CurrentRow.IsNewRow ||
                dataGridView1.CurrentRow.Cells["Id"].Value == null)
            {
                return false;
            }

            return int.TryParse(dataGridView1.CurrentRow.Cells["ID"].Value.ToString(), out categoryId);
        }

        // ✅ دالة مساعدة لعرض رسالة الحالة
        private void SetStatus(string message, Color color)
        {
            CategoryStatuslbl.Text = message;
            CategoryStatuslbl.ForeColor = color;
        }
    }
}
