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

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password) &&
                !string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
            {
                if (userController.tryToLogin(user))
                {
                    string foundRole = userController.findRole(user);

                    if (foundRole == "Admin")
                    {
                        Hide();
                        AdminRoleAppView adminView = new AdminRoleAppView();
                        adminView.Show();
                    }
                    else if (foundRole == "User")
                    {
                        Hide();
                        UserRoleAppView userView = new UserRoleAppView();
                        userView.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Error logging in!", "Invalid data",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBoxSignInName.Text = "";
                    txtBoxSignInPassword.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please dont leave the text boxes empty!", "EMPTY BOX DETECTED",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Hide();
            MainView view = new MainView();
            view.Show();
        }
    }
}
