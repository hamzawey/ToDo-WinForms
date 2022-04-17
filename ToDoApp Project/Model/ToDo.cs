namespace ToDoApp_Project.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ToDo")]
    public partial class ToDo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(16)]
        public string Title { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        public DateTime DueDate { get; set; }
    }
}
