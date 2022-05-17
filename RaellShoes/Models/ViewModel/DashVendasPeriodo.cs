using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaellShoes.Models.ViewModel
{
    public class DashVendasPeriodo
    {
        public int Casual { get; set; }
        public int Treino { get; set; }
        public int Corrida { get; set; }
        public int Skate { get; set; }
        public int Basquete { get; set; }

        public int Social { get; set; }

        public int Outro { get; set; }

        public string Data { get; set; }
    }
}
