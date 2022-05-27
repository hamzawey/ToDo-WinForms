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
        public ManageToDos()
        {
            InitializeComponent();
        }

        private void ManageToDos_Load(object sender, EventArgs e)
        {
            RefreshTable();
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

        private void btnUpdateToDo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEditToDoId.Text) || string.IsNullOrEmpty(txtEditToDoTitle.Text))
            {
                MessageBox.Show("Please dont leave the text boxes empty!", "EMPTY BOX DETECTED",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                string titleToUpdate = txtEditToDoTitle.Text;
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
            if (string.IsNullOrEmpty(txtCreateToDoId.Text) || string.IsNullOrEmpty(txtCreateToDoTitle.Text))
            {
                MessageBox.Show("Please dont leave the text boxes empty!", "EMPTY BOX DETECTED",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                newToDo.Title = txtCreateToDoTitle.Text;
                newToDo.CreatedAt = DateTime.Now;
                newToDo.CreatorId = Login.currentUserId;
                newToDo.LastChanged = DateTime.Now;
                newToDo.LastChangedUserId = Login.currentUserId;
                todoController.CreateToDo(newToDo);
                ClearCreateBoxes();
                RefreshTable();
            }
        }

        private void btnDeleteByIdToDo_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDeleteToDoById.Text))
            {
                MessageBox.Show("Please dont leave the text boxes empty!", "EMPTY BOX DETECTED",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!todoController.DoesToDoIdExist(int.Parse(txtDeleteToDoById.Text)))
            {
                MessageBox.Show("Id doesn't exist!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show($"No ToDos were deleted?", "Response",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
