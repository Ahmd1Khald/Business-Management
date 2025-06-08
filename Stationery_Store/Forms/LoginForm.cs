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
                   

                    MessageBox.Show(user.UserRole+"  „  ”ÃÌ· «·œŒÊ· »‰Ã«Õ");
                    // hide login form
                    this.Hide();
                    HomeForm homeForm = new HomeForm(user.UserRole);
                    homeForm.Show();
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