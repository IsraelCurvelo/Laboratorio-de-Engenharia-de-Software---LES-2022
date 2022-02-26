using System;
using System.ComponentModel.DataAnnotations;

namespace RaellShoes.Models.Clientes
{
    public class Cidade : EntidadeDominio
    {
        [Required(ErrorMessage = "{0} obrigatório")]
        [Display(Name = "Cidade")]
        public String Descricao { get; set; }

        public Estado Estado { get; set; }

        public Cidade()
        {

        }
        
        public Cidade(String descricao, Estado estado)
        {
            Descricao = descricao;
            Estado = estado;
        }
    }
}
