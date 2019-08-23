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
    public class EditorasController : ApiController
    {
        private BibliotecaContextDB db = new BibliotecaContextDB();

        // GET: api/Editoras
        public IQueryable<Editoras> GetEditoras()
        {
            return db.Editoras.Where(x => x.Ativo == true);
        }

        // GET: api/Editoras/5
        [ResponseType(typeof(Editoras))]
        public IHttpActionResult GetEditoras(int id)
        {
            Editoras editoras = db.Editoras.Find(id);
            if (editoras == null)
            {
                return NotFound();
            }

            return Ok(editoras);
        }

        // PUT: api/Editoras/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEditoras(int id, Editoras editoras)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != editoras.Id)
            {
                return BadRequest();
            }

            db.Entry(editoras).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EditorasExists(id))
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

        // POST: api/Editoras
        [ResponseType(typeof(Editoras))]
        public IHttpActionResult PostEditoras(Editoras editoras)
        {
            if (!ModelState.IsValid)
            {
                if (ModelState.Keys.First().ToString() != "editoras.Id")
                    return BadRequest(ModelState);
            }

            db.Editoras.Add(editoras);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = editoras.Id }, editoras);
        }

        // DELETE: api/Editoras/5
        [ResponseType(typeof(Editoras))]
        public IHttpActionResult DeleteEditoras(int id)
        {
            Editoras autores = db.Editoras.Find(id);

            if (autores == null)
            {
                return NotFound();
            }

            db.Editoras.Find(id).Ativo = false;

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

        private bool EditorasExists(int id)
        {
            return db.Editoras.Count(e => e.Id == id) > 0;
        }
    }
}