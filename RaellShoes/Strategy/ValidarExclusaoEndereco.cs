using RaellShoes.Models;
using RaellShoes.Models.Clientes;
using System;

namespace RaellShoes.Strategy
{
    public class ValidarExclusaoEndereco : IStrategy
    {
        public String Processar(EntidadeDominio entidadeDominio)
        {
            if (!entidadeDominio.GetType().Name.ToLower().Equals("endereco")) 
                return "Objeto diferente do esperado";

            Endereco endereco = (Endereco)entidadeDominio;
            //FALTA IMPLEMENTAR
                return null;
        }
    }
}
