using Stationery_Store.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Stationery_Store.Forms
{
    public partial class UsersForm : Form
    {
        private int selectedUserId = -1;

        public UsersForm()
        {
            InitializeComponent();
            comboBoxRole.DataSource = Enum.GetValues(typeof(Role));
            this.Load += new System.EventHandler(this.UsersForm_Load);
            dataGridViewUsers.SelectionChanged += dataGridView1_SelectionChanged;

        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
            this.ControlBox = false;
        }

        private void LoadUsers()
        {
            using (var context = new Context())
            {
                var users = context.Users
                    .Select(u => new
                    {
                        u.ID,
                        u.UserName,
                        u.Password,
                        u.NationalID,
                        u.Phone,
                        Role = u.UserRole.ToString()
                    }).ToList();

                dataGridViewUsers.DataSource = users;
            }

            dataGridViewUsers.Columns["ID"].Visible = false;

            // تعديل عناوين الأعمدة للعربية
            dataGridViewUsers.Columns["UserName"].HeaderText = "اسم المستخدم";
            dataGridViewUsers.Columns["Password"].HeaderText = "كلمة السر";
            dataGridViewUsers.Columns["NationalID"].HeaderText = "الرقم القومي";
            dataGridViewUsers.Columns["Phone"].HeaderText = "رقم المحمول";
            dataGridViewUsers.Columns["Role"].HeaderText = "الدور";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                var row = dataGridViewUsers.SelectedRows[0];
                selectedUserId = (int)row.Cells["ID"].Value;

                textBoxUserName.Text = row.Cells["UserName"].Value?.ToString();
                textBoxPassword.Text = row.Cells["Password"].Value?.ToString();
                textBoxNationalID.Text = row.Cells["NationalID"].Value?.ToString();
                textBoxPhone.Text = row.Cells["Phone"].Value?.ToString();

                // تعيين الدور في ComboBox بشكل صحيح
                string roleValue = row.Cells["Role"].Value?.ToString();
                if (Enum.TryParse(roleValue, out Role userRole))
                {
                    comboBoxRole.SelectedItem = userRole;
                }


            }
        }

        private List<ValidationResult> ValidateUser(User user)
        {
            var context = new ValidationContext(user);
            var results = new List<ValidationResult>();
            Validator.TryValidateObject(user, context, results, true);
            return results;
        }



        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

        }

        private void ClearFields()
        {
            selectedUserId = -1;
            textBoxUserName.Clear();
            textBoxPassword.Clear();
            textBoxNationalID.Clear();
            textBoxPhone.Clear();
            comboBoxRole.SelectedIndex = 0;
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            using (var context = new Context())
            {
                if (context.Users.Any(u => u.UserName == textBoxUserName.Text))
                {
                    MessageBox.Show("اسم المستخدم مستخدم بالفعل");
                    return;
                }

                var user = new User
                {
                    UserName = textBoxUserName.Text.Trim(),
                    Password = textBoxPassword.Text.Trim(),
                    NationalID = textBoxNationalID.Text.Trim(),
                    Phone = textBoxPhone.Text.Trim(),
                    UserRole = (Role)Enum.Parse(typeof(Role), comboBoxRole.SelectedItem.ToString())
                };

                var validationResults = ValidateUser(user);

                if (validationResults.Any())
                {
                    string message = string.Join("\n", validationResults.Select(r => r.ErrorMessage));
                    MessageBox.Show(message, "أخطاء في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                context.Users.Add(user);
                context.SaveChanges();
            }

            ClearFields();
            LoadUsers();
            MessageBox.Show("تمت إضافة المستخدم");
        }

        private void buttonUpdate_Click_1(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("اختر مستخدمًا للتعديل");
                return;
            }

            using (var context = new Context())
            {
                var user = context.Users.Find(selectedUserId);
                if (user != null)
                {
                    user.UserName = textBoxUserName.Text.Trim();
                    user.NationalID = textBoxNationalID.Text.Trim();
                    user.Phone = textBoxPhone.Text.Trim();
                    user.UserRole = (Role)Enum.Parse(typeof(Role), comboBoxRole.SelectedItem.ToString());
                    user.Password = textBoxPassword.Text.Trim();

                    var validationResults = ValidateUser(user);

                    if (validationResults.Any())
                    {
                        string message = string.Join("\n", validationResults.Select(r => r.ErrorMessage));
                        MessageBox.Show(message, "أخطاء في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!string.IsNullOrEmpty(textBoxPassword.Text))
                        user.Password = textBoxPassword.Text;

                    context.SaveChanges();
                    LoadUsers();
                    MessageBox.Show("تم تعديل المستخدم");
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("اختر مستخدمًا للحذف");
                return;
            }

            var confirm = MessageBox.Show("هل أنت متأكد من حذف هذا المستخدم؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                using (var context = new Context())
                {
                    var user = context.Users.Find(selectedUserId);
                    if (user != null)
                    {
                        context.Users.Remove(user);
                        context.SaveChanges();
                        LoadUsers();
                        ClearFields();
                        MessageBox.Show("تم حذف المستخدم بنجاح");
                    }
                }
            }
        }

        private void UsersForm_Load_1(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
