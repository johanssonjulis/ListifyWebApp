namespace ListifyWebApp.Models
{
    public class PretendDatabase
    {
        static List<Listify> ListTable = new List<Listify>();

        public List<Listify> GetListifies()
        {
            ListTable.Add(new Listify(0, "Att göra lista"));
            ListTable.Add(new Listify(1, "Veckodagar"));
            ListTable.Add(new Listify(2, "Skoldagar"));

            return ListTable;
        }
        public void AddList(Listify listify)
        {
            ListTable.Add(listify);
        }
        
        public void AddTasks()
        {
            Task task = new Task();

        }



    }
}
