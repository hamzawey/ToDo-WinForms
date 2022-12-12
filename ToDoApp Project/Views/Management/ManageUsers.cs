using System;
using System.Windows.Forms;
using ToDoApp_Project.Controller;
using ToDoApp_Project.Model;
using ToDoApp_Project.Utilities;

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
            dgvManageUsers.DataSource = userController.GetAll();
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
            AdminMain view = new AdminMain();
            view.Show();
        }

        private void btnManageCreate_Click(object sender, EventArgs e)
        {
            int.TryParse(txtManageCreateId.Text, out int isNumberResult);

            if (Validator.NameLength(txtManageCreateUsername.Text) ||
                Validator.NameLength(txtManageCreatePassword.Text) ||
                Validator.NameLength(txtManageCreateRole.Text) ||
                Validator.NameLength(txtManageCreateId.Text))
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
            else if (!Validator.NameLength(txtManageCreateUsername.Text))
            {
                MessageBox.Show("Name must be between 3 - 19 characters!", "PROVIDED DATA ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                ClearCreateBoxes();
            }
            else if (!Validator.NameLength(txtManageCreatePassword.Text))
            {
                MessageBox.Show("Password must be between 6 - 19 characters!", "PROVIDED DATA ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                ClearCreateBoxes();
            }
            else if (userController.UsernameExist(txtManageCreateUsername.Text))
            {
                MessageBox.Show("Username already exists!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearCreateBoxes();
            }
            else if (userController.UserIdExist(int.Parse(txtManageCreateId.Text)))
            {
                MessageBox.Show("Id is being used!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearCreateBoxes();
            }
            else
            {
                DialogResult result = MessageBox.Show($"Do you really want to continue with these changes?\n" +
                    $"Id => {txtManageCreateId.Text}\n" +
                    $"Username => {txtManageCreateUsername.Text}\n" +
                    $"Password => {txtManageCreatePassword.Text}\n" +
                    $"Role => {txtManageCreateRole.Text}", "IMPORTANT",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    if (txtManageCreateRole.Text == "Admin")
                    {
                        User user = new User();
                        string usernameFixed = txtManageCreateUsername.Text.TrimStart(' ', '@', '#', '$', '%', '^', '&', '*', '(', ')', '/', '<', '>', '`', ';', '-', '+', '=');
                        user.Username = usernameFixed;
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
                    if (id == Login.currentUserId)
                    {
                        MessageBox.Show("You are currently logged with this user and cannot delete it.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        userController.DeleteUserById(id);
                        RefreshTable();
                    }
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
            int.TryParse(txtManageDeleteById.Text, out int isNumberResult);

            if (Validator.EmptyString(txtManageDeleteById.Text))
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
            else if (!userController.UserIdExist(int.Parse(txtManageDeleteById.Text)))
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

                        if (id == Login.currentUserId)
                        {
                            MessageBox.Show("You are currently logged with this user and cannot delete it.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            userController.DeleteUserById(id);
                            txtManageDeleteById.Text = "";
                            RefreshTable();
                        }
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

            if (Validator.EmptyString(txtManageEditUsername.Text) ||
                Validator.EmptyString(txtManageEditPassword.Text) ||
                Validator.EmptyString(txtManageEditRole.Text))
            {
                EmptyBoxMessage();
                ClearEditBoxes();
            }
            else if (!Validator.NameLength(txtManageEditUsername.Text))
            {
                MessageBox.Show("Name must be between 3 - 19 characters!", "PROVIDED DATA ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                ClearEditBoxes();
            }
            else if (!Validator.NameLength(txtManageEditPassword.Text))
            {
                MessageBox.Show("Password must be between 6 - 19 characters!", "PROVIDED DATA ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                ClearEditBoxes();
            }
            else if (userController.UsernameExist(txtManageEditUsername.Text))
            {
                MessageBox.Show("Username already exists!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearEditBoxes();
            }
            else
            {
                DialogResult result = MessageBox.Show($"Do you really want to continue with these changes?\n" +
                    $"{row.Cells[1].Value} => {txtManageEditUsername.Text}\n" +
                    $"{row.Cells[2].Value} => {txtManageEditPassword.Text}\n" +
                    $"{row.Cells[3].Value} => {txtManageEditRole.Text}", "IMPORTANT",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    if (txtManageEditRole.Text == "Admin")
                    {
                        User user = new User();
                        string usernameFixed = txtManageEditUsername.Text.TrimStart(' ', '@', '#', '$', '%', '^', '&', '*', '(', ')', '/', '<', '>', '`', ';', '-', '+', '=');
                        user.Username = usernameFixed;
                        user.Password = txtManageEditPassword.Text;
                        user.Role = txtManageEditRole.Text;

                        userController.Edit(id, user);
                        ClearEditBoxes();
                        RefreshTable();
                    }
                    else if (txtManageEditRole.Text == "User")
                    {
                        User user = new User();
                        user.Username = txtManageEditUsername.Text;
                        user.Password = txtManageEditPassword.Text;
                        user.Role = txtManageEditRole.Text;

                        userController.Edit(id, user);
                        ClearEditBoxes();
                        RefreshTable();
                    }
                    else
                    {
                        MessageBox.Show("Role must be only User or Admin!", "PROVIDED DATA ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearEditBoxes();
                    }
                }
            }
        }
    }
}
