using RaellShoes.Models;
using System;

namespace RaellShoes.Strategy
{
    interface IStrategy
    {
         String Processar(EntidadeDominio entidadeDominio);
    }
}
