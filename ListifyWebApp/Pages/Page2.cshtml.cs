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
        public string listname { get; set; }

        [BindProperty]
        public string taskDescription { get; set; }
        public static List<ItemTask> items = new List<ItemTask>();

        public void OnGet()
        {
        
        }
        public IActionResult OnPostAddTaskToList() 
        {
            ItemTask itemTask = new ItemTask()
            {
                TaskDescription = taskDescription
            };
            items.Add(itemTask);
            db.Task.Add(itemTask);
            db.SaveChanges();
            return RedirectToPage("Page2");
            

        }
        public IActionResult OnPost()
        {
            Listify listify = new Listify() {
                Name = listname,
                tasks = items
        };
             
            
            db.Listify.Add(listify);
            db.SaveChanges();
            return RedirectToPage("Page3");
        }
    }
}
