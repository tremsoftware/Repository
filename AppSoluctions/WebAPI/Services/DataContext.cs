using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WEBAPI.Models;

namespace WEBAPI.Services
{
    public class DataContext : DbContext
    {
        public DataContext() : base(nameOrConnectionString: "DataContext") { }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Funcionarios> Funcionarios { get; set; }
        public DbSet<Salas> Salas { get; set; }
        public DbSet<Reservas> Reservas { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Empresas> Empresas { get; set; }
    }
}