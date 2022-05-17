using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoApp_Project.Model;

namespace ToDoApp_Project.Controller
{
    public class UserController
    {
        // USER CONTROLLER
        public void RegisterUser(User user)
        {
            using (ToDoDbEntities userEntities = new ToDoDbEntities())
            {
                user.Id = userEntities.Users.ToList().LastOrDefault().Id + 1;
                userEntities.Users.Add(user);
                userEntities.SaveChanges();
            }
        }

        public bool tryToLogin(User user)
        {
            using (ToDoDbEntities userEntities = new ToDoDbEntities())
            {
                List<User> users = userEntities.Users.ToList();
                foreach (var userExist in users)
                {
                    if (userExist.Username == user.Username)
                    {
                        if (userExist.Password == user.Password)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
        }

        public bool doesUsernameExist(User user)
        {
            using (ToDoDbEntities userEntities = new ToDoDbEntities())
            {
                List<User> users = userEntities.Users.ToList();
                foreach (var userExist in users)
                {
                    if (userExist.Username == user.Username)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public void DeleteUser(int id)
        {
            using (ToDoDbEntities userEntities = new ToDoDbEntities())
            {
                var userDel = userEntities.Users.Where(u => u.Id == id).FirstOrDefault();
                if (userDel.Id == id)
                {
                    userEntities.Users.Remove(userDel);
                    userEntities.SaveChanges();
                }
            }
        }

        public string findRole(User user)
        {
            string foundRole = "";
            using (ToDoDbEntities userEntities = new ToDoDbEntities())
            {
                var users = userEntities.Users.ToList();
                foreach (var userExist in users)
                {
                    if (userExist.Username == user.Username)
                    {
                        foundRole = userExist.Role;
                        break;
                    }
                }
                return foundRole;
            }
        }

        public bool doesIdExist(User user)
        {
            using (ToDoDbEntities userEntities = new ToDoDbEntities())
            {
                List<User> users = userEntities.Users.ToList();
                foreach (var userExist in users)
                {
                    if (userExist.Id == user.Id)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public void EditUser(int id, User user)
        {
            using (ToDoDbEntities userEntities = new ToDoDbEntities())
            {
                var userUpdate = userEntities.Users.Where(u => u.Id == id).FirstOrDefault();
                if (userUpdate != null)
                {
                    userUpdate.Id = id;
                    userUpdate.Username = user.Username;
                    userUpdate.Password = user.Password;
                    userUpdate.Role = user.Role;
                    userEntities.SaveChanges();
                }
            }
        }
    }
}
