using RaellShoes.Dal;
using RaellShoes.Data;
using RaellShoes.Models;
using RaellShoes.Models.Clientes;
using RaellShoes.Strategy;
using System;
using System.Collections.Generic;


namespace RaellShoes.Facadee
{
    public class Facade : IFacade
    {
        private readonly DataBaseContext dbContext;
        private DAL dal;

        public Facade(DataBaseContext dbContext)
        {
            this.dbContext = dbContext;
            dal = new DAL(dbContext);
        }


        public String Cadastrar(EntidadeDominio entidadeDominio)
        {
            Log log = new Log();           
            GerarLog gerarLog = new GerarLog();

            if (entidadeDominio.GetType().Name.ToLower().Equals("cliente"))
            {
                Cliente cliente = (Cliente)entidadeDominio;
               
                ValidarDadosCliente validarCliente = new ValidarDadosCliente();
                ValidarDadosEndereco validarEndereco = new ValidarDadosEndereco();
                ValidarUsuario validarSenha = new ValidarUsuario();
                CriptografarSenha criptografarSenha = new CriptografarSenha();

                string confirmacaoDadosCliente = validarCliente.Processar(cliente);        
                string confirmacaoSenha = validarSenha.Processar(cliente);               
                string senhacriptografada = criptografarSenha.Processar(cliente);

                string confirmacaoDadosEndereco = null;
                foreach (var item in cliente.Enderecos)
                {
                    string retornoValidacaoEndereco = validarEndereco.Processar(item);
                    if (retornoValidacaoEndereco != null)
                        confirmacaoDadosCliente = retornoValidacaoEndereco;
                }

                cliente.Usuario.Senha = senhacriptografada;
                cliente.Status = true;

                if (confirmacaoDadosCliente == null && confirmacaoDadosEndereco == null && confirmacaoSenha == null && senhacriptografada != null)
                {
                    return CadastrarEntidade(cliente, log, gerarLog);
                }
                else
                {
                    List<String> lista = new List<string>();
                    lista.Add(confirmacaoDadosCliente);
                    lista.Add(confirmacaoDadosEndereco);
                    lista.Add(confirmacaoSenha);
                    if(senhacriptografada == null)
                        lista.Add("Senha não foi criptografada");       
                    
                    return ConcatenarErros(lista);
                }                               
            }

            if (entidadeDominio.GetType().Name.ToLower().Equals("endereco"))
            {
                Endereco endereco = (Endereco)entidadeDominio;
                
                ValidarDadosEndereco validar = new ValidarDadosEndereco();
                string confirmacao = validar.Processar(endereco);  

                if(confirmacao != null)  
                    return confirmacao;

                return CadastrarEntidade(endereco, log, gerarLog);                        
              
            }

            if (entidadeDominio.GetType().Name.ToLower().Equals("cartao"))
            {
                Cartao cartao = (Cartao)entidadeDominio;
                
                ValidarDadosCartao validar = new ValidarDadosCartao();
                string confirmacao = validar.Processar(cartao);

                if (confirmacao != null) 
                    return confirmacao;

                return CadastrarEntidade(cartao, log, gerarLog);

            }

            return null;
            
        }

        private string CadastrarEntidade(EntidadeDominio entidadeDominio, Log log, GerarLog gerarLog)
        {
            string confirmacaoCliente = dal.Cadastrar(entidadeDominio);
            log.Descricao = gerarLog.Processar(entidadeDominio) + ", [Tipo: Inserção]";
            string confirmacaoLog = dal.Cadastrar(log);

            if (confirmacaoCliente == null && confirmacaoLog == null) 
                return null;

            string erro = null;

            if (confirmacaoCliente != null) 
                erro = confirmacaoCliente;

            if (confirmacaoLog != null) 
                erro += confirmacaoLog;

            return erro;
        }

        private string ConcatenarErros(List<String> lista)
        {
            String resposta = null;

            foreach (var item in lista)            
                if (item != null)
                    resposta += ", " +  item;                
            
            return resposta;
        }


        public String Alterar(EntidadeDominio entidadeDominio)
        {
            Log log = new Log();
            GerarLog gerarLog = new GerarLog();

            if (entidadeDominio.GetType().Name.ToLower().Equals("cliente"))
            {
                Cliente cliente = (Cliente)entidadeDominio;

                ValidarDadosCliente validarCliente = new ValidarDadosCliente();
                ValidarDadosEndereco validarEndereco = new ValidarDadosEndereco();                

                string confirmacaoDadosCliente = validarCliente.Processar(cliente);
                string confirmacaoDadosEndereco = validarEndereco.Processar(cliente.Endereco);

                if (confirmacaoDadosCliente == null && confirmacaoDadosEndereco == null)
                {
                    dal.Alterar(cliente);                   
                    log.Descricao = gerarLog.Processar(cliente) + ", [Tipo: Alteração]";
                    dal.Cadastrar(log);
                    return null;
                }
                else
                {
                    String resposta = null;

                    if (confirmacaoDadosCliente != null) 
                        resposta = confirmacaoDadosCliente;

                    if (confirmacaoDadosEndereco != null) 
                        resposta += ", " + confirmacaoDadosEndereco;  
                    
                    return resposta;
                }
                
            }

            if (entidadeDominio.GetType().Name.ToLower().Equals("endereco"))
            {
                Endereco endereco = (Endereco)entidadeDominio;
                
                ValidarDadosEndereco validarEndereco = new ValidarDadosEndereco();
               
                string confirmacaoDadosEndereco = validarEndereco.Processar(endereco);

                if (confirmacaoDadosEndereco == null)
                {
                    dal.Alterar(endereco);
                    log.Descricao = gerarLog.Processar(endereco) + ", [Tipo: Alteração]";
                    dal.Cadastrar(log);
                    return null;
                }
                else               
                    return confirmacaoDadosEndereco;
               

            }

            if (entidadeDominio.GetType().Name.ToLower().Equals("cartao"))
            {
                Cartao cartao = (Cartao)entidadeDominio;

                ValidarDadosCartao validarCartao = new ValidarDadosCartao();

                string confirmacaoDadosCartao = validarCartao.Processar(cartao);

                if (confirmacaoDadosCartao == null)
                {
                    dal.Alterar(cartao);
                    log.Descricao = gerarLog.Processar(cartao) + ", [Tipo: Alteração]";
                    dal.Cadastrar(log);
                    return null;
                }
                else
                    return confirmacaoDadosCartao;


            }
            return null;
            
        }

        public string Excluir(EntidadeDominio entidadeDominio)
        {
           return dal.Excluir(entidadeDominio);
        }

        public List<EntidadeDominio> Consultar(EntidadeDominio entidadeDominio)
        {
            return dal.Consultar(entidadeDominio);
        }

        public EntidadeDominio ConsultarId(EntidadeDominio entidadeDominio)
        {
            return dal.ConsultarId(entidadeDominio);
        }
       

        public Cliente ConsultarEmail(String email)
        {
            return dal.ConsultarEmail(email);
        }

        public Cliente Login(EntidadeDominio entidadeDominio)
        {
            Cliente cliente = (Cliente)entidadeDominio;
            CriptografarSenha criptografar = new CriptografarSenha();
            string senhacrip = criptografar.Processar(cliente);

            cliente.Usuario.Senha = senhacrip;
            Cliente login = dal.Login(cliente);

            if (login != null) 
                return login;

            return null;
        }

    }
}
