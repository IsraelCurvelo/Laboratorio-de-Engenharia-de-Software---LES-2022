using RaellShoes.Models.Clientes;
using RaellShoes.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RaellShoes.Models.Administrador
{
    public class Pedido : EntidadeDominio
    {
        [Required(ErrorMessage = "{0} obrigatório")]
        public String NumeroPedido { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public Double ValorTotal { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public DateTime DataCompra { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public String EnderecoEntrega { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public FormaPagamento FormaPagamento { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public StatusPedido Status { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public Cliente Cliente { get; set; }

        
        public Cupom Cupom { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public List<Produto> Produtos { get; set; }

        public Pedido()
        {
            Produtos = new List<Produto>();
        }

        public Pedido(string numeroPedido, double valorTotal, DateTime dataCompra, FormaPagamento formaPagamento, StatusPedido statusPedido, Cliente cliente, List<Produto> produtos, string enderecoEntrega)
        {
            Produtos = new List<Produto>();
            NumeroPedido = numeroPedido;
            ValorTotal = valorTotal;
            DataCompra = dataCompra;
            FormaPagamento = formaPagamento;
            Status = statusPedido;
            Cliente = cliente;
            EnderecoEntrega = enderecoEntrega;

            foreach (var item in produtos)
            {
                Produtos.Add(item);
            }
        }

    }
}
