using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RaellShoes.Models.Enums
{
    public enum StatusPedido
    {
        Selecione,
        [Display(Name = "EM PROCESSAMENTO")]
        EmProcessamento,
        [Display(Name = "EM TRÂNSITO")]
        EmTransito,
        [Display(Name = "ENTREGUE")]
        Entregue,
        [Display(Name = "EM TROCA")]
        EmTroca,
        [Display(Name = "TROCA AUTORIZADA")]
        TrocaAutorizada,
        [Display(Name = "PRODUTO RECEBIDO")]
        ProdutoRecebido
    }
}
