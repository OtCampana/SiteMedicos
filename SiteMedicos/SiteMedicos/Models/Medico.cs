using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SiteMedicos.Models
{
    public class Medico
    {
        public int MedicoId { get; set; }
        public string Nome { get; set; }
        public int EspecialidadeId { get; set; }
        [ForeignKey("EspecialidadeId")]
        public virtual Especialidade Especialidade { get; set; }
        public int CidadeId { get; set; }
        [ForeignKey("CidadeId")]
        public virtual Cidade Cidade { get; set; }
    

    }
}