using ListifyWebApp.DataAccess;
using ListifyWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ListifyWebApp.Pages
{
    
    public class UpdateModel : PageModel
    {
        DatabaseContext db;
        [BindProperty]
        public Listify listify { get; set; }
        [BindProperty]
        public ItemTask task { get; set; }

        public UpdateModel(DatabaseContext db)
        {
            this.db = db;
        }

        public void OnGet(int id)
        {
            db.Listify.FirstOrDefault<Listify>(listify => listify.Id == id);

        }
    }
}
