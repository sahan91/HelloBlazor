using System.Collections.Generic;
using HelloBlazor.Shared;

namespace HelloBlazor.App.Pages.Todo
{
    public partial class Todo
    {
        private IList<TodoItem> todos = new List<TodoItem>();
        private string newTodo;

        private void AddTodo()
        {
            if (!string.IsNullOrWhiteSpace(newTodo))
            {
                todos.Add(new TodoItem { Title = newTodo });
                newTodo = string.Empty;
            }
        }
    }
}
