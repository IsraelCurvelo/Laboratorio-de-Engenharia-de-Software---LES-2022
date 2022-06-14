using RaellShoes.Models;
using RaellShoes.Models.Administrador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaellShoes.Strategy
{
    public class ValidarDadosFornecedor : IStrategy
    {
        public string Processar(EntidadeDominio entidadeDominio)
        {
            if (!entidadeDominio.GetType().Name.ToLower().Equals("fornecedor"))
                return "Objeto diferente do esperado";

            Fornecedor fornecedor = (Fornecedor)entidadeDominio;

            if (fornecedor.Nome == null && fornecedor.DataCadastro == null && fornecedor.Status == null && fornecedor.Status == Models.Enums.Status.Selecione && fornecedor.CNPJ == null)
            {
                return "Dados obrigatórios não digitados";
            }
            else
                return null;
        }   
    }
}
