using ListifyWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ListifyWebApp.Pages
{

    
    public class Page2Model : PageModel
    {
        PretendDatabase db;

        public Page2Model(PretendDatabase db)
        {
            this.db = db;
        }

        [BindProperty]
        public Listify listify { get; set; }

        public void OnGet()
        {
            List<Listify> listifytable = db.GetListifies();
        }

        public IActionResult OnPost()
        {
            db.AddList(listify);
            return RedirectToPage("Page3");
        }
    }
}
