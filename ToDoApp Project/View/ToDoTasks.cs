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

namespace ToDoApp_Project.View
{
    public partial class ToDoTasks : Form
    {
        ToDoController todoController = new ToDoController();
        public ToDoTasks()
        {
            InitializeComponent();
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
        private void RefreshTable()
        {
            dgvTasks.DataSource = todoController.GetTasks(ToDosView.currentToDoId);
        }
        private void ToDoTasks_Load(object sender, EventArgs e)
        {
            lblToDoNameForTasks.Text = $"{ToDosView.currentToDoTitle} Tasks:";
            lblCompleteTask.Text = "To complete or remove from complete a task you have to select it from the table and click the button";
            RefreshTable();
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

        private void btnToggleComplete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvTasks.CurrentRow;
            todoController.setTaskIsCompleted(int.Parse(row.Cells[0].Value.ToString()));
            RefreshTable();
        }

        private void btnTaskDeleteById_Click(object sender, EventArgs e)
        {
            if (txtBoxDeleteById.Text != "")
            {
                int.TryParse(txtBoxDeleteById.Text, out int result);
                if (result != 0)
                {
                    todoController.deleteTaskById(int.Parse(txtBoxDeleteById.Text));
                    RefreshTable();
                }
                else
                {
                    MessageBox.Show("You must enter only numbers!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxDeleteById.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please dont leave the text boxes empty!", "EMPTY BOX DETECTED",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxDeleteById.Text = "";
            }
        }

        private void btnCreateNewTodo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCreateTaskId.Text) || string.IsNullOrEmpty(txtCreateTaskTitle.Text)
                || string.IsNullOrEmpty(txtCreateTaskDescription.Text) || string.IsNullOrEmpty(txtCreateTaskToDoId.Text))
            {
                MessageBox.Show("Please dont leave the text boxes empty!", "EMPTY BOX DETECTED",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearCreateTextBoxes();
            }
            else if (!todoController.doesToDoIdExist(int.Parse(txtCreateTaskToDoId.Text)))
            {
                MessageBox.Show($"ToDo with Id: ${txtCreateTaskToDoId} doesn't exist!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearCreateTextBoxes();
            }
            else if (todoController.doesTaskIdExist(int.Parse(txtCreateTaskId.Text)))
            {
                MessageBox.Show($"Id {txtCreateTaskId.Text} is being used!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearCreateTextBoxes();
            }
            else if (todoController.doesTaskTitleExist(txtCreateTaskTitle.Text))
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
                task.CreatorId = LoginView.currentUserId;
                task.LastChanged = DateTime.Now;
                task.LastChangeUserId = LoginView.currentUserId;

                todoController.createTask(task);
                ClearCreateTextBoxes();
                RefreshTable();
            }
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
            else if (!todoController.doesTaskIdExist(int.Parse(txtEditTaskId.Text)))
            {
                MessageBox.Show($"Task with Id: ${txtEditTaskId.Text} doesn't exist!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearEditTextBoxes();
            }
            else if (todoController.doesTaskTitleExist(txtEditTaskTitle.Text))
            {
                MessageBox.Show($"The Title: {txtCreateTaskTitle.Text} already exists!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearEditTextBoxes();
            }
            else
            {
                if (txtEditTaskIsComplete.Text.ToLower() != "true")
                {
                    todoController.updateTask(int.Parse(txtEditTaskId.Text), txtEditTaskTitle.Text, txtEditTaskDescription.Text, bool.Parse(txtEditTaskIsComplete.Text.ToLower()));
                    ClearEditTextBoxes();
                    RefreshTable();
                }
                else if (txtEditTaskIsComplete.Text.ToLower() != "false")
                {
                    todoController.updateTask(int.Parse(txtEditTaskId.Text), txtEditTaskTitle.Text, txtEditTaskDescription.Text, bool.Parse(txtEditTaskIsComplete.Text.ToLower()));
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
    }
}
