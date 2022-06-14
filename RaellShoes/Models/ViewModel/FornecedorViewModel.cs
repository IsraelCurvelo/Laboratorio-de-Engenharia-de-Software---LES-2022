using RaellShoes.Models.Administrador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaellShoes.Models.ViewModel
{
    public class FornecedorViewModel
    {
        public Fornecedor Fornecedor { get; set; }
        public List<Fornecedor> Fornecedores { get; set; }

        public FornecedorViewModel()
        {
            Fornecedores = new List<Fornecedor>();
        }

        public FornecedorViewModel(Fornecedor fornecedor)
        {
            Fornecedor = fornecedor;
            Fornecedores = new List<Fornecedor>();
        }
    }
}
