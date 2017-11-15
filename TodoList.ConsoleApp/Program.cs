using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TodoList.Persistence.Context;
using System.Linq;

namespace TodoList.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            var builder = new DbContextOptionsBuilder();
            builder.UseSqlite("Data Source=./Data/TodoListDatabase.db");

            using (var context = new TodoListContext(builder.Options)) {
               
                var todolist = new Domain.TodoList("minha lista exemplo");
                todolist.Todos.Add(new Domain.Todo("Todo 1", true));
                todolist.Todos.Add(new Domain.Todo("Todo 2", true));
                todolist.Todos.Add(new Domain.Todo("Todo 3", true));
                todolist.Todos.Add(new Domain.Todo("Todo 4", true));
                todolist.Todos.Add(new Domain.Todo("Todo 5", true));
                todolist.Todos.Add(new Domain.Todo("Todo 6", true));
                todolist.Todos.Add(new Domain.Todo("Todo 7", true));

                context.TodoLists.Add(todolist);                
                context.SaveChanges();
                
            }
            
        }       
    }
}
