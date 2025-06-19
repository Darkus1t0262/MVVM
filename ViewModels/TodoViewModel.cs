public class TodoViewModel : INotifyPropertyChanged {
    public ObservableCollection<TodoItem> Items { get; set; } = new();
    public void AddTask(string task) => Items.Add(new TodoItem { Task = task, IsDone = false });
    public event PropertyChangedEventHandler PropertyChanged;
}
