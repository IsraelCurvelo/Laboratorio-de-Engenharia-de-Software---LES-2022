using RaellShoes.Models.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaellShoes.Models.ViewModel
{
    public class CartaoViewModel
    {
        public Cartao Cartao { get; set; }

        public List<Cartao> Cartoes { get; set; }

        public CartaoViewModel()
        {
            Cartoes = new List<Cartao>();
        }
    }
}
