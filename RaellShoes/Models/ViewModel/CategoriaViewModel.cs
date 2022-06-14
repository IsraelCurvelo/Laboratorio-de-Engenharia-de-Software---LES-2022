using RaellShoes.Models.Administrador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaellShoes.Models.ViewModel
{
    public class CategoriaViewModel
    {
        public Categoria Categoria { get; set; }
        public List<Categoria> Categorias { get; set; }

        public CategoriaViewModel()
        {
            Categorias = new List<Categoria>();
        }

        public CategoriaViewModel(Categoria categoria)
        {
            Categoria = categoria;
            Categorias = new List<Categoria>();
        }
    }
}
