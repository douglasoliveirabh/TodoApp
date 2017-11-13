using Microsoft.EntityFrameworkCore;
using TodoList.Persistence.Configuration;

namespace TodoList.Persistence.Context
{
    public class TodoListContext : DbContext
    {
        public TodoListContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Domain.TodoList>(new TodoListConfiguration());
            modelBuilder.ApplyConfiguration<Domain.Todo>(new TodoConfiguration());
        }
    }
}
