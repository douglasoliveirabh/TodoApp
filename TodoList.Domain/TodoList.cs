using System;
using System.Collections.Generic;

namespace TodoList.Domain
{
    public class TodoList : DomainBase
    {

        public string Description { get; private set; }
        public ICollection<Todo> Todos { get; private set; }

        public TodoList(string description)
        {            
            Description = description;
            Todos = new List<Todo>();
        }
    }
}
