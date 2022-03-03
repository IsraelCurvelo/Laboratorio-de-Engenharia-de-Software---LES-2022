using RaellShoes.Models.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaellShoes.Models.ViewModel
{
    public class EnderecoViewModel
    {
        public Endereco Endereco { get; set; }

        public List<Endereco> Enderecos { get; set; }

        public EnderecoViewModel()
        {
            Enderecos = new List<Endereco>();
        }
    }
}
