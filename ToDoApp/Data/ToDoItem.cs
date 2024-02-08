// ToDoItem.cs
using System;
using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Data
{
    public class ToDoItem
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Assignee")]
        public string AsigneeId { get; set; } //UserId на зачисления потребител
        public virtual AppUser? Asignee { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Deadline is required")]
        [DataType(DataType.DateTime)]
        public DateTime Deadline { get; set; }

        public string Description { get; set; }

        [Display(Name = "To-Do List")]
        public int ToDoListId { get; set; }
        public virtual ToDoList? ToDoList { get; set; }
    }
}
