using RaellShoes.Models;
using RaellShoes.Models.Clientes;
using System;
using System.Text.RegularExpressions;

namespace RaellShoes.Strategy
{
    public class ValidarUsuario : IStrategy
    {
        public String Processar(EntidadeDominio entidadeDominio)
        {
            if (!entidadeDominio.GetType().Name.ToLower().Equals("cliente")) 
                return "Objeto diferente do esperado";          

            Cliente cliente = (Cliente)entidadeDominio;

            if (cliente.Usuario.Email == null || cliente.Usuario.Senha == null) 
                return "Campos nulos";
            
            //if(usuario.Senha != usuario.ConfirmacaoSenha) return "SENHAS DIFERENTES";    
          
            var input = cliente.Usuario.Senha;
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasMiniMaxChars = new Regex(@".{8,20}");            
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");


            if (!hasLowerChar.IsMatch(input) || !hasUpperChar.IsMatch(input) || !hasMiniMaxChars.IsMatch(input) 
                || !hasNumber.IsMatch(input) || !hasSymbols.IsMatch(input))            
                        return  "CARACTERES OBRIGATÓRIOS NÃO DIGITADOS" ;                              
           
            return null;            
        }
    }
}
