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

        public ProdutoCliente()
        {

        }

        public ProdutoCliente(int idCliente, int idProduto)
        {
            ClienteId = idCliente;
            ProdutoId = idProduto;
        }
    }
}
