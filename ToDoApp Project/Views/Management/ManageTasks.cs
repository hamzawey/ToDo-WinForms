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
            lblToDoNameForTasks.Text = $"{ManageToDos.currentToDoTitle} Tasks:";
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
                AdminView view = new AdminView();
                view.Show();
            }
            else
            {
                Hide();
                UserView view = new UserView();
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
            if (string.IsNullOrEmpty(txtEditTaskId.Text) || string.IsNullOrEmpty(txtEditTaskTitle.Text)
                || string.IsNullOrEmpty(txtEditTaskDescription.Text) || string.IsNullOrEmpty(txtEditTaskIsComplete.Text))
            {
                MessageBox.Show("Please dont leave the text boxes empty!", "EMPTY BOX DETECTED",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearEditTextBoxes();
            }
            else if (!todoController.DoesTaskIdExist(int.Parse(txtEditTaskId.Text)))
            {
                MessageBox.Show($"Task with Id: ${txtEditTaskId.Text} doesn't exist!", "PROVIDED DATA ERROR",
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
                if (txtEditTaskIsComplete.Text.ToLower() != "true")
                {
                    todoController.UpdateTask(int.Parse(txtEditTaskId.Text), 
                        txtEditTaskTitle.Text, 
                        txtEditTaskDescription.Text, 
                        bool.Parse(txtEditTaskIsComplete.Text.ToLower()));
                    ClearEditTextBoxes();
                    RefreshTable();
                }
                else if (txtEditTaskIsComplete.Text.ToLower() != "false")
                {
                    todoController.UpdateTask(int.Parse(txtEditTaskId.Text), 
                        txtEditTaskTitle.Text, 
                        txtEditTaskDescription.Text, 
                        bool.Parse(txtEditTaskIsComplete.Text.ToLower()));
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
            if (!string.IsNullOrEmpty(txtTaskDeleteById.Text))
            {
                int.TryParse(txtTaskDeleteById.Text, out int result);

                if (result != 0)
                {
                    todoController.DeleteTaskById(int.Parse(txtTaskDeleteById.Text));
                    RefreshTable();
                }
                else
                {
                    MessageBox.Show("You must enter only numbers!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTaskDeleteById.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please dont leave the text boxes empty!", "EMPTY BOX DETECTED",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaskDeleteById.Text = "";
            }
        }

        private void btnCreateTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCreateTaskId.Text) || string.IsNullOrEmpty(txtCreateTaskTitle.Text)
                || string.IsNullOrEmpty(txtCreateTaskDescription.Text) || string.IsNullOrEmpty(txtCreateTaskToDoId.Text))
            {
                MessageBox.Show("Please dont leave the text boxes empty!", "EMPTY BOX DETECTED",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearCreateTextBoxes();
            }
            else if (!todoController.DoesToDoIdExist(int.Parse(txtCreateTaskToDoId.Text)))
            {
                MessageBox.Show($"ToDo with Id: ${txtCreateTaskToDoId} doesn't exist!", "PROVIDED DATA ERROR",
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
                task.Id = int.Parse(txtCreateTaskId.Text);
                task.Title = txtCreateTaskTitle.Text;
                task.Description = txtCreateTaskDescription.Text;
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
