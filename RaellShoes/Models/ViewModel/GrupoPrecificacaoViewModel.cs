using RaellShoes.Models.Administrador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaellShoes.Models.ViewModel
{
    public class GrupoPrecificacaoViewModel
    {
        public GrupoPrecificacao GrupoPrecificacao { get; set; }
        public List<GrupoPrecificacao> GruposPrecificacao { get; set; }

        public GrupoPrecificacaoViewModel()
        {
            GruposPrecificacao = new List<GrupoPrecificacao>();
        }

        public GrupoPrecificacaoViewModel(GrupoPrecificacao grupoPrecificacao)
        {
            GrupoPrecificacao = grupoPrecificacao;
            GruposPrecificacao = new List<GrupoPrecificacao>();
        }
    }
}
