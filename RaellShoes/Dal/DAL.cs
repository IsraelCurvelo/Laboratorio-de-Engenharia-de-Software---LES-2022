using Microsoft.EntityFrameworkCore;
using RaellShoes.Data;
using RaellShoes.Models;
using RaellShoes.Models.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RaellShoes.Dal
{
    public class DAL : IDAL
    {
        protected readonly DataBaseContext dbContext;
        public DAL(DataBaseContext dbContext)
        {
            this.dbContext = dbContext;
        }        

        //MÉTODOS GENÉRICOS
        public string Cadastrar(EntidadeDominio entidadeDominio)
        {
            try
            {
                dbContext.Add(entidadeDominio);
                dbContext.SaveChanges();
                return null;
            }
            catch (Exception e)
            {
                return e.Message;
            }
            
        }

        public string Alterar(EntidadeDominio entidadeDominio)
        {
            
            switch (entidadeDominio.GetType().Name.ToLower())
            {
                case ("cliente"):
                    if (!dbContext.Cliente.Any(x => x.Id == entidadeDominio.Id))
                    {
                        throw new ApplicationException("Objeto não encontrado");
                    }
                    return ExtensaoAlterar(entidadeDominio);

                case ("endereco"):
                    if (!dbContext.Endereco.Any(x => x.Id == entidadeDominio.Id))
                    {
                        throw new ApplicationException("Objeto não encontrado");
                    }
                    return ExtensaoAlterar(entidadeDominio);

                case ("cartao"):
                    if (!dbContext.Cartao.Any(x => x.Id == entidadeDominio.Id))
                    {
                        throw new ApplicationException("Objeto não encontrado");
                    }
                    return ExtensaoAlterar(entidadeDominio);

                default:
                    return null;
            }
        }

        private string ExtensaoAlterar(EntidadeDominio entidadeDominio)
        {
            try
            {
                dbContext.Update(entidadeDominio);
                dbContext.SaveChanges();
                return null;
            }
            catch (ApplicationException e)
            {
                return e.Message;
            }
        }

        public string Excluir(EntidadeDominio entidadeDominio)
        {
            try
            {
                dbContext.Remove(entidadeDominio);
                dbContext.SaveChanges();
                return null;
            }
            catch (Exception e )
            {
                return e.Message;
            }
            
        }

        public List<EntidadeDominio> Consultar(EntidadeDominio entidadeDominio)
        {
            List<EntidadeDominio> resultado = new List<EntidadeDominio>(); 

            switch (entidadeDominio.GetType().Name.ToLower())
            {
                case ("endereco"): 
                    foreach (EntidadeDominio x in dbContext.Endereco.Include(x => x.Cidade).Include(x => x.Cidade.Estado).Include(x => x.Cidade.Estado.Pais)
                     .ToList().Where(x => x.ClienteId == entidadeDominio.Id))
                    {
                        resultado.Add(x);
                    }
                    return resultado;

                case ("cartao"):
                    foreach (EntidadeDominio x in dbContext.Cartao.ToList().Where(x => x.ClienteId == entidadeDominio.Id))
                    {
                        resultado.Add(x);
                    }
                    return resultado;

                default:
                    return null;
            }
        }

        public EntidadeDominio ConsultarId(EntidadeDominio entidadeDominio)
        {          
           
            if (entidadeDominio.GetType().Name.ToLower().Equals("cliente"))
            {
                 return dbContext.Cliente
                    .Include(x => x.Telefone)
                    .Include(x => x.Endereco)
                    .Include(x => x.Endereco).Where(x => x.Endereco.TipoEndereco == 0)
                    .Include(x => x.Endereco.Cidade)
                    .Include(x => x.Endereco.Cidade.Estado)
                    .Include(x => x.Endereco.Cidade.Estado.Pais)                    
                    .FirstOrDefault(x => x.Id == entidadeDominio.Id);                              
            } 

            if (entidadeDominio.GetType().Name.ToLower().Equals("endereco"))
            {
                  return dbContext.Endereco                   
                   .Include(x => x.Cidade)
                   .Include(x => x.Cidade.Estado)
                   .Include(x => x.Cidade.Estado.Pais)
                   .FirstOrDefault(x => x.Id == entidadeDominio.Id);
            }
            return null;                    
        }
        
        public Cliente ConsultarEmail(String email)
        {
            return dbContext.Cliente.Include(x => x.Usuario).FirstOrDefault(x => x.Usuario.Email == email);           
        }


        //*********MÉTODOS ESPECIALISTA****************        

        public Cliente Login(Cliente cliente)
        {
            Cliente clienteBanco = ConsultarEmail(cliente.Usuario.Email);
            if (clienteBanco != null)
            {
                if (cliente.Usuario.Senha.Equals(clienteBanco.Usuario.Senha))
                    return clienteBanco;
            }
            return null;
        }  
        
    }
}
