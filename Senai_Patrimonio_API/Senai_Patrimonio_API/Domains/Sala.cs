using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Senai_Patrimonio_API.Domains
{
    public partial class Sala
    {
        public Sala()
        {
            Equipamentos = new HashSet<Equipamento>();
        }

        public int IdSala { get; set; }
        [Required(ErrorMessage = "Campo obrigatório !")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo obrigatório !")]
        public int Andar { get; set; }
        [Required(ErrorMessage = "Campo obrigatório !")]
        public decimal Metragem { get; set; }

        public virtual ICollection<Equipamento> Equipamentos { get; set; }
    }
}
