using System;
using System.Windows.Forms;
using ToDoApp_Project.Controller;
using ToDoApp_Project.Utilities;

namespace ToDoApp_Project.View
{
    public partial class ManageTasks : Form
    {
        ToDoController todoController = new ToDoController();

        public ManageTasks()
        {
            InitializeComponent();
        }

        private void ToDoTasks_Load(object sender, EventArgs e)
        {
            lblToDoNameForTasks.Text = $"(Id: {ManageToDos.currentToDoId}) {ManageToDos.currentToDoTitle} Tasks:";
            RefreshTable();
        }

        private void RefreshTable()
        {
            dgvTasks.DataSource = todoController.GetOwnTasks(ManageToDos.currentToDoId);
        }

        private void ClearCreateTextBoxes()
        {
            txtCreateTaskId.Text = "";
            txtCreateTaskTitle.Text = "";
            txtCreateTaskDescription.Text = "";
            txtCreateTaskToDoId.Text = "";
        }

        private void ClearEditTextBoxes()
        {
            txtEditTaskId.Text = "";
            txtEditTaskTitle.Text = "";
            txtEditTaskDescription.Text = "";
            txtEditTaskIsComplete.Text = "";
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

        private void btnToggleComplete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvTasks.CurrentRow;
            todoController.ChangeTaskStatus(int.Parse(row.Cells[0].Value.ToString()));
            RefreshTable();
        }

