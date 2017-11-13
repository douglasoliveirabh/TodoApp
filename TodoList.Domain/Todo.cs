using System;

namespace TodoList.Domain
{
    public class Todo : DomainBase
    {
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public Guid TodoListId { get; set; }
        public TodoList TodoList { get; set; }
    }
}
