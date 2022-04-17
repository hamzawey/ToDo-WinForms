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

            if (userController.doesExist(user))
            {
                string foundRole = userController.findRole(user);
                userController.currentLoggedUserSet(user);

                if(foundRole == "Admin")
                {
                    Hide();
                    AdminRoleAppView adminView = new AdminRoleAppView();
                    adminView.Show();
                }
                else if(foundRole == "User")
                {
                    Hide();
                    UserRoleAppView userView = new UserRoleAppView();
                    userView.Show();
                }
            }
            else
            {
                MessageBox.Show("Username doesnt exist!", "Invalid username",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxSignInName.Text = "";
                txtBoxSignInPassword.Text = "";
            }
        }
    }
}
