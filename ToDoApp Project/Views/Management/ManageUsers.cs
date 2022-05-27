using System;
using System.Windows.Forms;
using ToDoApp_Project.Controller;
using ToDoApp_Project.Model;

namespace ToDoApp_Project.View
{
    public partial class ManageUsers : Form
    {
        UserController userController = new UserController();

        public ManageUsers()
        {
            InitializeComponent();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void RefreshTable()
        {
            dgvManageUsers.DataSource = userController.GetAllUsers();
        }

        private void EmptyBoxMessage()
        {
            MessageBox.Show("Please dont leave the text boxes empty!", "EMPTY BOX DETECTED",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ClearCreateBoxes()
        {
            txtManageCreateUsername.Text = "";
            txtManageCreatePassword.Text = "";
            txtManageCreateRole.Text = "";
            txtManageCreateId.Text = "";
        }

        private void ClearEditBoxes()
        {
            txtManageEditUsername.Text = "";
            txtManageEditPassword.Text = "";
            txtManageEditRole.Text = "";
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Hide();
            AdminView view = new AdminView();
            view.Show();
        }

        private void btnManageCreate_Click(object sender, EventArgs e)
        {
            int.TryParse(txtManageCreateId.Text, out int isNumberResult);

            if (string.IsNullOrEmpty(txtManageCreateUsername.Text) || string.IsNullOrEmpty(txtManageCreatePassword.Text)
                || string.IsNullOrEmpty(txtManageCreateRole.Text) || string.IsNullOrEmpty(txtManageCreateId.Text))
            {
                EmptyBoxMessage();
                ClearCreateBoxes();
            }
            else if (isNumberResult == 0)
            {
                MessageBox.Show("Id must be a number!", "PROVIDED DATA ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearCreateBoxes();
            }
            else if (userController.DoesUsernameExist(txtManageCreateUsername.Text))
            {
                MessageBox.Show("Username already exists!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearCreateBoxes();
            }
            else if (userController.DoesUserIdExist(int.Parse(txtManageCreateId.Text)))
            {
                MessageBox.Show("Id is being used!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearCreateBoxes();
            }
            else
            {
                if (txtManageCreateRole.Text == "Admin")
                {
                    User user = new User();
                    user.Username = txtManageCreateUsername.Text;
                    user.Password = txtManageCreatePassword.Text;
                    user.Role = txtManageCreateRole.Text;
                    user.Id = int.Parse(txtManageCreateId.Text);

                    userController.ManageMenuRegisterUser(user);
                    ClearCreateBoxes();
                    RefreshTable();
                }
                else if (txtManageCreateRole.Text == "User")
                {
                    User user = new User();
                    user.Username = txtManageCreateUsername.Text;
                    user.Password = txtManageCreatePassword.Text;
                    user.Role = txtManageCreateRole.Text;
                    user.Id = int.Parse(txtManageCreateId.Text);

                    userController.ManageMenuRegisterUser(user);
                    ClearCreateBoxes();
                    RefreshTable();
                }
                else
                {
                    MessageBox.Show("Role must be only User or Admin!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearCreateBoxes();
                }
            }
        }

        private void btnManageDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do really want to delete this user?", "IMPORTANT",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                DialogResult result2 = MessageBox.Show("By accepting this, you understand that every ToDo and Task that this user created is going to be deleted too!", "IMPORTANT",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result2 == DialogResult.OK)
                {
                    DataGridViewRow row = dgvManageUsers.CurrentRow;
                    int id = int.Parse(row.Cells[0].Value.ToString());
                    userController.DeleteUserById(id);
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

        private void btnManageDeleteById_Click(object sender, EventArgs e)
        {
            int.TryParse(txtManageCreateId.Text, out int isNumberResult);

            if (string.IsNullOrEmpty(txtManageDeleteById.Text) || string.IsNullOrWhiteSpace(txtManageDeleteById.Text))
            {
                EmptyBoxMessage();
                txtManageDeleteById.Text = "";
            }
            else if (isNumberResult == 0)
            {
                MessageBox.Show("Id must be a number!", "PROVIDED DATA ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtManageDeleteById.Text = "";
            }
            else if (!userController.DoesUserIdExist(int.Parse(txtManageDeleteById.Text)))
            {
                MessageBox.Show($"User with Id: ${txtManageDeleteById.Text} doesn't exist!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtManageDeleteById.Text = "";
            }
            else
            {
                DialogResult result = MessageBox.Show("Do really want to delete this user?", "IMPORTANT",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    DialogResult result2 = MessageBox.Show("By accepting this, you understand that every ToDo and Task that this user created is going to be deleted too!", "IMPORTANT",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (result2 == DialogResult.OK)
                    {
                        int id = int.Parse(txtManageDeleteById.Text);
                        userController.DeleteUserById(id);
                        txtManageDeleteById.Text = "";
                        RefreshTable();
                    }
                    else if (result2 == DialogResult.Cancel)
                    {
                        MessageBox.Show("No user was deleted.", "Response",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtManageDeleteById.Text = "";
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("No user was deleted.", "Response",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtManageDeleteById.Text = "";
                }
            }
        }

        private void btnManageEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvManageUsers.CurrentRow;
            int id = int.Parse(row.Cells[0].Value.ToString());

            if (string.IsNullOrEmpty(txtManageEditUsername.Text) || string.IsNullOrEmpty(txtManageEditPassword.Text)
                || string.IsNullOrEmpty(txtManageEditRole.Text))
            {
                EmptyBoxMessage();
                ClearEditBoxes();
            }
            else if (userController.DoesUsernameExist(txtManageEditUsername.Text))
            {
                MessageBox.Show("Username already exists!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearEditBoxes();
            }
            else
            {
                User user = new User();
                user.Username = txtManageEditUsername.Text;
                user.Password = txtManageEditPassword.Text;
                user.Role = txtManageEditRole.Text;

                userController.EditUser(id, user);
                ClearEditBoxes();
                RefreshTable();
            }
        }
    }
}
