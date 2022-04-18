using RaellShoes.Models.Clientes;
using RaellShoes.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public Double SubTotalProdutos { get; set; }

        public String ApelidoEnderecoEntrega { get; set; }

        public Double ValorFrete { get; set; }

        public Double SubTotalFrete { get; set; }

        public Double SubTotalCupom { get; set; }

        public int NumeroCartoesUsados { get; set; }

        public String Cartao1Apelido { get; set; }

        public Double Cartao1Valor { get; set; }

        public String Parcelamento1Valor { get; set; }

        public String Cartao2Apelido { get; set; }

        public Double Cartao2Valor { get; set; }

        public String Parcelamento2Valor { get; set; }

        [NotMapped]
        public int ClienteId { get; set; }

        [NotMapped]
        public int CupomId { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "{0} obrigatório")]
        public List<ProdutoPedido> Produtos { get; set; }

        

        public Pedido()
        {
            Produtos = new List<ProdutoPedido>();
        }

        public Pedido(string numeroPedido, double valorTotal, DateTime dataCompra, FormaPagamento formaPagamento, StatusPedido statusPedido, Cliente cliente, List<ProdutoPedido> produtos, string enderecoEntrega, double subTotalProdutos, double subtotalFrete,
                        double subtotalCupom, string apelidoEnderecoEntrega, double valorFrete, int numCartoesUsados, string cartao1Apelido, double cartao1Valor, string cartao1Parcelamento, string cartao2Apelido, double cartao2Valor, string cartao2Parcelamento)
        {
            Produtos = new List<ProdutoPedido>();
            NumeroPedido = numeroPedido;
            ValorTotal = valorTotal;
            DataCompra = dataCompra;
            FormaPagamento = formaPagamento;
            Status = statusPedido;
            Cliente = cliente;
            EnderecoEntrega = enderecoEntrega;
            SubTotalProdutos = subTotalProdutos;
            SubTotalFrete = subtotalFrete;
            SubTotalCupom = subtotalCupom;
            ApelidoEnderecoEntrega = apelidoEnderecoEntrega;
            ValorFrete = valorFrete;
            NumeroCartoesUsados = numCartoesUsados;
            Cartao1Apelido = cartao1Apelido;
            Cartao1Valor = cartao1Valor;
            Parcelamento1Valor =  cartao1Parcelamento;
            Cartao2Apelido = cartao2Apelido;
            Cartao2Valor = cartao2Valor;
            Parcelamento2Valor = cartao2Parcelamento;
            

            foreach (var item in produtos)
            {
                Produtos.Add(item);
            }
        }

    }
}
