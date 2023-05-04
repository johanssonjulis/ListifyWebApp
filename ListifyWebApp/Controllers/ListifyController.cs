using ListifyWebApp.DataAccess;
using ListifyWebApp.Models;
using Microsoft.AspNetCore.Mvc;


namespace ListifyWebApp.Controllers
{
    [Route("api/Listify")]
    [ApiController] 
    public class ListifyController : ControllerBase
    {
        DatabaseContext db;

        public ListifyController(DatabaseContext databaseContext)
        { 
            db = databaseContext;
        }
        [HttpGet]
        public List<Listify> GetListify()
        {
            return db.Listify.ToList();
        }
         


    }
}
