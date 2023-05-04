namespace ListifyWebApp.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string TaskDescription { get; set; }

        public Task()
        {

        }
        public Task(int id, string taskDescription)
        {
            Id = id;
            TaskDescription = taskDescription;

        }
    }
}
