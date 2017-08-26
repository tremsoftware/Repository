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
    public class FuncionariosController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/Funcionarios
        public IQueryable<Funcionarios> GetFuncionarios()
        {
            return db.Funcionarios;
        }

        // GET: api/Funcionarios/5
        [ResponseType(typeof(Funcionarios))]
        public IHttpActionResult GetFuncionarios(int id)
        {
            Funcionarios funcionarios = db.Funcionarios.Find(id);
            if (funcionarios == null)
            {
                return NotFound();
            }

            return Ok(funcionarios);
        }

        // PUT: api/Funcionarios/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutFuncionarios(int id, Funcionarios funcionarios)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != funcionarios.IdFun)
            {
                return BadRequest();
            }

            db.Entry(funcionarios).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FuncionariosExists(id))
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

        // POST: api/Funcionarios
        [ResponseType(typeof(Funcionarios))]
        public IHttpActionResult PostFuncionarios(Funcionarios funcionarios)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Funcionarios.Add(funcionarios);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = funcionarios.IdFun }, funcionarios);
        }

        // DELETE: api/Funcionarios/5
        [ResponseType(typeof(Funcionarios))]
        public IHttpActionResult DeleteFuncionarios(int id)
        {
            Funcionarios funcionarios = db.Funcionarios.Find(id);
            if (funcionarios == null)
            {
                return NotFound();
            }

            db.Funcionarios.Remove(funcionarios);
            db.SaveChanges();

            return Ok(funcionarios);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FuncionariosExists(int id)
        {
            return db.Funcionarios.Count(e => e.IdFun == id) > 0;
        }
    }
}