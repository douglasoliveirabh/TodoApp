using System.Collections.Generic;

namespace TodoList.Domain
{
    public class TodoList : DomainBase
    {

        public string Description { get; set; }
        public IEnumerable<Todo> Todos { get; set; }

    }
}
