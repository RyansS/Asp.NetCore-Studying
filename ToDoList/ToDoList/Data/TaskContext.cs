using Microsoft.EntityFrameworkCore;
using ToDoList.Models;

namespace ToDoList.Data
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base (options)
        {

        }

        public DbSet<ToDoListModel> Tasks { get; set; }
    }
}
