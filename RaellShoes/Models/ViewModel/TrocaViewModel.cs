using RaellShoes.Models.Administrador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaellShoes.Models.ViewModel
{
    public class TrocaViewModel
    {
        public List<Troca> Trocas { get; set; }
        public List<Produto> Produtos { get; set; }

        public List<Pedido> Pedidos { get; set; }

        public Troca Troca { get; set; }

        public TrocaViewModel()
        {
            Trocas = new List<Troca>();
            Produtos = new List<Produto>();
            Pedidos = new List<Pedido>();
        }
    }
}
