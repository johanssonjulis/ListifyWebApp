namespace ListifyWebApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public List<Listify> listifies { get; set; }


        public User(string name)
        {
            listifies = new List<Listify>();
        }

        
    }
}
