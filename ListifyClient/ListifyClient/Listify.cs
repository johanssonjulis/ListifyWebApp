using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListifyClient
{
    public class Listify
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ItemTask> tasks { get; set; }

        public Listify(int id, string name)
        {
            Id = id;
            Name = name;
            tasks = new List<ItemTask>();
        }
        public Listify()
        {
            tasks = new List<ItemTask>();
        }
    }

    public class ItemTask
    {
        [Key]
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
