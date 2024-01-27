using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ToDoApp.Data;

namespace ToDoApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ToDoList>()
            .HasMany(tdl => tdl.Items)
            .WithOne(tdi => tdi.ToDoList)
            .OnDelete(DeleteBehavior.NoAction);

            base.OnModelCreating(builder);
        }

        public DbSet<ToDoApp.Data.ToDoList> ToDoList { get; set; } = default!;
        public DbSet<ToDoApp.Data.ToDoItem> ToDoItem { get; set; } = default!;
    }
}
