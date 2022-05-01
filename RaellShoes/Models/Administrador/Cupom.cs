using RaellShoes.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RaellShoes.Models.Administrador
{
    public class Cupom : EntidadeDominio
    {
        [Required(ErrorMessage = "{0} obrigatório")]
        public String Descricao { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public Status Status { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public DateTime DataCadastro { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public String Codigo { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public Double Desconto { get; set; }

       
        public bool Promocional { get; set; }

        public int ClienteId { get; set; }


        public Cupom()
        {

        }

        public Cupom(string nome, Status status, DateTime dataCadastro, string codigo, double desconto, bool promocional, int clienteId)
        {
            Descricao = nome;
            Status = status;
            DataCadastro = dataCadastro;
            Codigo = codigo;
            Desconto = desconto;
            Promocional = promocional;
            ClienteId = clienteId;
        }
    }
}
