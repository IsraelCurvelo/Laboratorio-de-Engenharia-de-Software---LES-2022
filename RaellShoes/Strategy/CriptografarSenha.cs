using RaellShoes.Models;
using RaellShoes.Models.Clientes;
using System;
using System.Security.Cryptography;
using System.Text;

namespace RaellShoes.Strategy
{
    public class CriptografarSenha : IStrategy
    {      
        public String Processar(EntidadeDominio entidadeDominio)
        {
            if (!entidadeDominio.GetType().Name.ToLower().Equals("cliente")) 
                return null;
            
            Cliente cliente = (Cliente)entidadeDominio;

            if (cliente.Usuario.Senha == null) 
                return null;

            // criptografia MD5
            MD5 md5Hash = MD5.Create();
            // Converter a String para array de bytes, que é como a biblioteca trabalha.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(cliente.Usuario.Senha));

            // Cria-se um StringBuilder para recompôr a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop para formatar cada byte como uma String em hexadecimal
            for (int i = 0; i < data.Length; i++) sBuilder.Append(data[i].ToString("x2"));            

            return cliente.Usuario.Senha = sBuilder.ToString();          
        }
    }       
}
