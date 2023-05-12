using ListifyWebApp.DataAccess;
using ListifyWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

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

        [Route("PostList")]
        [HttpPost]
        public void PostListify([FromBody] Listify listify)
        {
            db.Listify.Add(listify);

            for (int i = 0; i < listify.tasks.Count; i++)
            {
                db.Task.Add(listify.tasks[i]);
            }

            db.SaveChanges();
        }

        [Route("GetListifyById")]
        [HttpGet]
        public ActionResult<Listify> GetListifyById(int id)
        {

            Listify listify = db.Listify.Include(l => l.tasks).SingleOrDefault(l => l.Id == id);
            return listify;

            /*Listify listify = db.Listify.Find(id);
            if (listify != null)
            {
                return Ok(listify);
            }
            return BadRequest();*/
        }

        [Route("Delete")]
        [HttpDelete]
        public ActionResult DeleteListifyById(int id)
        {
            Listify listify = db.Listify.SingleOrDefault(l => l.Id == id);
            if(listify != null)
            {
                db.Listify.Remove(listify); 
                db.SaveChanges();
            }
            return BadRequest();
        }

        [Route("Edit")]
        [HttpPut]
        public ActionResult EditListify([FromBody] Listify listify)
        {
            if (listify != null)
            {
                db.Listify.Update(listify); 
                db.SaveChanges();
            }
            return Ok();
        }

    }
}
