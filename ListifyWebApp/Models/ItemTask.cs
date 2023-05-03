namespace ListifyWebApp.Models
{
    public class ItemTask
    {
        public int Id { get; set; }
        public string TaskDescription { get; set; }

        public ItemTask()
        {

        }
        public ItemTask(int id, string taskDescription)
        {
            Id = id;
            TaskDescription = taskDescription;

        }
    }
}
