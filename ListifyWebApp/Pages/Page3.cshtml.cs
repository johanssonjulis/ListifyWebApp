using ListifyWebApp.DataAccess;
using ListifyWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;



namespace ListifyWebApp.Pages
{
    
    public class Page3Model : PageModel
    {
        DatabaseContext db;

        public Page3Model(DatabaseContext db)
        {
            this.db = db;
        }
        [BindProperty]
        public Listify listify { get; set; }
        [BindProperty]
        public List<Listify> Listifies { get; set; }
       
        public void OnGet()
        {
            Listifies = db.Listify.ToList();
        }
        
    }
}

