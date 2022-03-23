using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RaellShoes.Models.Enums
{
    public enum Marca
    {
        Adidas,
        Nike,
        [Display(Name = "New Balance")]
        NewBalance,
        [Display(Name = "Air Jordan")]
        AirJordan,
        Rebook,
        Mizuno,
        Puma,
        Qix,
        Oakley,
        Ferracini,
        Mormai
    }
}
