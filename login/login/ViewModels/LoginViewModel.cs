using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace login.ViewModels
{
    public class LoginViewModel
    {
        [HiddenInput]
        public string UrlReturn { get; set; }

        [Required(ErrorMessage = "Informe o Login")]
        public String Login { get; set; }

        [Required(ErrorMessage =("Informe a Senha"))]
        [DataType(DataType.Password)]   
        [MinLength(6,ErrorMessage =("A senha deve conter pelo menos 6 caracteres"))]
        public string Senha { get; set; }
    }
}