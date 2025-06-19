using System.Collections.Generic;

namespace BlazorMVVMApp.Data
{
    public class TodoService
    {
        public List<TodoItem> Items { get; set; } = new();

        public void AddItem(string title) => Items.Add(new TodoItem { Title = title, IsDone = false });

        public void ToggleDone(TodoItem item) => item.IsDone = !item.IsDone;
    }
}