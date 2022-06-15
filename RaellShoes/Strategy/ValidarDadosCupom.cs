using RaellShoes.Models;
using RaellShoes.Models.Administrador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaellShoes.Strategy
{
    public class ValidarDadosCupom : IStrategy
    {
        public String Processar(EntidadeDominio entidadeDominio)
        {
            if (!entidadeDominio.GetType().Name.ToLower().Equals("cupom"))
                return "Objeto diferente do esperado";

            Cupom cupom = (Cupom)entidadeDominio;

            if (cupom.Codigo == null || cupom.Desconto <=0 || cupom.Descricao == null)
                return "Erro na digitação dos dados! *Dados Obrigatórios";
            else
                return null;
        }
    }
}
