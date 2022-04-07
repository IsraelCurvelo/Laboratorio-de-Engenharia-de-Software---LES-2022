using RaellShoes.Models.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RaellShoes.Models.Administrador
{
    public class Carrinho : EntidadeDominio
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

        [NotMapped]
        [Required(ErrorMessage = "{0} obrigatório")]
        public HashSet<Produto> Produtos { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "{0} obrigatório")]
        public List<Cartao> Cartoes { get; set; }

        [NotMapped]
        
        public List<int> QtdeProdutos { get; set; }

        public Carrinho()
        {
            Produtos = new HashSet<Produto>();
            Cartoes = new List<Cartao>();
            QtdeProdutos = new List<int>();
        }

        public Carrinho(double valorFrete, double valorTotal, Cliente cliente, Endereco endereco, Cupom cupom)
        {
            ValorFrete = valorFrete;
            ValorTotal = valorTotal;
            Cliente = cliente;
            EnderecoEntrega = endereco;
            Cupom = cupom;
            Produtos = new HashSet<Produto>();
            Cartoes = new List<Cartao>();
            QtdeProdutos = new List<int>();
        }
    }
}
