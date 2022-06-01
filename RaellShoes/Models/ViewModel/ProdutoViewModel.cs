using RaellShoes.Models.Administrador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaellShoes.Models.ViewModel
{
    public class ProdutoViewModel
    {
        public Produto Produto { get; set; }
        public Categoria Categoria { get; set; }
        public List<Categoria> Categorias { get; set; }

        public Fornecedor Fornecedor { get; set; }
        public List<Fornecedor> Fornecedores { get; set; }
        public GrupoPrecificacao GrupoPrecificacao { get; set; }
        public List<GrupoPrecificacao> GruposPrecificacao { get; set; }

        public ProdutoViewModel()
        {
            Categorias = new List<Categoria>();
            Fornecedores = new List<Fornecedor>();
            GruposPrecificacao = new List<GrupoPrecificacao>();
        }
    }
}

