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

        // TODO ONLY METHODS
        public List<ToDo> GetOwnedToDos(int currentUserId)
        {
            List<ToDo> ownedToDos = new List<ToDo>();

            foreach (var todo in _dbContext.ToDoes.Where(todo => todo.CreatorId == currentUserId).ToList())
            {
                ownedToDos.Add(todo);
            }

            List<int?> todoIds = new List<int?>();

            foreach (var sharedToDo in _dbContext.SharedToDoes.
                Where(sharedToDo => sharedToDo.SharedTo == Login.currentUserName).ToList())
            {
                todoIds.Add(sharedToDo.ToDoId);
            }

            foreach (var todoId in todoIds)
            {
                ownedToDos.Add(_dbContext.ToDoes.Where(todo => todo.Id == todoId).FirstOrDefault());
            }

            return ownedToDos;
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

        public void CreateToDo(ToDo newToDo)
        {
            _dbContext.ToDoes.Add(newToDo);
            _dbContext.SaveChanges();
        }

        public void DeleteToDoById(int idToDelete)
        {
            var todoToDelete = _dbContext.ToDoes.Where(todo => todo.Id == idToDelete).FirstOrDefault();

            if (todoToDelete != null)
            {
                foreach (var task in _dbContext.Tasks.Where(task => task.ToDoId == idToDelete).ToList())
                {
                    _dbContext.Tasks.Remove(task);
                }

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

        // TASKS ONLY METHODS
        public List<Task> GetOwnedTasks(int currentToDoId)
        {
            return _dbContext.Tasks.Where(task => task.ToDoId == currentToDoId).ToList();
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

        public void ShareToDo(int todoToShareId, string userToShareName)
        {
            SharedToDo sharedToDo = new SharedToDo();

            if (_dbContext.SharedToDoes.ToList().LastOrDefault() != null)
            {
                sharedToDo.Id = _dbContext.SharedToDoes.ToList().LastOrDefault().Id + 1;
                sharedToDo.SharedTo = userToShareName;
                sharedToDo.SharedBy = Login.currentUserName;
                sharedToDo.ToDoId = todoToShareId;
            }
            else
            {
                sharedToDo.Id = 1;
                sharedToDo.SharedTo = userToShareName;
                sharedToDo.SharedBy = Login.currentUserName;
                sharedToDo.ToDoId = todoToShareId;
            }

            _dbContext.SharedToDoes.Add(sharedToDo);
            _dbContext.SaveChanges();
        }

        public bool IsTaskOwner(int taskId)
        {
            var result = _dbContext.Tasks
                .Where(task => (task.Id == taskId) && (task.CreatorId == Login.currentUserId))
                .FirstOrDefault();

            return result == null ? false : true;
        }

        public bool IsTodoOwner(int checkTodoId)
        {
            var result = _dbContext.ToDoes
                .Where(todo => (todo.Id == checkTodoId) && (todo.CreatorId == Login.currentUserId))
                .ToList();

            return result.Count == 0 ? false : true;
        }

        public bool IsAlreadySharedTo(int todoId, string username)
        {
            var foundToDo = _dbContext.SharedToDoes
                .Where(sharedToDo => (sharedToDo.ToDoId == todoId) && (sharedToDo.SharedTo == username))
                .ToList();
            
            return foundToDo.Count == 0 ? false : true;
        }

        public void RemoveFromShared(int todoId, string currentUserName)
        {
            var result = _dbContext.SharedToDoes
                .Where(sharedToDo => (sharedToDo.ToDoId == todoId) && (sharedToDo.SharedTo == currentUserName))
                .FirstOrDefault();

            _dbContext.SharedToDoes.Remove(result);
            _dbContext.SaveChanges();
        }
    }
}
