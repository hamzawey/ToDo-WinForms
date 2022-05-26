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

        public bool doesIdExist(int checkId)
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

        public bool doesTitleExist(string checkTitle)
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

        public void CreateToDo(ToDo newToDo)
        {
            using (AppDbModelEntities todoEntities = new AppDbModelEntities())
            {
                todoEntities.ToDoes.Add(newToDo);
                todoEntities.SaveChanges();
            }
        }

        public void deleteById(int idToDelete)
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
    }
}
