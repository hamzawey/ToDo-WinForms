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
    public partial class ToDosView : Form
    {
        public static int currentToDoId;
        public static string currentToDoTitle;
        ToDoController todoController = new ToDoController();
        public ToDosView()
        {
            InitializeComponent();
        }

        private void ToDosView_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void RefreshTable()
        {
            toDosDataGridView.DataSource = todoController.GetToDos(LoginView.currentUserId);
        }

        private void ClearCreateBoxes()
        {
            txtCreateId.Text = "";
            txtCreateTitle.Text = "";
        }

        private void ClearEditBoxes()
        {
            txtEditId.Text = "";
            txtEditTitle.Text = "";
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

        private void btnCreateNewTodo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCreateId.Text) || string.IsNullOrEmpty(txtCreateTitle.Text))
            {
                MessageBox.Show("Please dont leave the text boxes empty!", "EMPTY BOX DETECTED",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearCreateBoxes();
            }
            else if(todoController.doesToDoIdExist(int.Parse(txtCreateId.Text)))
            {
                MessageBox.Show("Id is being used!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearCreateBoxes();
            }
            else if (todoController.doesToDoTitleExist(txtCreateTitle.Text))
            {
                MessageBox.Show("Title already exists!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearCreateBoxes();
            }
            else
            {
                ToDo newToDo = new ToDo();
                newToDo.Id = int.Parse(txtCreateId.Text);
                newToDo.Title = txtCreateTitle.Text;
                newToDo.CreatedAt = DateTime.Now;
                newToDo.CreatorId = LoginView.currentUserId;
                newToDo.LastChanged = DateTime.Now;
                newToDo.LastChangedUserId = LoginView.currentUserId;
                todoController.CreateToDo(newToDo);
                ClearCreateBoxes();
                RefreshTable();
            }
        }

        private void btnUpdateToDo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEditId.Text) || string.IsNullOrEmpty(txtEditTitle.Text))
            {
                MessageBox.Show("Please dont leave the text boxes empty!", "EMPTY BOX DETECTED",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearEditBoxes();
            }
            else if (!todoController.doesToDoIdExist(int.Parse(txtEditId.Text)))
            {
                MessageBox.Show($"ToDo with Id: {txtEditId.Text} doesn't exist!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearEditBoxes();
            }
            else if (todoController.doesToDoTitleExist(txtEditTitle.Text))
            {
                MessageBox.Show($"ToDo with Title: {txtEditTitle.Text} already exists!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearEditBoxes();
            }
            else
            {
                int idToUpdate = int.Parse(txtEditId.Text);
                string titleToUpdate = txtEditTitle.Text;
                bool result = todoController.updateToDo(idToUpdate, titleToUpdate);
                if (result)
                {
                    MessageBox.Show($"ToDo with Id: {txtEditId.Text} was changed successfully!", "UPDATE SUCCESSFUL",
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

        private void btnDeleteByIdTodo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDeleteById.Text))
            {
                MessageBox.Show("Please dont leave the text boxes empty!", "EMPTY BOX DETECTED",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!todoController.doesToDoIdExist(int.Parse(txtDeleteById.Text)))
            {
                MessageBox.Show("Id doesn't exist!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = MessageBox.Show($"Do really want to delete this ToDo with Id: {txtDeleteById.Text}?", "IMPORTANT",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    todoController.deleteToDoById(int.Parse(txtDeleteById.Text));
                    txtDeleteById.Text = "";
                    RefreshTable();
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show($"No ToDos were deleted?", "Response",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnFindTasks_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = toDosDataGridView.CurrentRow;
            currentToDoId = int.Parse(row.Cells[0].Value.ToString());
            currentToDoTitle = row.Cells[1].Value.ToString();
            Hide();
            ToDoTasks view = new ToDoTasks();
            view.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
