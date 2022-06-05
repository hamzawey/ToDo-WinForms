using System;
using System.Windows.Forms;

namespace ToDoApp_Project.View
{
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminView_Load(object sender, EventArgs e)
        {
            lblAdminHeader.Text = $"WELCOME {Login.currentUserName}!";
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            Hide();
            ManageUsers view = new ManageUsers();
            view.Show();
        }

        private void btnToDos_Click(object sender, EventArgs e)
        {
            Hide();
            ManageToDos view = new ManageToDos();
            view.Show();
        }
    }
}
