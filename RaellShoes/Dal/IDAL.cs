using RaellShoes.Models;
using System.Collections.Generic;

namespace RaellShoes.Dal
{
    public interface IDAL 
    {
       string Cadastrar(EntidadeDominio entidadeDominio);

       string Alterar(EntidadeDominio entidadeDominio);

       string Excluir(EntidadeDominio entidadeDominio);

       List<EntidadeDominio> Consultar(EntidadeDominio entidadeDominio);

       EntidadeDominio ConsultarId(EntidadeDominio entidadeDominio);

    }
}
