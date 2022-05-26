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
    public partial class txtBoxCreateToDoTitle : Form
    {
        UserController userController = new UserController();
        public txtBoxCreateToDoTitle()
        {
            InitializeComponent();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            if (LoginView.currentUserRole == "Admin")
            {
                Hide();
                AdminRoleAppView view = new AdminRoleAppView();
                view.Show();
            }
            else
            {
                Hide();
                UserRoleAppView view = new UserRoleAppView();
                view.Show();
            }
            
        }

        private void btnCreateNewTodo_Click(object sender, EventArgs e)
        {
            // Id Title CreatedAt CreatorId LastChanged LastChangedUserId
        }

        private void btnUpdateToDo_Click(object sender, EventArgs e)
        {
            // LastChanged LastChangedUserId
        }
    }
}
