using RaellShoes.Models.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaellShoes.Models.ViewModel
{
    public class ClienteViewModel
    {
        public Cliente Cliente { get; set; }

        public List<Cliente> Clientes { get; set; }

        public ClienteViewModel()
        {
            Clientes = new List<Cliente>();
        }

        public ClienteViewModel(Cliente cliente)
        {
            Cliente = cliente;
            Clientes = new List<Cliente>();
        }
    }
}
