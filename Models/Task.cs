namespace TaskFlow.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; } // Low, Medium, High
        public string Status { get; set; } // To Do, In Progress, Completed
        public DateTime DueDate { get; set; }
        public int UserId { get; set; } // The user assigned to this task
        public User AssignedUser { get; set; }
    }
}
