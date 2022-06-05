using System;
using System.Windows.Forms;
using ToDoApp_Project.Controller;
using ToDoApp_Project.Model;

namespace ToDoApp_Project.View
{
    public partial class ManageToDos : Form
    {
        public static int currentToDoId;
        public static string currentToDoTitle;
        ToDoController todoController = new ToDoController();
        UserController userController = new UserController();
        public ManageToDos()
        {
            InitializeComponent();
        }

        private void ManageToDos_Load(object sender, EventArgs e)
        {
            RefreshTable();
            comboShareUser.DataSource = userController.GetAllButNoCurrent(Login.currentUserId);
        }

        private void RefreshTable()
        {
            dgvManageToDos.DataSource = todoController.GetOwnedToDos(Login.currentUserId);
        }

        private void ClearCreateBoxes()
        {
            txtCreateToDoId.Text = "";
            txtCreateToDoTitle.Text = "";
        }

        private void ClearEditBoxes()
        {
            txtEditToDoId.Text = "";
            txtEditToDoTitle.Text = "";
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            if (Login.currentUserRole == "Admin")
            {
                Hide();
                AdminMain view = new AdminMain();
                view.Show();
            }
            else
            {
                Hide();
                UserMain view = new UserMain();
                view.Show();
            }
        }

        private void btnUpdateToDo_Click(object sender, EventArgs e)
        {
            int.TryParse(txtEditToDoId.Text, out int isNumberResult);

            if (string.IsNullOrEmpty(txtEditToDoId.Text) || string.IsNullOrEmpty(txtEditToDoTitle.Text))
            {
                MessageBox.Show("Please dont leave the text boxes empty!", "EMPTY BOX DETECTED",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearEditBoxes();
            }
            else if (isNumberResult == 0)
            {
                MessageBox.Show("Id must be a number!", "PROVIDED DATA ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                ClearEditBoxes();
            }
            else if (txtEditToDoTitle.Text.Length < 5 || txtEditToDoTitle.Text.Length > 15)
            {
                MessageBox.Show("Title must be between 5 - 15 characters!", "PROVIDED DATA ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                ClearEditBoxes();
            }
            else if (!todoController.DoesToDoIdExist(int.Parse(txtEditToDoId.Text)))
            {
                MessageBox.Show($"ToDo with Id: {txtEditToDoId.Text} doesn't exist!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearEditBoxes();
            }
            else if (todoController.DoesToDoTitleExist(txtEditToDoTitle.Text))
            {
                MessageBox.Show($"ToDo with Title: {txtEditToDoTitle.Text} already exists!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearEditBoxes();
            }
            else
            {
                int idToUpdate = int.Parse(txtEditToDoId.Text);
                string titleToUpdate = txtEditToDoTitle.Text.TrimStart(' ', '@', '#', '$', '%', '^', '&', '*', '(', ')', '/', '<', '>', '`', ';', '-', '+', '=');
                bool result = todoController.UpdateToDo(idToUpdate, titleToUpdate);

                if (result)
                {
                    MessageBox.Show($"ToDo with Id: {txtEditToDoId.Text} was changed successfully!", "UPDATE SUCCESSFUL",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error occured while trying to update the ToDo.", "UPDATE ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                ClearEditBoxes();
                RefreshTable();
            }
        }

        private void btnCreateToDo_Click(object sender, EventArgs e)
        {
            int.TryParse(txtCreateToDoId.Text, out int isNumberResult);

            if (string.IsNullOrEmpty(txtCreateToDoId.Text) || string.IsNullOrEmpty(txtCreateToDoTitle.Text))
            {
                MessageBox.Show("Please dont leave the text boxes empty!", "EMPTY BOX DETECTED",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearCreateBoxes();
            }
            else if (isNumberResult == 0)
            {
                MessageBox.Show("Id must be a number!", "PROVIDED DATA ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                ClearCreateBoxes();
            }
            else if (txtCreateToDoTitle.Text.Length < 5 || txtCreateToDoTitle.Text.Length > 15)
            {
                MessageBox.Show("Title must be between 5 - 15 characters!", "PROVIDED DATA ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                ClearCreateBoxes();
            }
            else if (todoController.DoesToDoIdExist(int.Parse(txtCreateToDoId.Text)))
            {
                MessageBox.Show("Id is being used!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                ClearCreateBoxes();
            }
            else if (todoController.DoesToDoTitleExist(txtCreateToDoTitle.Text))
            {
                MessageBox.Show("Title already exists!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                ClearCreateBoxes();
            }
            else
            {
                ToDo newToDo = new ToDo();
                newToDo.Id = int.Parse(txtCreateToDoId.Text);
                string titleFixed = txtCreateToDoTitle.Text.TrimStart(' ', '@', '#', '$', '%', '^', '&', '*', '(', ')', '/', '<', '>', '`', ';', '-', '+', '=');
                newToDo.Title = titleFixed;
                newToDo.CreatedAt = DateTime.Now;
                newToDo.CreatorId = Login.currentUserId;
                newToDo.LastChanged = DateTime.Now;
                newToDo.LastChangedUserId = Login.currentUserId;

                todoController.CreateToDo(newToDo);

                RefreshTable();
                ClearCreateBoxes();
            }
        }

        private void btnDeleteByIdToDo_Click(object sender, EventArgs e)
        {
            int.TryParse(txtDeleteToDoById.Text, out int isNumberResult);

            if (string.IsNullOrEmpty(txtDeleteToDoById.Text))
            {
                MessageBox.Show("Please dont leave the text boxes empty!", "EMPTY BOX DETECTED",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtDeleteToDoById.Text = "";
            }
            else if (isNumberResult == 0)
            {
                MessageBox.Show("Id must be a number!", "PROVIDED DATA ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtDeleteToDoById.Text = "";
            }
            else if (!todoController.IsTodoOwner(int.Parse(txtDeleteToDoById.Text)))
            {
                // If he is not the todo owner, this todo must be deleted only from shared!
                todoController.RemoveFromShared(int.Parse(txtDeleteToDoById.Text), Login.currentUserName);

                MessageBox.Show("Shared ToDo was removed!", "INFORMATION",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtDeleteToDoById.Text = "";
                RefreshTable();
            }
            else if (!todoController.DoesToDoIdExist(int.Parse(txtDeleteToDoById.Text)))
            {
                MessageBox.Show("Id doesn't exist!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtDeleteToDoById.Text = "";
            }
            else
            {
                DialogResult result = MessageBox.Show($"Do really want to delete this ToDo with Id: {txtDeleteToDoById.Text}?", "IMPORTANT",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    todoController.DeleteToDoById(int.Parse(txtDeleteToDoById.Text));
                    txtDeleteToDoById.Text = "";
                    RefreshTable();
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show($"No ToDos were deleted.", "Response",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtDeleteToDoById.Text = "";
                }
            }
        }

        private void btnFindToDoTasks_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvManageToDos.CurrentRow;
            currentToDoId = int.Parse(row.Cells[0].Value.ToString());
            currentToDoTitle = row.Cells[1].Value.ToString();
            Hide();
            ManageTasks view = new ManageTasks();
            view.Show();
        }

        private void btnShareToDo_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvManageToDos.CurrentRow;

            if (!string.IsNullOrEmpty(comboShareUser.Text) && row != null)
            {
                int todoToShareId = int.Parse(row.Cells[0].Value.ToString());
                string userToShareName = comboShareUser.Text;
                if (!todoController.IsTodoOwner(todoToShareId))
                {
                    MessageBox.Show("YOU DONT OWN THIS ToDo!", "SECURITY",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!todoController.IsAlreadySharedTo(todoToShareId, userToShareName))
                {
                    todoController.ShareToDo(todoToShareId, userToShareName);
                }
                else
                {
                    MessageBox.Show("The selected user already has access to this ToDo!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Select user from the table, and dont forget to select user to share it with!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            RefreshTable();
        }
    }
}
