
using RaellShoes.Models;
using RaellShoes.Models.Administrador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaellShoes.Strategy
{
    public class ValidarDadosCategoria : IStrategy
    {
        public string Processar(EntidadeDominio entidadeDominio)
        {
            if (!entidadeDominio.GetType().Name.ToLower().Equals("categoria"))
                return "Objeto diferente do esperado";

            Categoria categoria = (Categoria)entidadeDominio;

            if (categoria.Nome == null && categoria.DataCadastro == null && categoria.Status == null && categoria.Status == Models.Enums.Status.Selecione)
            {
                return "Dados obrigatórios não digitados";
            }
            else
                return null;
        }
    }
}
