using System;
using System.Windows.Forms;

namespace ToDoApp_Project.View
{
    public partial class UserMain : Form
    {
        public UserMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnToDos_Click(object sender, EventArgs e)
        {
            Hide();
            ManageToDos view = new ManageToDos();
            view.Show();
        }

        private void UserView_Load(object sender, EventArgs e)
        {
            lblUserHeader.Text = $"WELCOME {Login.currentUserName}!";
        }
    }
}
