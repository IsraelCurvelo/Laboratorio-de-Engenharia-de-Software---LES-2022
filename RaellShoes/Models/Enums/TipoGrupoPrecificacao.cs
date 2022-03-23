using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RaellShoes.Models.Enums
{
    public enum TipoGrupoPrecificacao
    {
        [Display(Name = "Lançamento")]
        Lancamento,
        Vigente,
        Outlet
    }
}
