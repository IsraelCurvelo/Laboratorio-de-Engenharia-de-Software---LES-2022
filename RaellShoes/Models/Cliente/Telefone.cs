using RaellShoes.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace RaellShoes.Models.Clientes
{
    public class Telefone : EntidadeDominio
    {
        [Required(ErrorMessage = "{0} obrigatório")]        
        public String DDD { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [Display(Name = "Número")]
        [StringLength(10, MinimumLength = 8, ErrorMessage = "O Número deve conter entre 8 e 9 caracteres")]
        public String Numero { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public TipoTelefone TipoTelefone { get; set; }

        public Telefone()
        {
        }

        public Telefone(string ddd, string numero, TipoTelefone tipoTelefone)
        {
            DDD = ddd;
            Numero = numero;
            TipoTelefone = tipoTelefone;
        }
    }
}
