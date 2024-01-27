using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;

namespace ToDoApp.Data
{
    public class AppUser : IdentityUser
    {
        public AppUser()
        {
            Lists = new List<ToDoList>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public virtual List<ToDoList> Lists { get; set; }

    }
}
