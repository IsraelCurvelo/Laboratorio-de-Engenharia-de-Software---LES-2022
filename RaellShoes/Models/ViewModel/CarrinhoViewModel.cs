using RaellShoes.Models.Administrador;
using RaellShoes.Models.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaellShoes.Models.ViewModel
{
    public class CarrinhoViewModel
    {
        public Carrinho Carrinho { get; set; }

        public Endereco Endereco { get; set; }
        public Cartao Cartao { get; set; }

        public List<Endereco> Enderecos { get; set; }

        public List<Cartao> Cartoes { get; set; }

        public List<Cupom> Cupons { get; set; }

        public CarrinhoViewModel()
        {
            Enderecos = new List<Endereco>();
            Cartoes = new List<Cartao>();
            Cupons = new List<Cupom>();
        }

        public CarrinhoViewModel(Carrinho carrinho)
        {
            Carrinho = carrinho;
            Enderecos = new List<Endereco>();
            Cartoes = new List<Cartao>();
            Cupons = new List<Cupom>();
        }
    }
}
