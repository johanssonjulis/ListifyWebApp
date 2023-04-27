namespace ListifyWebApp.Models
{
    public class PretendDatabase
    {
        static List<Listify> ListTable = new List<Listify>();

        public List<Listify> GetList()
        {
            return ListTable;
        }
        public void AddList(Listify listify)
        {
            ListTable.Add(listify);
        }



    }
}
