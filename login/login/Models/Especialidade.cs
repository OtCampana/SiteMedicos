using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
	

	

namespace login.Models
{
    [Table("Especialidade")]
    public class Especialidade
    {
        public int ID { get; set; }
        [Required]
        public string EspecialidadeNome { get; set; }
   

    }
}