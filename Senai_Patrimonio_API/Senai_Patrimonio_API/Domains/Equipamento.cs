using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Senai_Patrimonio_API.Domains
{
    public partial class Equipamento
    {
        public int IdEquipamento { get; set; }
        public int? IdSala { get; set; }

        [Required(ErrorMessage = "Campo obrigatório !")]
        public string Marca { get; set; }
        [Required(ErrorMessage = "Campo obrigatório !")]
        public string Tipo { get; set; }
        [Required(ErrorMessage = "Campo obrigatório !")]
        public decimal Serie { get; set; }
        [Required(ErrorMessage = "Campo obrigatório !")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Campo obrigatório !")]
        public decimal Patrimonio { get; set; }
        [Required(ErrorMessage = "Campo obrigatório !")]
        public string Estado { get; set; }      

        public virtual Sala IdSalaNavigation { get; set; }
    }
}
