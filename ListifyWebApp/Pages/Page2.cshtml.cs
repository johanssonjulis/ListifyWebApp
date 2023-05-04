using ListifyWebApp.DataAccess;
using ListifyWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ListifyWebApp.Pages
{

    
    public class Page2Model : PageModel
    {
        DatabaseContext db;

        public Page2Model(DatabaseContext db)
        {
            this.db = db;
        }

        [BindProperty]
        public Listify listify { get; set; }

        public void OnGet()
        {
        
        }

        public IActionResult OnPost()
        {
           
            db.Listify.Add(listify);
            db.SaveChanges();
            return RedirectToPage("Page3");
        }
    }
}
