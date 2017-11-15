using System;

namespace TodoList.Domain
{
    public class Todo : DomainBase
    {
        public string Description { get; private set; }
        public bool IsActive { get; private set; }
        public int TodoListId { get; private set; }
        public TodoList TodoList { get; private set; }

        public Todo(string description, bool isActive)
        {
            Description = description;
            IsActive = IsActive;            
        }

        public Todo(string description, bool isActive, int todoListId)
        {           
            Description = description;
            IsActive = IsActive;
            TodoListId = todoListId;
        }
    }
}
