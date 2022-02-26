using System;
using System.ComponentModel.DataAnnotations;

namespace RaellShoes.Models.Clientes
{
    public class Pais : EntidadeDominio
    {
        [Required(ErrorMessage = "{0} obrigatório")]
        [Display(Name = "País")]
        public String Descricao { get; set; }

        public Pais()
        {
            
        }
        public Pais(string descricao)
        {
            Descricao = descricao;
        }
    }
}
