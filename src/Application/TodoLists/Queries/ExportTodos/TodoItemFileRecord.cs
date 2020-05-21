using ValhallaTemplate.Application.Common.Mappings;
using ValhallaTemplate.Domain.Entities;

namespace ValhallaTemplate.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
