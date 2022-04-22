using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RaellShoes.Models.Enums
{
    public enum MotivoTroca
    {
        [Display(Name = "Desistência")]
        Desistencia,
        Defeito,
        Tamanho,
        [Display(Name = "Não Gostei")]
        NaoGostei,
        [Display(Name = "Recebi Errado")]
        RecebiErrado,
        Outro
    }
}
