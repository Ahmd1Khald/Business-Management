using Stationery_Store.Entities;
using Stationery_Store.Forms;

namespace Stationery_Store
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        public Role LoggedInUserRole { get; private set; }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            Context context = new Context();

            string user_name = UserNametextBox.Text;
            string password = PasswordtextBox.Text;

            User? user = context.Users.FirstOrDefault(u => u.UserName == user_name);

            if (user == null)
            {
                PassWordMessagelabel.Visible = false;
                UserNameMessagelabel.Text = "اسم المستخدم غير موجود";
                UserNameMessagelabel.Visible = true;
            }
            else
            {
                if (user.Password == password)
                {
                    MessageBox.Show(user.UserRole + " تم تسجيل الدخول بنجاح");

                    LoggedInUserRole = user.UserRole;

                    this.DialogResult = DialogResult.OK;  // إعطاء نتيجة نجاح للنموذج
                    this.Close();                         // إغلاق نافذة تسجيل الدخول
                }
                else
                {
                    UserNameMessagelabel.Visible = false;
                    PassWordMessagelabel.Text = "كلمة المرور غير صحيحة";
                    PassWordMessagelabel.Visible = true;
                }
            }

        }

    }
}