using RaellShoes.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RaellShoes.Models.Administrador
{
    public class Fornecedor
    {
        [Required(ErrorMessage = "{0} obrigatório")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public Status Status { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public DateTime DataCadastro { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public String CNPJ { get; set; }

        public Fornecedor()
        {

        }

        public Fornecedor(string nome, Status status, DateTime dataCadastro, string cnpj)
        {
            Nome = nome;
            Status = status;
            DataCadastro = dataCadastro;
            CNPJ = cnpj;
        }
    }
}
