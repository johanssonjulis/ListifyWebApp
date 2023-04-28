using ListifyWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;



namespace ListifyWebApp.Pages
{
    
    public class Page3Model : PageModel
    {
        PretendDatabase pretendDatabase;

        public Page3Model(PretendDatabase db)
        {
            this.pretendDatabase = db;
        }

       
        public void OnGet()
        {
           
        }
    }
}
