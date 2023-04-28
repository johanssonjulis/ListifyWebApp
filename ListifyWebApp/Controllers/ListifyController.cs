using ListifyWebApp.Models;
using Microsoft.AspNetCore.Mvc;


namespace ListifyWebApp.Controllers
{
    [Route("api/Listify")]
    [ApiController] 
    public class ListifyController : ControllerBase
    {
        [HttpGet]
        public Listify GetListify()
        {
            Listify listify = new Listify(1, "Skolväska");
            listify.tasks.Add(new Models.Task(0, "Penna"));
            listify.tasks.Add(new Models.Task(1, "Bok")); 
            listify.tasks.Add(new Models.Task(2, "Äpple"));

            return listify;

        }
         


    }
}
