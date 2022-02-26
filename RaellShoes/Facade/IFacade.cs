using RaellShoes.Models;
using System;
using System.Collections.Generic;

namespace RaellShoes.Facadee
{ 
    public interface IFacade
    {
        String Cadastrar(EntidadeDominio entidadeDominio);
        String Alterar(EntidadeDominio entidadeDominio);
        String Excluir(EntidadeDominio entidadeDominio);
        List<EntidadeDominio> Consultar(EntidadeDominio entidadeDominio);
    }
}

