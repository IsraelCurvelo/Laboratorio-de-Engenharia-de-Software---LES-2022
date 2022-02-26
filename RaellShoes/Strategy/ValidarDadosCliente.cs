using RaellShoes.Models;
using RaellShoes.Models.Clientes;
using System;

namespace RaellShoes.Strategy
{
    public class ValidarDadosCliente : IStrategy
    {
        public String Processar(EntidadeDominio entidadeDominio)
        {
            if (!entidadeDominio.GetType().Name.ToLower().Equals("cliente")) return "Objeto diferente do esperado";

            Cliente cliente = (Cliente)entidadeDominio;

            DateTime time = cliente.DataNascimento.AddYears(18);
            
            if(cliente.Nome == null || cliente.Sobrenome == null ||cliente.Cpf == null || cliente.Cpf.Length > 14 ||cliente.Cpf.Length< 11 || cliente.DataNascimento == null || cliente.Genero == null
                || cliente.Telefone.TipoTelefone == null || cliente.Telefone.DDD == null || cliente.Telefone.DDD.Length != 2 || cliente.Telefone.Numero == null || cliente.Telefone.Numero.Length >10 || cliente.Telefone.Numero.Length <8)
                                return "Erro na digitação dos dados! *Dados Obrigatórios";

            if (cliente.DataNascimento.Date > DateTime.Now) return "Não é possível cadastrar data de nascimento futura!";

            if (time > DateTime.Now) return "É preciso ser maior de idade para se cadastrar";                  

              else
                return null;
        }
    }
}
