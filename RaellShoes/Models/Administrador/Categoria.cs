using RaellShoes.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RaellShoes.Models.Administrador
{
    public class Categoria
    {
        [Required(ErrorMessage = "{0} obrigatório")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public Status Status { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public DateTime DataCadastro { get; set; }

        public Categoria()
        {

        }

        public Categoria(string nome, Status status, DateTime dataCadastro)
        {
            Nome = nome;
            Status = status;
            DataCadastro = dataCadastro;
        }
    }
}
