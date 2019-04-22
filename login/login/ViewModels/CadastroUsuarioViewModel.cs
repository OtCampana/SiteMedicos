using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace login.ViewModels
{
    public class CadastroUsuarioViewModel
    {
        [Required(ErrorMessage = "Nome Necessário")]
        public String Nome { get; set; }
        [MaxLength(30)]
        [Required(ErrorMessage = "Informe o Login")]
        public String Login { get; set; }

        [Required(ErrorMessage = "Informe a Senha")]
        [MinLength(6, ErrorMessage ="Minimo de 6 caracteres na senha")]
        [MaxLength(150)]
        [DataType(DataType.Password)]
        public String Senha { get; set; }


        [Required(ErrorMessage = "Confirme a Senha")]
        [MinLength(6, ErrorMessage = "Minimo de 6 caracteres na confirmação da senha")]
        [MaxLength(150)]
        [DataType(DataType.Password)]
        [Compare(nameof(Senha), ErrorMessage = "Senha não confere")]
        [Display(Name = "Confirme sua senha")]
        public String ConfirmacaoSenha { get; set; }
    }
}