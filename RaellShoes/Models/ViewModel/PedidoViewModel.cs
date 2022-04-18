using RaellShoes.Models.Administrador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaellShoes.Models.ViewModel
{
    public class PedidoViewModel
    {
        public List<Pedido> Pedidos { get; set; }

        public List<ProdutoPedido> ProdutosPedidos { get; set; }

        public Pedido Pedido { get; set; }

        public ProdutoPedido ProdutoPedido { get; set; }
    }
}
