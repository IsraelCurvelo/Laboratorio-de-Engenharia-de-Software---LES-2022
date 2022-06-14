using RaellShoes.Models;
using RaellShoes.Models.Administrador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaellShoes.Strategy
{
    public class ValidarDadosGrupoPrecificacao : IStrategy
    {
        public string Processar(EntidadeDominio entidadeDominio)
        {
            if (!entidadeDominio.GetType().Name.ToLower().Equals("grupoprecificacao"))
                return "Objeto diferente do esperado";

            GrupoPrecificacao grupoPrecificacao = (GrupoPrecificacao)entidadeDominio;

            if (grupoPrecificacao.Nome == null && grupoPrecificacao.DataCadastro == null && grupoPrecificacao.Status == Models.Enums.Status.Selecione && grupoPrecificacao.TipoGrupoPrecificacao == Models.Enums.TipoGrupoPrecificacao.Selecione && grupoPrecificacao.MargemMax > 0 && grupoPrecificacao.MargemMin > 0)
            {
                return "Dados obrigatórios não digitados";
            }
            else if(grupoPrecificacao.MargemMax < grupoPrecificacao.MargemMin)
                return "O valor de Margem Máxima não pode ser inferior ao de Margem Mínima";
            else
                return null;
        }
    }
}
