using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Senai_Patrimonio_API.Domains
{
    public partial class Usuario
    {
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "Campo obrigatório !")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Campo obrigatório !")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "A senha deve conter no mínimo 4 caracteres")]
        public string Senha { get; set; }
    }
}
