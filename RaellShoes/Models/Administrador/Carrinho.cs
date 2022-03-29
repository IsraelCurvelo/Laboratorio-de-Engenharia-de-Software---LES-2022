using RaellShoes.Models.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RaellShoes.Models.Administrador
{
    public class Carrinho
    {
        [Required(ErrorMessage = "{0} obrigatório")]
        public Double ValorFrete { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public Double ValorTotal { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public Cliente Cliente { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public Endereco EnderecoEntrega { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public Cupom Cupom { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public List<Produto> Produtos { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public List<Cartao> Cartaos { get; set; }
    }
}
