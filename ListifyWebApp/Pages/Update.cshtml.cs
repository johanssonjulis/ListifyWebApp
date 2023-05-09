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
        public List<ItemTask> tasks { get; set; }

        public UpdateModel(DatabaseContext db)
        {
            this.db = db;
        }

        public void OnGet(int listifyId)
        {
            listify = db.Listify
                .Include( l => l.tasks)
                .SingleOrDefault(l => l.Id == listifyId);
            
        }
    }
}
