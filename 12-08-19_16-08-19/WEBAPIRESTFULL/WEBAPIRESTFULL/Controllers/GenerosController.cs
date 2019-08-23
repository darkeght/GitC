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
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class GenerosController : ApiController
    {
        private BibliotecaContextDB db = new BibliotecaContextDB();

        // GET: api/Generos
        public IQueryable<Generos> GetGeneros()
        {
            return db.Generos.Where(x => x.Ativo == true);
        }

        // GET: api/Generos/5
        [ResponseType(typeof(Generos))]
        public IHttpActionResult GetGeneros(int id)
        {
            Generos generos = db.Generos.Find(id);
            if (generos == null)
            {
                return NotFound();
            }

            return Ok(generos);
        }

        // PUT: api/Generos/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutGeneros(int id, Generos generos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != generos.Id)
            {
                return BadRequest();
            }

            db.Entry(generos).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GenerosExists(id))
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

        // POST: api/Generos
        [ResponseType(typeof(Generos))]
        public IHttpActionResult PostGeneros(Generos generos)
        {
            if (!ModelState.IsValid)
            {
                if (ModelState.Keys.First().ToString() != "generos.Id")
                    return BadRequest(ModelState);
            }

            db.Generos.Add(generos);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = generos.Id }, generos);
        }

        // DELETE: api/Generos/5
        [ResponseType(typeof(Generos))]
        public IHttpActionResult DeleteGeneros(int id)
        {
            Generos generos = db.Generos.Find(id);

            if (generos == null)
            {
                return NotFound();
            }

            db.Generos.Find(id).Ativo = false;

            db.SaveChanges();

            return Ok(generos);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GenerosExists(int id)
        {
            return db.Generos.Count(e => e.Id == id) > 0;
        }
    }
}