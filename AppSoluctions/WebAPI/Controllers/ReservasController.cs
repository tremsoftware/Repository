using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WEBAPI.Models;
using WEBAPI.Services;

namespace WebAPI.Controllers
{
    public class ReservasController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/Reservas
        public IQueryable<Reservas> GetReservas()
        {
            return db.Reservas;
        }

        // GET: api/Reservas/5
        [ResponseType(typeof(Reservas))]
        public IHttpActionResult GetReservas(int id)
        {
            Reservas reservas = db.Reservas.Find(id);
            if (reservas == null)
            {
                return NotFound();
            }

            return Ok(reservas);
        }

        // PUT: api/Reservas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutReservas(int id, Reservas reservas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != reservas.IdRes)
            {
                return BadRequest();
            }

            db.Entry(reservas).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReservasExists(id))
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

        // POST: api/Reservas
        [ResponseType(typeof(Reservas))]
        public IHttpActionResult PostReservas(Reservas reservas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Reservas.Add(reservas);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = reservas.IdRes }, reservas);
        }

        // DELETE: api/Reservas/5
        [ResponseType(typeof(Reservas))]
        public IHttpActionResult DeleteReservas(int id)
        {
            Reservas reservas = db.Reservas.Find(id);
            if (reservas == null)
            {
                return NotFound();
            }

            db.Reservas.Remove(reservas);
            db.SaveChanges();

            return Ok(reservas);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ReservasExists(int id)
        {
            return db.Reservas.Count(e => e.IdRes == id) > 0;
        }
    }
}