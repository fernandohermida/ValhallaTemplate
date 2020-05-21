using System.Collections.Generic;

namespace ValhallaTemplate.Application.TodoLists.Queries.GetTodos
{
    public class TodosVm
    {
        public IList<PriorityLevelDto> PriorityLevels { get; set; }

        public IList<TodoListDto> Lists { get; set; }
    }
}
