using TodoList.Model;

namespace TodoList.Data
{
    public interface ITaskDataProvider
    {
        Task<IEnumerable<TodoTask>?> GetAllAsync();
    }
    public class TaskDataProvider : ITaskDataProvider
    {
        public async Task<IEnumerable<TodoTask>?> GetAllAsync()
        {
            await Task.Delay(100);

            return new List<TodoTask>
            {
                new TodoTask{Id=1,Title="Enter Time",IsCompleted=false},
                new TodoTask{Id=2,Title="Email Tyler",IsCompleted=false},
                new TodoTask{Id=4,Title="Watch Training Video",IsCompleted=true},
                new TodoTask{Id=5,Title="Fix Excel Formatting",IsCompleted=false}
            };
        }
    }
}
