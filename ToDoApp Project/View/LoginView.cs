using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoApp_Project.Controller;
using ToDoApp_Project.Model;

namespace ToDoApp_Project.View
{
    public partial class LoginView : Form
    {
        public static int currentUserId = 0;
        public static string currentUserName = "";
        public static string currentUserRole = "";

        UserController userController = new UserController();
        public LoginView()
        {
            InitializeComponent();
        }

        private void btnSignInLoginView_Click(object sender, EventArgs e)
        {
            string username = txtBoxSignInName.Text;
            string password = txtBoxSignInPassword.Text;
            User user = new User();
            user.Username = username;
            user.Password = password;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please dont leave the text boxes empty!", "EMPTY BOX DETECTED",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxSignInName.Text = "";
                txtBoxSignInPassword.Text = "";
            }
            else if(!userController.tryToLogin(user))
            {
                MessageBox.Show("Wrong username or password!", "PROVIDED DATA ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxSignInName.Text = "";
                txtBoxSignInPassword.Text = "";
            }
            else
            {
                string foundRole = userController.findRole(user);
                user.Role = foundRole;
                int findUserId = userController.findId(user);
                user.Id = findUserId;

                currentUserId = findUserId;
                currentUserName = user.Username;
                currentUserRole = foundRole;

                if (foundRole == "Admin")
                {
                    AdminRoleAppView adminView = new AdminRoleAppView();
                    adminView.Show();
                }
                else if (foundRole == "User")
                {
                    UserRoleAppView userView = new UserRoleAppView();
                    userView.Show();
                }
                Hide();
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Hide();
            MainView view = new MainView();
            view.Show();
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
            lblSignInText.Text = "LOGIN";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxSignInPassword.UseSystemPasswordChar = !txtBoxSignInPassword.UseSystemPasswordChar;
        }
    }
}
