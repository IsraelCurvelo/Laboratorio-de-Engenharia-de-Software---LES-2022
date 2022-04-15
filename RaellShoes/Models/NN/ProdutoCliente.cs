using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaellShoes.Models.NN
{
    public class ProdutoCliente : EntidadeDominio
    {
        public int ClienteId { get; set; }
        public int ProdutoId { get; set; }

        public int Quantidade { get; set; }

        public double Valor { get; set; }

        public ProdutoCliente()
        {

        }

        public ProdutoCliente(int idCliente, int idProduto, int quantidade, double valor)
        {
            ClienteId = idCliente;
            ProdutoId = idProduto;
            Quantidade = quantidade;
            Valor = valor;
        }
    }
}
