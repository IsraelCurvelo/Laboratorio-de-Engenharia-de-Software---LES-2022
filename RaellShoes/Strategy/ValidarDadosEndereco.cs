using RaellShoes.Models;
using RaellShoes.Models.Clientes;
using System;

namespace RaellShoes.Strategy
{
    public class ValidarDadosEndereco : IStrategy
    {
        public String Processar(EntidadeDominio entidadeDominio)
        {
            if (!entidadeDominio.GetType().Name.ToLower().Equals("endereco")) 
                return "Objeto diferente do esperado";

            Endereco endereco = (Endereco)entidadeDominio;

            if (endereco.TipoEndereco == null || endereco.Apelido == null || endereco.Cep == null || endereco.Cep.Length > 9 || endereco.TipoLogradouro == null 
                || endereco.TipoResidencia == null || endereco.Logradouro == null|| endereco.Numero == null || endereco.Bairro == null || endereco.Cidade.Descricao == null 
                || endereco.Cidade.Estado.Descricao == null || endereco.Cidade.Estado.Descricao.Length > 2 || endereco.Cidade.Estado.Pais.Descricao == null)
                return "Erro na digitação dos dados! *Dados Obrigatórios";
            else
                return null;
        }
    }
}