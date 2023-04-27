namespace ListifyWebApp.Models
{
    public class Listify
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Task> tasks { get; set; }

        public Listify(int id, string name)
        {
            Id = id;
            Name = name;
            tasks = new List<Task>();
        }
        public Listify() 
        { 
            tasks = new List<Task>();
        }
    }
}
