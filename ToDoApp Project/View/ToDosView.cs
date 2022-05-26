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
        ToDoController todoController = new ToDoController();
        public ToDosView()
        {
            InitializeComponent();
        }

        private void ToDosView_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

        public void RefreshTable()
        {
            toDosDataGridView.DataSource = todoController.GetToDos(LoginView.currentUserId);
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
                txtCreateId.Text = "";
                txtCreateTitle.Text = "";
            }
            else if(todoController.doesIdExist(int.Parse(txtCreateId.Text)))
            {
                MessageBox.Show("Id is being used!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCreateId.Text = "";
                txtCreateTitle.Text = "";
            }
            else if (todoController.doesTitleExist(txtCreateTitle.Text))
            {
                MessageBox.Show("Title already exists!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCreateId.Text = "";
                txtCreateTitle.Text = "";
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
                txtCreateId.Text = "";
                txtCreateTitle.Text = "";
                RefreshTable();
            }
        }

        private void btnUpdateToDo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEditId.Text) || string.IsNullOrEmpty(txtEditTitle.Text))
            {
                MessageBox.Show("Please dont leave the text boxes empty!", "EMPTY BOX DETECTED",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEditId.Text = "";
                txtEditTitle.Text = "";
            }
            else if (!todoController.doesIdExist(int.Parse(txtEditId.Text)))
            {
                MessageBox.Show($"ToDo with Id: {txtEditId.Text} doesn't exist!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEditId.Text = "";
                txtEditTitle.Text = "";
            }
            else if (todoController.doesTitleExist(txtEditTitle.Text))
            {
                MessageBox.Show($"ToDo with Title: {txtEditTitle.Text} already exists!", "PROVIDED DATA ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEditId.Text = "";
                txtEditTitle.Text = "";
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
                txtEditId.Text = "";
                txtEditTitle.Text = "";
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
            else if (!todoController.doesIdExist(int.Parse(txtDeleteById.Text)))
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
                    todoController.deleteById(int.Parse(txtDeleteById.Text));
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
    }
}
