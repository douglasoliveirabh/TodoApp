using Microsoft.EntityFrameworkCore;
using TodoList.Persistence.Configuration;
using Domain = TodoList.Domain;

namespace TodoList.Persistence.Context
{
    public class TodoListContext : DbContext
    {

        public DbSet<Domain.TodoList> TodoLists { get; set; }
        public DbSet<Domain.Todo> Todos { get; set; }

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
