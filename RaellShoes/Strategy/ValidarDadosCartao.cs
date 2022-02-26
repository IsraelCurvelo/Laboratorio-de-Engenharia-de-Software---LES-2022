using RaellShoes.Models;
using RaellShoes.Models.Clientes;
using System;

namespace RaellShoes.Strategy
{
    public class ValidarDadosCartao : IStrategy
    {
        public String Processar(EntidadeDominio entidadeDominio)
        {
            if (!entidadeDominio.GetType().Name.ToLower().Equals("cartao")) 
                return "Objeto diferente do esperado";

            Cartao cartao = (Cartao)entidadeDominio;

            if (cartao.TipoCartao == null || cartao.Bandeira == null || cartao.Apelido == null || cartao.Numero == null ||cartao.Numero.Length >20 || cartao.NomeImpresso == null 
                || cartao.Validade == null || cartao.Validade.Length>5 || cartao.CodigoSeguranca == null || cartao.CodigoSeguranca.Length > 4)
                return "Erro na digitação dos dados! *Dados Obrigatórios";
            else
                return null;
        }
    }
}
