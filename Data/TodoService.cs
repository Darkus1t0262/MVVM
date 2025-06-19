using System;
using System.Collections.Generic;

namespace BlazorMVVMApp.Data
{
    public class TodoService
    {
        public List<TodoItem> Items { get; set; } = new();

        public void AddItem(string title)
        {
            var item = new TodoItem { Title = title, IsDone = false };
            Items.Add(item);
            Console.WriteLine($"[TodoService] Added: {item.Title}");
        }

        public void ToggleDone(TodoItem item)
        {
            item.IsDone = !item.IsDone;
            Console.WriteLine($"[TodoService] Toggled: {item.Title} = {item.IsDone}");
        }
    }
}