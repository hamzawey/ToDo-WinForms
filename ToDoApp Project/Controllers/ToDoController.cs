using System;
using System.Collections.Generic;
using System.Linq;
using ToDoApp_Project.Model;
using ToDoApp_Project.View;

namespace ToDoApp_Project.Controller
{
    public class ToDoController
    {
        private readonly AppDbModelEntities _dbContext = new AppDbModelEntities();

        public List<ToDo> GetOwnedToDos(int currentUserId)
        {
            return _dbContext.ToDoes.Where(todo => todo.CreatorId == currentUserId).ToList();
        }

        public List<Task> GetOwnedTasks(int currentToDoId)
        {
            return _dbContext.Tasks.Where(task => task.ToDoId == currentToDoId).ToList();
        }

        public bool DoesToDoIdExist(int checkId)
        {
            foreach (var todo in _dbContext.ToDoes.ToList())
            {
                if (todo.Id == checkId)
                {
                    return true;
                }
            }

            return false;
        }

        public bool DoesToDoTitleExist(string checkTitle)
        {
            foreach (var todo in _dbContext.ToDoes.ToList())
            {
                if (todo.Title == checkTitle)
                {
                    return true;
                }
            }

            return false;
        }

        public void DeleteTaskById(int taskIdToDelete)
        {
            var taskToDelete = _dbContext.Tasks.Where(task => task.Id == taskIdToDelete).FirstOrDefault();

            if (taskToDelete != null)
            {
                _dbContext.Tasks.Remove(taskToDelete);
                _dbContext.SaveChanges();
            }
        }

        public void ToggleTaskIsCompleted(int taskId)
        {
            var taskFound = _dbContext.Tasks.Where(task => task.Id == taskId).FirstOrDefault();
            taskFound.IsComplete = !taskFound.IsComplete;

            _dbContext.SaveChanges();
        }

        public bool DoesTaskTitleExist(string checkTaskTitle)
        {
            foreach (var task in _dbContext.Tasks.ToList())
            {
                if (task.Title == checkTaskTitle)
                {
                    return true;
                }
            }

            return false;
        }

        public void CreateToDo(ToDo newToDo)
        {
            _dbContext.ToDoes.Add(newToDo);
            _dbContext.SaveChanges();
        }

        public bool DoesTaskIdExist(int checkTaskId)
        {
            foreach (var task in _dbContext.Tasks.ToList())
            {
                if (task.Id == checkTaskId)
                {
                    return true;
                }
            }

            return false;
        }

        public void DeleteToDoById(int idToDelete)
        {
            var todoToDelete = _dbContext.ToDoes.Where(todo => todo.Id == idToDelete).FirstOrDefault();

            if (todoToDelete != null)
            {
                _dbContext.ToDoes.Remove(todoToDelete);
                _dbContext.SaveChanges();
            }
        }

        public bool UpdateToDo(int idToUpdate, string titleToUpdate)
        {
            var todoToUpdate = _dbContext.ToDoes.Where(todo => todo.Id == idToUpdate).FirstOrDefault();

            if (todoToUpdate != null)
            {
                todoToUpdate.Id = idToUpdate;
                todoToUpdate.Title = titleToUpdate;
                todoToUpdate.LastChanged = DateTime.Now;
                todoToUpdate.LastChangedUserId = Login.currentUserId;

                _dbContext.SaveChanges();

                return true;
            }

            return false;
        }

        public void CreateTask(Task task)
        {
            _dbContext.Tasks.Add(task);
            _dbContext.SaveChanges();
        }

        public void UpdateTask(int updateTaskId, string updateTaskTitle, string updateTaskDescription, bool updateTaskIsComplete)
        {
            var taskToUpdate = _dbContext.Tasks.Where(task => task.Id == updateTaskId).FirstOrDefault();

            if (taskToUpdate != null)
            {
                taskToUpdate.Id = updateTaskId;
                taskToUpdate.Title = updateTaskTitle;
                taskToUpdate.Description = updateTaskDescription;
                taskToUpdate.IsComplete = updateTaskIsComplete;
                taskToUpdate.LastChanged = DateTime.Now;
                taskToUpdate.LastChangeUserId = Login.currentUserId;

                _dbContext.SaveChanges();
            }
        }
    }
}
