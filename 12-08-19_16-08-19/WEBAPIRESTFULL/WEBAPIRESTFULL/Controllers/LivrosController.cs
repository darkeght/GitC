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
    public class LivrosController : ApiController
    {
        private BibliotecaContextDB db = new BibliotecaContextDB();

        // GET: api/Livros
        public IQueryable<Livros> GetLivros()
        {
            return db.Livros.Where(x => x.Ativo == true);
        }

        // GET: api/Livros/5
        [ResponseType(typeof(Livros))]
        public IHttpActionResult GetLivros(int id)
        {
            Livros livros = db.Livros.Find(id);
            if (livros == null)
            {
                return NotFound();
            }

            return Ok(livros);
        }

        // PUT: api/Livros/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLivros(int id, Livros livros)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != livros.Id)
            {
                return BadRequest();
            }

            db.Entry(livros).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LivrosExists(id))
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

        // POST: api/Livros
        [ResponseType(typeof(Livros))]
        public IHttpActionResult PostLivros(Livros livros)
        {
            if (!ModelState.IsValid)
            {
                if (ModelState.Keys.First().ToString() != "livros.Id")
                    return BadRequest(ModelState);
            }

            db.Livros.Add(livros);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = livros.Id }, livros);
        }

        // DELETE: api/Livros/5
        [ResponseType(typeof(Livros))]
        public IHttpActionResult DeleteLivros(int id)
        {
            Livros livros = db.Livros.Find(id);

            if (livros == null)
            {
                return NotFound();
            }

            db.Livros.Find(id).Ativo = false;

            db.SaveChanges();

            return Ok(livros);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LivrosExists(int id)
        {
            return db.Livros.Count(e => e.Id == id) > 0;
        }
    }
}