﻿using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace ToDoApp.Data
{
    public class ToDoList 
    {


        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public virtual AppUser? User { get; set; }

        public string Title { get; set; }
        public virtual List<ToDoItem> Items { get; set; }

        public ToDoList()
        {
            Items = new List<ToDoItem>();
        }
    }
}