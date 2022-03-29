using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RaellShoes.Models.Enums
{
    public enum FormaPagamento
    {
        Selecione,
        [Display(Name ="Crédito")]
        Credito,
        [Display(Name ="Débito")]
        Debito,
        Pix,
        Boleto
    }
}
