using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using TodoList.Data;
using TodoList.Model;

namespace TodoList.ViewModel
{
    public class TasksViewModel : INotifyPropertyChanged
    {
        private readonly ITaskDataProvider _taskDataProvider;


        public TasksViewModel(ITaskDataProvider taskDataProvider)
        {
            _taskDataProvider = taskDataProvider;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public ObservableCollection<TodoTask> Tasks { get; private set; } = new();

        protected virtual void RaisePropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public virtual async Task LoadAsync()
        {
            if (Tasks.Any()) return;

            var tasks = await _taskDataProvider.GetAllAsync();
            if (tasks is not null)
            {
                foreach (var task in tasks)
                {
                    Tasks.Add(task);
                }
            }
        }
    }
}
