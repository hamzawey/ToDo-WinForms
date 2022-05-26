using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoApp_Project.View
{
    public partial class AdminRoleAppView : Form
    {
        public AdminRoleAppView()
        {
            InitializeComponent();
        }

        private void btnUsersManagementView_Click(object sender, EventArgs e)
        {
            Hide();
            UsersManagementView umv = new UsersManagementView();
            umv.Show();
        }

        private void ToDoListsButton_Click(object sender, EventArgs e)
        {
            Hide();
            ToDosView view = new ToDosView();
            view.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminRoleAppView_Load(object sender, EventArgs e)
        {
            adminMainLabel.Text = $"Welcome {LoginView.currentUserName}!";
            adminRoleLabel.Text = "This is Admin Role Menu only!";
        }
    }
}
