using RaellShoes.Models.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaellShoes.Models.ViewModel
{
    public class LoginViewModel
    {
        public String Nome { get; set; }

        public String Email { get; set; }

        public int IdCliente { get; set; }
      
        public bool Admin { get; set; }
    }
}
