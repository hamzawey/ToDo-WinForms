using System;
using System.Windows.Forms;
using ToDoApp_Project.Controller;
using ToDoApp_Project.Model;

namespace ToDoApp_Project.View
{
    public partial class Login : Form
    {
        public static int currentUserId = 0;
        public static string currentUserName = "";
        public static string currentUserRole = "";

        UserController userController = new UserController();

        public Login()
        {
            InitializeComponent();
        }

        private void checkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtLoginPassword.UseSystemPasswordChar = !txtLoginPassword.UseSystemPasswordChar;
        }

        private void btnLoginUser_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Username = txtLoginName.Text;
            user.Password = txtLoginPassword.Text;

            if (string.IsNullOrEmpty(txtLoginName.Text) || string.IsNullOrEmpty(txtLoginPassword.Text) ||
                string.IsNullOrWhiteSpace(txtLoginName.Text) || string.IsNullOrWhiteSpace(txtLoginPassword.Text))
            {
                MessageBox.Show("Please dont leave the text boxes empty!", "EMPTY BOX DETECTED",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLoginName.Text = "";
                txtLoginPassword.Text = "";
            }
            else if (!userController.TryToLogin(user))
            {
                MessageBox.Show("Wrong username or password!", "PROVIDED DATA ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLoginName.Text = "";
                txtLoginPassword.Text = "";
            }
            else
            {
                user.Role = userController.FindUserRole(user);
                user.Id = userController.FindUserId(user);

                currentUserId = user.Id;
                currentUserName = user.Username;
                currentUserRole = user.Role;

                if (user.Role == "Admin")
                {
                    AdminMain view = new AdminMain();
                    view.Show();
                }
                else if (user.Role == "User")
                {
                    UserMain view = new UserMain();
                    view.Show();
                }
                Hide();
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Hide();
            Main view = new Main();
            view.Show();
        }
    }
}
