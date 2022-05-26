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
            if (string.IsNullOrEmpty(txtBoxRegisterName.Text) || string.IsNullOrEmpty(txtBoxRegisterPassword.Text) ||
                string.IsNullOrWhiteSpace(txtBoxRegisterName.Text) || string.IsNullOrWhiteSpace(txtBoxRegisterPassword.Text))
            {
                MessageBox.Show("Please dont leave the text boxes empty!", "EMPTY BOX DETECTED",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxRegisterName.Text = "";
                txtBoxRegisterPassword.Text = "";
            }
            else
            {
                if (userController.doesUsernameExist(txtBoxRegisterName.Text))
                {
                    MessageBox.Show("Username already exists!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxRegisterName.Text = "";
                    txtBoxRegisterPassword.Text = "";
                }
                else
                {
                    User user = new User();
                    user.Username = txtBoxRegisterName.Text;
                    user.Password = txtBoxRegisterPassword.Text;
                    user.Role = "User";

                    userController.RegisterUser(user);

                    Hide();
                    LoginView login = new LoginView();
                    login.Show();
                }
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Hide();
            MainView view = new MainView();
            view.Show();
        }

        private void RegisterView_Load(object sender, EventArgs e)
        {
            lblRegisterText.Text = "REGISTER";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxRegisterPassword.UseSystemPasswordChar = !txtBoxRegisterPassword.UseSystemPasswordChar;
        }
    }
}
