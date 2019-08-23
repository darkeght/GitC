using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using WEBAPIRESTFULL.Models;

namespace WEBAPIRESTFULL.Controllers
{
    [EnableCors(origins:"*",headers:"*",methods:"*")]
    public class AutoresController : ApiController
    {
        private BibliotecaContextDB db = new BibliotecaContextDB();

        // GET: api/Autores
        public IQueryable<Autores> GetAutores()
        {
            return db.Autores.Where(x => x.Ativo == true);
        }

        // GET: api/Autores/5
        [ResponseType(typeof(Autores))]
        public IHttpActionResult GetAutores(int id)
        {
            Autores autores = db.Autores.Find(id);
            if (autores == null)
            {
                return NotFound();
            }

            return Ok(autores);
        }

        // PUT: api/Autores/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAutores(int id, Autores autores)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != autores.Id)
            {
                return BadRequest();
            }

            db.Entry(autores).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AutoresExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Autores
        [ResponseType(typeof(Autores))]
        public IHttpActionResult PostAutores(Autores autores)
        {
            if (!ModelState.IsValid)
            {
                if(ModelState.Keys.First().ToString() != "autores.Id")
                return BadRequest(ModelState);
            }

            db.Autores.Add(autores);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = autores.Id }, autores);
        }

        // DELETE: api/Autores/5
        [ResponseType(typeof(Autores))]
        public IHttpActionResult DeleteAutores(int id)
        {
            Autores autores = db.Autores.Find(id);

            if (autores == null)
            {
                return NotFound();
            }

            db.Autores.Find(id).Ativo = false;

            db.SaveChanges();

            return Ok(autores);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AutoresExists(int id)
        {
            return db.Autores.Count(e => e.Id == id) > 0;
        }
    }
}