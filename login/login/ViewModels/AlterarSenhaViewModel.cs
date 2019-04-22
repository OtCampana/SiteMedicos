using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace login.ViewModels
{
    public class AlterarSenhaViewModel
    {
        [Required(ErrorMessage ="Digite a senha")]
        [DataType(DataType.Password)]
        public String SenhaAtual { get; set; }

        [Required(ErrorMessage ="Senha nova não pode ser vazia")]
        [DataType(DataType.Password)]
        public String NovaSenha { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage ="Senha nao confirma")]
        [Compare(nameof(NovaSenha), ErrorMessage ="Nova senha nao pode ser igual")]
        public String ConfirmacaoSenha { get; set; }


    }
}