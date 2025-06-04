namespace TodoList.Model
{
    public class TodoTask
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public string? Description { get; set; }
        public bool IsCompleted { get; set; }
        public bool? Reoccuring { get; set; }
        public DayOfWeek? DayOfWeek { get; set; }
    }
}
