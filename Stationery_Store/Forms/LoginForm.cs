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
                UserNameMessagelabel.Text = " √ﬂœ „‰ «”„ «·„” Œœ„";
                UserNameMessagelabel.Visible = true;
            }
            else
            {
                if (user.Password == password)
                {
                    MessageBox.Show(user.UserRole + "  „  ”ÃÌ· «·œŒÊ· »‰Ã«Õ");

                    LoggedInUserRole = user.UserRole;

                    this.DialogResult = DialogResult.OK;  // „Â„ Ãœ«
                    this.Close();                         // «ﬁ›· «·›Ê—„ »⁄œ  ”ÃÌ· «·œŒÊ·
                }
                else
                {
                    UserNameMessagelabel.Visible = false;
                    PassWordMessagelabel.Text = " √ﬂœ „‰ ﬂ·„… «·”—";
                    PassWordMessagelabel.Visible = true;
                }
            }
        }

    }
}