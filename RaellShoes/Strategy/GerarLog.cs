using RaellShoes.Models;
using RaellShoes.Models.Clientes;
using System;

namespace RaellShoes.Strategy
{
    public class GerarLog : IStrategy
    {
        public String Processar(EntidadeDominio entidadeDominio)
        {
           
            switch (entidadeDominio.GetType().Name.ToLower())
            {                             

                case ("cliente"):
                    Cliente cliente = (Cliente)entidadeDominio;
                    return "Log Gerado!: [Data: " + DateTime.Now + "], [Dados do cliente: " + cliente.Nome + ", " + cliente.Cpf + "]";

                case ("endereco"):
                    Endereco endereco = (Endereco)entidadeDominio;
                    return "Log Gerado!: [Data: " + DateTime.Now + "], [Dados do endereço: " + endereco.Apelido + ", " + endereco.Cep + "]";

                case ("cartao"):
                    Cartao cartao = (Cartao)entidadeDominio;
                    return "Log Gerado!: [Data: " + DateTime.Now + "], [Dados do cartao: " + cartao.Apelido + ", ]";                 

                default:
                    return null;
            } 
        }
    }
}
