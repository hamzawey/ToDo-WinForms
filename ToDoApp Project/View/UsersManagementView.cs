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
    public partial class UsersManagementView : Form
    {
        UserController userController = new UserController();
        public UsersManagementView()
        {
            InitializeComponent();
        }

        private void UsersManagementView_Load(object sender, EventArgs e)
        {
            userTableAdapter.Fill(applicationDbModelDataSet.User);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvUserManagementView.CurrentRow;
            int id = int.Parse(row.Cells[0].Value.ToString());
            userController.DeleteUser(id);
            userTableAdapter.Fill(applicationDbModelDataSet.User);
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Hide();
            AdminRoleAppView adminView = new AdminRoleAppView();
            adminView.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            User user = new User();
            string username = txtBoxUsername.Text;
            string password = txtBoxPassword.Text;
            string userrole = txtBoxRole.Text;
            int id = int.Parse(txtBoxId.Text);

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password)
                && !string.IsNullOrEmpty(userrole) && !string.IsNullOrEmpty(id.ToString()))
            {
                user.Username = username;
                user.Password = password;
                user.Role = userrole;
                user.Id = id;
                if (userController.doesUsernameExist(user))
                {
                    MessageBox.Show("Username already exists!", "Username is being used",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBoxUsername.Text = "";
                    txtBoxPassword.Text = "";
                    txtBoxRole.Text = "";
                    txtBoxId.Text = "";
                }
                else if (userController.doesIdExist(user))
                {
                    MessageBox.Show("Id is being used!", "Id error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBoxUsername.Text = "";
                    txtBoxPassword.Text = "";
                    txtBoxRole.Text = "";
                    txtBoxId.Text = "";
                }
                else
                {
                    userController.RegisterUser(user);
                    userTableAdapter.Fill(applicationDbModelDataSet.User);
                }
            }
            else
            {
                MessageBox.Show("Please dont leave the text boxes empty!", "EMPTY BOX DETECTED",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvUserManagementView.CurrentRow;
            int id = int.Parse(row.Cells[0].Value.ToString());

            User user = new User();
            string username = txtEditName.Text;
            string password = txtEditPass.Text;
            string role = txtEditRole.Text;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password)
                && !string.IsNullOrEmpty(role))
            {
                user.Username = username;
                user.Password = password;
                user.Role = role;

                if (userController.doesUsernameExist(user))
                {
                    MessageBox.Show("Username already exists!", "Username is being used",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBoxUsername.Text = "";
                    txtBoxPassword.Text = "";
                    txtBoxRole.Text = "";
                    txtBoxId.Text = "";
                }
                else
                {
                    userController.EditUser(id, user);
                    userTableAdapter.Fill(applicationDbModelDataSet.User);
                }
            }
            else
            {
                MessageBox.Show("Please dont leave the text boxes empty!", "EMPTY BOX DETECTED",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBoxDeleteById.Text);
            userController.DeleteUser(id);
            txtBoxDeleteById.Text = "";
            userTableAdapter.Fill(applicationDbModelDataSet.User);
        }
    }
}
