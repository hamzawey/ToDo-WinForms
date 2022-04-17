using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ToDoApp_Project.Model
{
    public partial class ToDosDbEntities : DbContext
    {
        public ToDosDbEntities()
            : base("name=ToDosDbEntities")
        {
        }

        public virtual DbSet<ToDo> ToDoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDo>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<ToDo>()
                .Property(e => e.Description)
                .IsUnicode(false);
        }
    }
}
