using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
	

	

namespace login.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(30)]
        public String Nome { get; set; }
        [Required]
        [MaxLength(30)]
        public String Login { get; set; }
        [Required]
        [MaxLength(150)]
        public String Senha { get; set; }

    }
}