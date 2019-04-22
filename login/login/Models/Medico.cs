using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
	

	

namespace login.Models
{
    [Table("Medico")]
    public class Medico
    {

        public int ID { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]  
        public string CRM { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        
        public String Nome { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        [MaxLength(150)]
        public String Endereco { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public String Bairro { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public String Cidade { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public String Estado { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public String Pais { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public String Email { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public bool AtendePorConvenio { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public bool TemClinica { get; set; }
  
        public String WebsiteBlog { get; set; }



        public int EspecialidadeID { get; set; }
        [ForeignKey("EspecialidadeID")]
        public virtual Especialidade Especialidade { get; set; }

    }
}