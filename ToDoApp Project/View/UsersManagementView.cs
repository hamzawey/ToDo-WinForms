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
        private void RefreshTable()
        {
            dgvUserManagementView.DataSource = userController.GetUsers();
        }
        private void UsersManagementView_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do really want to delete this user?", "IMPORTANT",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                DialogResult result2 = MessageBox.Show("By accepting this, you understand that every ToDo that this user created is going to be deleted too!", "IMPORTANT",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result2 == DialogResult.OK)
                {
                    DataGridViewRow row = dgvUserManagementView.CurrentRow;
                    int id = int.Parse(row.Cells[0].Value.ToString());
                    userController.DeleteUser(id);
                    RefreshTable();
                }
                else if (result2 == DialogResult.Cancel)
                {
                    MessageBox.Show("No user was deleted.", "Response",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("No user was deleted.", "Response",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Hide();
            AdminRoleAppView adminView = new AdminRoleAppView();
            adminView.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxUsername.Text) || string.IsNullOrEmpty(txtBoxPassword.Text)
                || string.IsNullOrEmpty(txtBoxRole.Text) || string.IsNullOrEmpty(txtBoxId.Text))
            {
                MessageBox.Show("Please dont leave the text boxes empty!", "EMPTY BOX DETECTED",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxUsername.Text = "";
                txtBoxPassword.Text = "";
                txtBoxRole.Text = "";
                txtBoxId.Text = "";
            }
            else if (userController.doesUsernameExist(txtBoxUsername.Text))
            {
                MessageBox.Show("Username already exists!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxUsername.Text = "";
                txtBoxPassword.Text = "";
                txtBoxRole.Text = "";
                txtBoxId.Text = "";
            }
            else if (userController.doesIdExist(int.Parse(txtBoxId.Text)))
            {
                MessageBox.Show("Id is being used!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxUsername.Text = "";
                txtBoxPassword.Text = "";
                txtBoxRole.Text = "";
                txtBoxId.Text = "";
            }
            else
            {
                User user = new User();
                user.Username = txtBoxUsername.Text;
                user.Password = txtBoxPassword.Text;
                user.Role = txtBoxRole.Text;
                user.Id = int.Parse(txtBoxId.Text);

                userController.RegisterUser(user);
                txtBoxUsername.Text = "";
                txtBoxPassword.Text = "";
                txtBoxRole.Text = "";
                txtBoxId.Text = "";
                RefreshTable();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvUserManagementView.CurrentRow;
            int id = int.Parse(row.Cells[0].Value.ToString());

            if (string.IsNullOrEmpty(txtEditName.Text) || string.IsNullOrEmpty(txtEditPass.Text)
                || string.IsNullOrEmpty(txtEditRole.Text))
            {
                MessageBox.Show("Please dont leave the text boxes empty!", "EMPTY BOX DETECTED",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEditName.Text = "";
                txtEditPass.Text = "";
                txtEditRole.Text = "";
            }
            else if(userController.doesUsernameExist(txtEditName.Text))
            {
                MessageBox.Show("Username already exists!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEditName.Text = "";
                txtEditPass.Text = "";
                txtEditRole.Text = "";
            }
            else
            {
                User user = new User();
                user.Username = txtEditName.Text;
                user.Password = txtEditPass.Text;
                user.Role = txtEditRole.Text;

                userController.EditUser(id, user);
                txtEditName.Text = "";
                txtEditPass.Text = "";
                txtEditRole.Text = "";
                RefreshTable();
            }
        }

        private void btnDeleteById_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxDeleteById.Text) || string.IsNullOrWhiteSpace(txtBoxDeleteById.Text))
            {
                MessageBox.Show("Please dont leave the text boxes empty!", "EMPTY BOX DETECTED",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!userController.doesIdExist(int.Parse(txtBoxDeleteById.Text)))
            {
                MessageBox.Show($"User with Id: ${txtBoxDeleteById.Text} doesn't exist!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Do really want to delete this user?", "IMPORTANT",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    DialogResult result2 = MessageBox.Show("By accepting this, you understand that every ToDo that this user created is going to be deleted too!", "IMPORTANT",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (result2 == DialogResult.OK)
                    {
                        int id = int.Parse(txtBoxDeleteById.Text);
                        userController.DeleteUser(id);
                        txtBoxDeleteById.Text = "";
                        RefreshTable();
                    }
                    else if (result2 == DialogResult.Cancel)
                    {
                        MessageBox.Show("No user was deleted.", "Response",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtBoxDeleteById.Text = "";
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("No user was deleted.", "Response",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBoxDeleteById.Text = "";
                }
            }
        }
    }
}
