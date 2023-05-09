﻿using ListifyWebApp.DataAccess;
using ListifyWebApp.Models;
using Microsoft.AspNetCore.Mvc;
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

        [HttpPost]
        public void PostListify([FromBody] Listify listify)
        {

            db.Listify.Add(listify);
            db.SaveChanges();
        }

        [HttpPut]
        public Listify PutListify([FromBody] Listify listify)
        {
            if (listify.Id <= 0)
            {
                //return BadRequest("");
            }
            return listify;

        }

        [HttpGet]
        public ActionResult<Listify> GetListifyById(int id)
        {
            Listify listify = db.Listify.Find(id);
            if (listify != null)
            {
                return Ok(listify);
            }
            return BadRequest();
        }

        [HttpDelete]
        public ActionResult DeleteListifyById(int id)
        {
            Listify listify = db.Listify.Find(id);
            if(listify != null)
            {
                db.Listify.Remove(listify); 
                db.SaveChanges();
            }
            return BadRequest();
        }

    }
}
