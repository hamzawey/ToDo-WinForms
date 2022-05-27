using System;
using System.Windows.Forms;
using ToDoApp_Project.View;

namespace ToDoApp_Project
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Hide();
            Register view = new Register();
            view.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Hide();
            Login view = new Login();
            view.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
