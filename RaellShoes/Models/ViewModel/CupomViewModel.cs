using RaellShoes.Models.Administrador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaellShoes.Models.ViewModel
{
    public class CupomViewModel
    {
        public Cupom Cupom { get; set; }
        public List<Cupom> Cupons { get; set; }

        public CupomViewModel()
        {
            Cupons = new List<Cupom>();
        }

        public CupomViewModel(Cupom cupom)
        {
            Cupom = cupom;
            Cupons = new List<Cupom>();
        }
    }
}