        private void btnUpdateTask_Click(object sender, EventArgs e)
        {
            int.TryParse(txtEditTaskId.Text, out int result);

            if (Validator.EmptyString(txtEditTaskId.Text) ||
                Validator.EmptyString(txtEditTaskTitle.Text) ||
                Validator.EmptyString(txtEditTaskDescription.Text) ||
                Validator.EmptyString(txtEditTaskIsComplete.Text))
            {
                MessageBox.Show("Please dont leave the text boxes empty!", "EMPTY BOX DETECTED",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                ClearEditTextBoxes();
            }
            else if (result == 0)
            {
                MessageBox.Show("Id must be a number!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                ClearEditTextBoxes();
            }
            else if (!Validator.NameLength(txtEditTaskTitle.Text))
            {
                MessageBox.Show("Title must be between 5 - 19 characters!", "PROVIDED DATA ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                ClearEditTextBoxes();
            }
            else if (!Validator.NameLength(txtEditTaskDescription.Text))
            {
                MessageBox.Show("Description must be between 5 - 49 characters!", "PROVIDED DATA ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                ClearEditTextBoxes();
            }
            else if (!todoController.TaskIdExist(int.Parse(txtEditTaskId.Text)))
            {
                MessageBox.Show($"Task with Id: {txtEditTaskId.Text} doesn't exist!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                ClearEditTextBoxes();
            }
            else if (todoController.TaskTitleExist(txtEditTaskTitle.Text))
            {
                MessageBox.Show($"The Title: {txtCreateTaskTitle.Text} already exists!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                ClearEditTextBoxes();
            }
            else
            {
                string fixedTitle = txtEditTaskTitle.Text.TrimStart(' ', '@', '#', '$', '%', '^', '&', '*', '(', ')', '/', '<', '>', '`', ';', '-', '+', '=');
                string fixedDescription = txtEditTaskDescription.Text.TrimStart(' ');

                if (txtEditTaskIsComplete.Text.ToLower() == "true")
                {
                    todoController.UpdateTask(int.Parse(txtEditTaskId.Text),
                        fixedTitle,
                        fixedDescription, 
                        true);

                    ClearEditTextBoxes();
                    RefreshTable();
                }
                else if (txtEditTaskIsComplete.Text.ToLower() == "false")
                {
                    todoController.UpdateTask(int.Parse(txtEditTaskId.Text),
                        fixedTitle,
                        fixedDescription, 
                        false);

                    ClearEditTextBoxes();
                    RefreshTable();
                }
                else
                {
                    MessageBox.Show("Text box IsComplete must be true or false!", "PROVIDED DATA ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                    ClearEditTextBoxes();
                }
                
            }
        }

        private void btnDeleteByIdTask_Click(object sender, EventArgs e)
        {
            int.TryParse(txtTaskDeleteById.Text, out int result);

            if (Validator.EmptyString(txtTaskDeleteById.Text))
            {
                MessageBox.Show("Please dont leave the text boxes empty!", "EMPTY BOX DETECTED",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtTaskDeleteById.Text = "";
            }
            else if (result == 0)
            {
                MessageBox.Show("Id must be a number!", "PROVIDED DATA ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtTaskDeleteById.Text = "";
            }
            else if (!todoController.IsTaskOwner(int.Parse(txtTaskDeleteById.Text)))
            {
                MessageBox.Show("You must own the task to delete it!\nAsk the creator of the task to delete it.", "WARNING",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtTaskDeleteById.Text = "";
            }
            else
            {
                todoController.DeleteTaskById(int.Parse(txtTaskDeleteById.Text));

                RefreshTable();
            }
        }

        private void btnCreateTask_Click(object sender, EventArgs e)
        {
            int.TryParse(txtCreateTaskId.Text, out int result);

            if (Validator.EmptyString(txtCreateTaskId.Text) ||
                Validator.EmptyString(txtCreateTaskTitle.Text) ||
                Validator.EmptyString(txtCreateTaskDescription.Text) ||
                Validator.EmptyString(txtCreateTaskToDoId.Text))
            {
                MessageBox.Show("Please dont leave the text boxes empty!", "EMPTY BOX DETECTED",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                ClearCreateTextBoxes();
            }
            else if (result == 0)
            {
                MessageBox.Show("Id must be a number!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                ClearCreateTextBoxes();
            }
            else if (!Validator.NameLength(txtCreateTaskTitle.Text))
            {
                MessageBox.Show("Title must be between 5 - 19 characters!", "PROVIDED DATA ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                ClearCreateTextBoxes();
            }
            else if (!Validator.NameLength(txtCreateTaskDescription.Text))
            {
                MessageBox.Show("Description must be between 6 - 49 characters!", "PROVIDED DATA ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                ClearCreateTextBoxes();
            }
            else if (!todoController.ToDoIdExist(int.Parse(txtCreateTaskToDoId.Text)))
            {
                MessageBox.Show($"ToDo with Id: {txtCreateTaskToDoId.Text} doesn't exist!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                ClearCreateTextBoxes();
            }
            else if (todoController.TaskIdExist(int.Parse(txtCreateTaskId.Text)))
            {
                MessageBox.Show($"Task Id {txtCreateTaskId.Text} is being used!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                ClearCreateTextBoxes();
            }
            else if (todoController.TaskTitleExist(txtCreateTaskTitle.Text))
            {
                MessageBox.Show($"The Title: {txtCreateTaskTitle.Text} already exists!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                ClearCreateTextBoxes();
            }
            else
            {
                Model.Task task = new Model.Task();

                string fixedTitle = txtCreateTaskTitle.Text.TrimStart(' ', '@', '#', '$', '%', '^', '&', '*', '(', ')', '/', '<', '>', '`', ';', '-', '+', '=');
                string fixedDescription = txtCreateTaskDescription.Text.TrimStart(' ');

                task.Id = int.Parse(txtCreateTaskId.Text);
                task.Title = fixedTitle;
                task.Description = fixedDescription;
                task.ToDoId = int.Parse(txtCreateTaskToDoId.Text);
                task.IsComplete = false;
                task.DateCreated = DateTime.Now;
                task.CreatorId = Login.currentUserId;
                task.LastChanged = DateTime.Now;
                task.LastChangeUserId = Login.currentUserId;

                todoController.CreateTask(task);
                ClearCreateTextBoxes();
                RefreshTable();
            }
        }
    }
}
