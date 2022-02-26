using System;
using System.ComponentModel.DataAnnotations;


namespace RaellShoes.Models.Clientes
{
    public class Estado : EntidadeDominio
    {
        [Required(ErrorMessage = "{0} obrigatório")]
        [Display(Name = "Estado")]
        public String Descricao { get; set; }

        public Pais Pais { get; set; }

        public Estado()
        {
        }

        public Estado(string descricao, Pais pais)
        {
            Descricao = descricao;
            Pais = pais;
        }
    }
}
