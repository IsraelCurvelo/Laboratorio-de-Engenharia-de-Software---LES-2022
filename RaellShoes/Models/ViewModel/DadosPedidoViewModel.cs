using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaellShoes.Models.ViewModel
{
    public class DadosPedidoViewModel
    {
        public Double SubTotalProdutos { get; set; }
        public String ApelidoEnderecoEntrega { get; set; }

        public int IdEnderecoEntrega { get; set; }

        public Double ValorFrete { get; set; }

        public Double SubTotalFrete { get; set; }

        public String ApelidoCupom { get; set; }

        public int IdCupom { get; set; }

        public Double DescontoCupom { get; set; }

        public Double SubTotalCupom { get; set; }

        public Double valorTotal { get; set; }

        public int CartoesUsados { get; set; }

        public String Cartao1Texto { get; set; } 

        public int Cartao1Id { get; set; }

        public Double Cartao1Valor { get; set; }

        public String Parcelamento1 { get; set; }

        public String Cartao2Texto { get; set; }

        public int Cartao2Id { get; set; }

        public Double Cartao2Valor { get; set; }

        public String Parcelamento2 { get; set; }

        public String NumeroPedido { get; set; }

        public DadosPedidoViewModel()
        {
        }

        public DadosPedidoViewModel(double subTotalProdutos, string apelidoEnderecoEntrega, int idEnderecoEntrega, double valorFrete, double subTotalFrete,
            string apelidoCupom, int idCupom, double descontoCupom, double subTotalCupom, double valorTotal, int cartoesUsados, string cartao1Texto, int cartao1Id, 
            int cartao1Valor, string parcelamento1, string cartao2Texto, int cartao2Id, int cartao2Valor, string parcelamento2)
        {
            SubTotalProdutos = subTotalProdutos;
            ApelidoEnderecoEntrega = apelidoEnderecoEntrega;
            IdEnderecoEntrega = idEnderecoEntrega;
            ValorFrete = valorFrete;
            SubTotalFrete = subTotalFrete;
            ApelidoCupom = apelidoCupom;
            IdCupom = idCupom;
            DescontoCupom = descontoCupom;
            SubTotalCupom = subTotalCupom;
            this.valorTotal = valorTotal;
            CartoesUsados = cartoesUsados;
            Cartao1Texto = cartao1Texto;
            Cartao1Id = cartao1Id;
            Cartao1Valor = cartao1Valor;
            Parcelamento1 = parcelamento1;
            Cartao2Texto = cartao2Texto;
            Cartao2Id = cartao2Id;
            Cartao2Valor = cartao2Valor;
            Parcelamento2 = parcelamento2;
        }
    }
}
