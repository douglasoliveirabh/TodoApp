using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace TodoList.Persistence.Context
{
    public class TodoListContextFactory : IDesignTimeDbContextFactory<TodoListContext>
    {
        public TodoListContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder();
            builder.UseSqlite("Data Source=./Data/TodoListDatabase.db");
            return new TodoListContext(builder.Options);
        }
    }
}
