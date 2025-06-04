using TodoList.Data;

namespace TodoList.ViewModel
{
    public class DailyTasksViewModel : TasksViewModel
    {
        public DailyTasksViewModel(ITaskDataProvider taskDataProvider) : base(taskDataProvider)
        {
        }
    }
}
