using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Geolocalizador.Models
{
    public class Login
    {
        [Required]
        [Display(Name="Usuário")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name="Senha")]
        public string Password { get; set; }
        [Display(Name= "Lembrar do usuário?")]
        public bool Rememberme { get; set; } 
    }
}