using System;
using System.Collections.Generic;
using System.Linq;
using ToDoApp_Project.Model;

namespace ToDoApp_Project.Controller
{
    public class UserController
    {
        private readonly AppDbModelEntities _dbContext = new AppDbModelEntities();

        public List<User> GetAllUsers()
        {
            return _dbContext.Users.ToList();
        }

        public void RegisterUser(User userToRegister)
        {
            userToRegister.Id = _dbContext.Users.ToList().LastOrDefault().Id + 1;

            _dbContext.Users.Add(userToRegister);
            _dbContext.SaveChanges();
        }

        public void ManageMenuRegisterUser(User userToRegister)
        {
            _dbContext.Users.Add(userToRegister);
            _dbContext.SaveChanges();
        }

        public List<string> GetAllButNoCurrent(int currentUserId)
        {
            List<User> users = _dbContext.Users.Where(user => user.Id != currentUserId).ToList();
            List<string> usernames = new List<string>();
            foreach (var user in users)
            {
                usernames.Add(user.Username);
            }
            return usernames;
        }

        public bool TryToLogin(User loginUser)
        {
            foreach (var user in GetAllUsers())
            {
                if (user.Username == loginUser.Username)
                {
                    if (user.Password == loginUser.Password)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool DoesUsernameExist(string username)
        {
            foreach (var user in GetAllUsers())
            {
                if (user.Username == username)
                {
                    return true;
                }
            }

            return false;
        }

        public int FindUserId(User userToFindId)
        {
            foreach (var user in GetAllUsers())
            {
                if (user.Username == userToFindId.Username)
                {
                    if (user.Role == userToFindId.Role)
                    {
                        return user.Id;
                    }
                }
            }

            return 0;
        }

        public void DeleteUserById(int idToDelete)
        {
            var userToDelete = _dbContext.Users
                .Where(u => u.Id == idToDelete)
                .FirstOrDefault();

            if (userToDelete != null)
            {
                List<SharedToDo> sharedToDosToDelete = _dbContext.SharedToDoes
                    .Where(sharedToDo => sharedToDo.SharedTo == userToDelete.Username).ToList();

                if (sharedToDosToDelete.Count > 0)
                {
                    foreach (var sharedToDo in sharedToDosToDelete)
                    {
                        _dbContext.SharedToDoes.Remove(sharedToDo);
                    }
                }

                List<Task> userToDeleteTasks = _dbContext.Tasks
                    .Where(task => task.CreatorId == userToDelete.Id)
                    .ToList();

                if (userToDeleteTasks.Count > 0)
                {
                    foreach (var task in userToDeleteTasks)
                    {
                        _dbContext.Tasks.Remove(task);
                    }
                }

                List<ToDo> userToDeleteToDos = _dbContext.ToDoes
                    .Where(todo => todo.CreatorId == userToDelete.Id)
                    .ToList();

                if (userToDeleteToDos.Count > 0)
                {
                    foreach (var todo in userToDeleteToDos)
                    {
                        _dbContext.ToDoes.Remove(todo);
                    }
                }

                _dbContext.Users.Remove(userToDelete);
                _dbContext.SaveChanges();
            }
        }

        public string FindUserRole(User userToFindRole)
        {
            foreach (var user in GetAllUsers())
            {
                if (user.Username == userToFindRole.Username)
                {
                    return user.Role;
                }
            }

            return "";
        }

        public bool DoesUserIdExist(int idExists)
        {
            foreach (var user in GetAllUsers())
            {
                if (user.Id == idExists)
                {
                    return true;
                }
            }

            return false;
        }

        public void EditUser(int id, User userToEdit)
        {
            var userUpdated = _dbContext.Users.Where(u => u.Id == id).FirstOrDefault();

            if (userUpdated != null)
            {
                userUpdated.Id = id;
                userUpdated.Username = userToEdit.Username;
                userUpdated.Password = userToEdit.Password;
                userUpdated.Role = userToEdit.Role;
                _dbContext.SaveChanges();
            }
        }
    }
}
