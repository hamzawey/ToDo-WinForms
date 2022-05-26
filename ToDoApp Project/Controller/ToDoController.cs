using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp_Project.Model;
using ToDoApp_Project.View;

namespace ToDoApp_Project.Controller
{
    public class ToDoController
    {
        public List<ToDo> GetToDos(int currentUserId)
        {
            using (AppDbModelEntities todoEntities = new AppDbModelEntities())
            {
                List<ToDo> todosOwned = new List<ToDo>();
                foreach (var todo in todoEntities.ToDoes.ToList())
                {
                    if (todo.CreatorId == currentUserId)
                    {
                        todosOwned.Add(todo);
                    }
                }
                return todosOwned;
            }
        }
        public List<Model.Task> GetTasks(int currentToDoId)
        {
            using (AppDbModelEntities todoEntities = new AppDbModelEntities())
            {
                return todoEntities.Tasks.Where(task => task.ToDoId == currentToDoId).ToList();
            }
        }
        public bool doesToDoIdExist(int checkId)
        {
            using(AppDbModelEntities todoEntities = new AppDbModelEntities())
            {
                foreach (var todo in todoEntities.ToDoes.ToList())
                {
                    if (todo.Id == checkId)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        public bool doesToDoTitleExist(string checkTitle)
        {
            using (AppDbModelEntities todoEntities = new AppDbModelEntities())
            {
                foreach (var todo in todoEntities.ToDoes.ToList())
                {
                    if (todo.Title == checkTitle)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        public void deleteTaskById(int taskIdToDelete)
        {
            using (AppDbModelEntities taskEntities = new AppDbModelEntities())
            {
                var taskToDelete = taskEntities.Tasks.Where(task => task.Id == taskIdToDelete).FirstOrDefault();

                if (taskToDelete != null)
                {
                    taskEntities.Tasks.Remove(taskToDelete);
                    taskEntities.SaveChanges();
                }
            }
        }
        public void setTaskIsCompleted(int taskId)
        {
            using(AppDbModelEntities taskEntities = new AppDbModelEntities())
            {
                foreach (var task in taskEntities.Tasks.ToList())
                {
                    if(task.Id == taskId)
                    {
                        task.IsComplete = !task.IsComplete;
                        taskEntities.SaveChanges();
                        break;
                    }
                }
            }
        }
        public bool doesTaskTitleExist(string checkTaskTitle)
        {
            using (AppDbModelEntities taskEntities = new AppDbModelEntities())
            {
                foreach (var task in taskEntities.Tasks.ToList())
                {
                    if (task.Title == checkTaskTitle)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        public void CreateToDo(ToDo newToDo)
        {
            using (AppDbModelEntities todoEntities = new AppDbModelEntities())
            {
                todoEntities.ToDoes.Add(newToDo);
                todoEntities.SaveChanges();
            }
        }
        public bool doesTaskIdExist(int checkTaskId)
        {
            using (AppDbModelEntities taskEntities = new AppDbModelEntities())
            {
                foreach (var task in taskEntities.Tasks.ToList())
                {
                    if (task.Id == checkTaskId)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        public void deleteToDoById(int idToDelete)
        {
            using (AppDbModelEntities todoEntities = new AppDbModelEntities())
            {
                var todoToDelete = todoEntities.ToDoes.Where(todo => todo.Id == idToDelete).FirstOrDefault();

                if (todoToDelete != null)
                {
                    todoEntities.ToDoes.Remove(todoToDelete);
                    todoEntities.SaveChanges();
                }
            }
        }
        public bool updateToDo(int idToUpdate, string titleToUpdate)
        {
            using (AppDbModelEntities todoEntities = new AppDbModelEntities())
            {
                var todoToUpdate = todoEntities.ToDoes.Where(todo => todo.Id == idToUpdate).FirstOrDefault();

                if (todoToUpdate != null)
                {
                    todoToUpdate.Id = idToUpdate;
                    todoToUpdate.Title = titleToUpdate;
                    todoToUpdate.LastChanged = DateTime.Now;
                    todoToUpdate.LastChangedUserId = LoginView.currentUserId;
                    todoEntities.SaveChanges();
                    return true;
                }
                return false;
            }
        }
        public void createTask(Model.Task task)
        {
            using (AppDbModelEntities taskEntities = new AppDbModelEntities())
            {
                taskEntities.Tasks.Add(task);
                taskEntities.SaveChanges();
            }
        }

        public void updateTask(int updateTaskId, string updateTaskTitle, string updateTaskDescription, bool updateTaskIsComplete)
        {
            using (AppDbModelEntities taskEntities = new AppDbModelEntities())
            {
                var taskToUpdate = taskEntities.Tasks.Where(task => task.Id == updateTaskId).FirstOrDefault();

                if (taskToUpdate != null)
                {
                    taskToUpdate.Id = updateTaskId;
                    taskToUpdate.Title = updateTaskTitle;
                    taskToUpdate.Description = updateTaskDescription;
                    taskToUpdate.IsComplete = updateTaskIsComplete;
                    taskToUpdate.LastChanged = DateTime.Now;
                    taskToUpdate.LastChangeUserId = LoginView.currentUserId;
                    taskEntities.SaveChanges();
                }
            }
        }
    }
}
