﻿namespace ToDoApp.Data
{
    public class ToDoItem
    {
        public string AsigneeId { get; set; } //UserId на зачисления потребител
        public virtual AppUser? Asignee { get; set; }
        public string Title { get; set; }
        public DateTime Deadline { get; set; }
        public string Description { get; set; }
        public int ToDoListId { get; set; }
        public virtual ToDoList? ToDoList { get; set; }
    }
}