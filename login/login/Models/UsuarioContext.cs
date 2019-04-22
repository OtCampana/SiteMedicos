using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace login.Models
{
    public class UsuarioContext : DbContext
    {
        public  UsuarioContext() : base("Usuario")
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Especialidade> Especialidades { get; set; }
       
    }
}