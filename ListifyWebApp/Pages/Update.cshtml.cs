using ListifyWebApp.DataAccess;
using ListifyWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ListifyWebApp.Pages
{
    
    public class UpdateModel : PageModel
    {
        DatabaseContext db;

        [BindProperty]
        public Listify listify { get; set; }

        [BindProperty]
        public List<ItemTask> Tasks { get; set; } = new List<ItemTask>();


        public int ListifyId;

        public UpdateModel(DatabaseContext db)
        {
            this.db = db;
           
        }

        public void OnGet(int Id)
        {
            Console.WriteLine("This function is called!");
            ListifyId = Id;

            this.listify = db.Listify
                     .Include( l => l.tasks)
                     .SingleOrDefault(l => l.Id == Id);
           
            
            
        }
    }
}
