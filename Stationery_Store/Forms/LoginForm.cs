using Stationery_Store.Entities;

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
            //context.Users.Add(new User() { UserName = "Admin", Password = "Admin2025",NationalID="123",Phone="01150" });
            //context.SaveChanges();

            string user_name = UserNametextBox.Text;
            string password = PasswordtextBox.Text;
            User user = context.Users.FirstOrDefault(u => u.UserName == user_name);
            if (user == null)
            {
                PassWordMessagelabel.Visible = false;
                UserNameMessagelabel.Text = "User name does not exist";
                UserNameMessagelabel.Visible = true;
            }
            else
            {
                if (user.Password == password)
                {
                    MessageBox.Show("Login Successfully");
                }
                else
                {
                    UserNameMessagelabel.Visible = false;
                    PassWordMessagelabel.Text = "Password is wrong";
                    PassWordMessagelabel.Visible = true;
                }
            }
        }
    }
}