//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ToDoApp_Project.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ToDo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public int CreatorId { get; set; }
        public System.DateTime LastChanged { get; set; }
        public int LastChangedUserId { get; set; }
    }
}
