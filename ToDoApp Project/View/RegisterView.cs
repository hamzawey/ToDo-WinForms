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
    public partial class RegisterView : Form
    {
        UserController userController = new UserController();
        public RegisterView()
        {
            InitializeComponent();
        }

        private void btnRegisterRegisterView_Click(object sender, EventArgs e)
        {
            User user = new User();
            string username = txtBoxRegisterName.Text;
            string password = txtBoxRegisterPassword.Text;
            string userrole = "User";

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password) &&
                !string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
            {
                user.Username = username;
                user.Password = password;
                user.Role = userrole;
                if (userController.doesUsernameExist(user))
                {
                    MessageBox.Show("Username already exists!", "Username is being used",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBoxRegisterName.Text = "";
                    txtBoxRegisterPassword.Text = "";
                }
                else
                {
                    userController.RegisterUser(user);
                    Hide();
                    LoginView login = new LoginView();
                    login.Show();
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
