using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaellShoes.Models.NN
{
    public class CupomCliente : EntidadeDominio
    {
        public int ClienteId { get; set; }
        public int CupomId { get; set; }

        public CupomCliente()
        {

        }

        public CupomCliente(int idCliente, int idCupom)
        {
            ClienteId = idCliente;
            CupomId = idCupom;
        }
    }
}
