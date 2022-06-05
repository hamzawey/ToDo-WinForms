using System;
using System.Windows.Forms;
using ToDoApp_Project.Controller;

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
            dgvTasks.DataSource = todoController.GetOwnedTasks(ManageToDos.currentToDoId);
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
            todoController.ToggleTaskIsCompleted(int.Parse(row.Cells[0].Value.ToString()));
            RefreshTable();
        }

        private void btnUpdateTask_Click(object sender, EventArgs e)
        {
            int.TryParse(txtEditTaskId.Text, out int result);

            if (string.IsNullOrEmpty(txtEditTaskId.Text) || string.IsNullOrEmpty(txtEditTaskTitle.Text)
                || string.IsNullOrEmpty(txtEditTaskDescription.Text) || string.IsNullOrEmpty(txtEditTaskIsComplete.Text))
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
            else if (txtEditTaskTitle.Text.Length < 5 || txtEditTaskTitle.Text.Length > 19)
            {
                MessageBox.Show("Title must be between 5 - 19 characters!", "PROVIDED DATA ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                ClearEditTextBoxes();
            }
            else if (txtEditTaskDescription.Text.Length < 5 || txtEditTaskDescription.Text.Length > 49)
            {
                MessageBox.Show("Description must be between 5 - 49 characters!", "PROVIDED DATA ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                ClearEditTextBoxes();
            }
            else if (!todoController.DoesTaskIdExist(int.Parse(txtEditTaskId.Text)))
            {
                MessageBox.Show($"Task with Id: {txtEditTaskId.Text} doesn't exist!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                ClearEditTextBoxes();
            }
            else if (todoController.DoesTaskTitleExist(txtEditTaskTitle.Text))
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

            if (string.IsNullOrEmpty(txtTaskDeleteById.Text))
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
            if (string.IsNullOrEmpty(txtCreateTaskId.Text) || string.IsNullOrEmpty(txtCreateTaskTitle.Text)
                || string.IsNullOrEmpty(txtCreateTaskDescription.Text) || string.IsNullOrEmpty(txtCreateTaskToDoId.Text))
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
            else if (txtCreateTaskTitle.Text.Length < 5 || txtCreateTaskTitle.Text.Length > 19)
            {
                MessageBox.Show("Title must be between 5 - 19 characters!", "PROVIDED DATA ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                ClearCreateTextBoxes();
            }
            else if (txtCreateTaskDescription.Text.Length < 6 || txtCreateTaskDescription.Text.Length > 49)
            {
                MessageBox.Show("Description must be between 6 - 49 characters!", "PROVIDED DATA ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                ClearCreateTextBoxes();
            }
            else if (!todoController.DoesToDoIdExist(int.Parse(txtCreateTaskToDoId.Text)))
            {
                MessageBox.Show($"ToDo with Id: {txtCreateTaskToDoId.Text} doesn't exist!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                ClearCreateTextBoxes();
            }
            else if (todoController.DoesTaskIdExist(int.Parse(txtCreateTaskId.Text)))
            {
                MessageBox.Show($"Task Id {txtCreateTaskId.Text} is being used!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                ClearCreateTextBoxes();
            }
            else if (todoController.DoesTaskTitleExist(txtCreateTaskTitle.Text))
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
