using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ListifyWebApp.Models
{
    [Table("Listify")]
    public class Listify
    {

        [Key] /*BLIR PRIMERYKEY*/
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
}
