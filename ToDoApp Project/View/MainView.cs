using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoApp_Project.View;

namespace ToDoApp_Project
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void ToDoView_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome to ToDo App!";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Hide();
            LoginView loginView = new LoginView();
            loginView.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Hide();
            RegisterView registerView = new RegisterView();
            registerView.Show();
        }
    }
}
