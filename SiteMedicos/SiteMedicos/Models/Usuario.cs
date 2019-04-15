using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SiteMedicos.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string password { get; set; }

    }
}