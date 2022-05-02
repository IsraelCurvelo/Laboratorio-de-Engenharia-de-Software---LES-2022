using RaellShoes.Dal;
using RaellShoes.Data;
using RaellShoes.Models;
using RaellShoes.Models.Administrador;
using RaellShoes.Models.Clientes;
using RaellShoes.Models.Enums;
using RaellShoes.Models.NN;
using RaellShoes.Models.ViewModel;
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
               
                string retornoValidacaoEndereco = validarEndereco.Processar(cliente.Endereco);
                  
                       
              
                cliente.Usuario.DataCadastro = DateTime.Now;
                cliente.Usuario.Senha = senhacriptografada;
                cliente.Status = true;
                cliente.Usuario.Admin = false;
               

                if (confirmacaoDadosCliente == null && retornoValidacaoEndereco == null && confirmacaoSenha == null && senhacriptografada != null)
                {
                    return CadastrarEntidade(cliente, log, gerarLog);
                }
                else
                {
                    List<String> lista = new List<string>();
                    lista.Add(confirmacaoDadosCliente);
                    lista.Add(retornoValidacaoEndereco);
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

            if (entidadeDominio.GetType().Name.ToLower().Equals("troca"))
            {
                Troca troca = (Troca)entidadeDominio;                

                return CadastrarEntidade(troca, log, gerarLog);
            }

            if (entidadeDominio.GetType().Name.ToLower().Equals("cupom"))
            {
                Cupom cupom = (Cupom)entidadeDominio;

                return CadastrarEntidade(cupom, log, gerarLog);
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
                    resposta += item+ " | " ;                
            
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

                    string confirmacaoEndereco = null;                    
                    cliente.Enderecos = new List<Endereco>();
                    cliente.Enderecos.Add(cliente.Endereco);

                    foreach (var item in cliente.Enderecos)
                    {
                        confirmacaoEndereco = Alterar(cliente.Endereco);
                    }

                    if (confirmacaoEndereco == null)
                        return null;
                    else
                        return confirmacaoEndereco;
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

            if (entidadeDominio.GetType().Name.ToLower().Equals("produtocliente"))
            {
                ProdutoCliente produtoCliente = (ProdutoCliente)entidadeDominio;       

                string conf = dal.Alterar(produtoCliente);
                log.Descricao = gerarLog.Processar(produtoCliente) + ", [Tipo: Alteração]";
                dal.Cadastrar(log);
                return conf;

            }

            if (entidadeDominio.GetType().Name.ToLower().Equals("pedido"))
            {
                Pedido pedido = (Pedido)entidadeDominio;

                string conf = dal.Alterar(pedido);
                log.Descricao = gerarLog.Processar(pedido) + ", [Tipo: Alteração]";
                dal.Cadastrar(log);
                return conf;

            }

            if (entidadeDominio.GetType().Name.ToLower().Equals("troca"))
            {
                Troca troca = (Troca)entidadeDominio;

                string conf = dal.Alterar(troca);
                log.Descricao = gerarLog.Processar(troca) + ", [Tipo: Alteração]";
                dal.Cadastrar(log);
                return conf;

            }
            if (entidadeDominio.GetType().Name.ToLower().Equals("produto"))
            {
                Produto produto = (Produto)entidadeDominio;

                string conf = dal.Alterar(produto);
                log.Descricao = gerarLog.Processar(produto) + ", [Tipo: Alteração]";
                dal.Cadastrar(log);
                return conf;

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

        public LoginViewModel Login(EntidadeDominio entidadeDominio)
        {
            Cliente cliente = (Cliente)entidadeDominio;
            CriptografarSenha criptografar = new CriptografarSenha();
            string senhacrip = criptografar.Processar(cliente);

            cliente.Usuario.Senha = senhacrip;
            Cliente login = dal.Login(cliente);

            

            if (login != null) {
                Usuario usuario = (Usuario)dal.ConsultarId(login.Usuario);
                return new LoginViewModel { Nome = login.Nome, Email = login.Usuario.Email, IdCliente = login.Id, Admin = usuario.Admin };
            }
            return null;
        }

        public string CadastrarEnderecosIniciais(Cliente cliente)
        {
            //Endereço Residencial
            Endereco enderecoResidencial = new Endereco(
             cliente.Endereco.Apelido, cliente.Endereco.Logradouro, cliente.Endereco.Numero, cliente.Endereco.Complemento,
             cliente.Endereco.Bairro, cliente.Endereco.Cep, cliente.Endereco.Observacoes, cliente.Endereco.Cidade,
             cliente.Endereco.TipoResidencia, cliente.Endereco.TipoLogradouro, 0);
            enderecoResidencial.Id = 0;
            enderecoResidencial.ClienteId = cliente.Id;
            enderecoResidencial.CadastroInicial = true;
            string confirmacaoEnderecoResidencial = Cadastrar(enderecoResidencial);

            Endereco enderecoCobranca;
            Endereco enderecoEntrega;

            //Endereço Entrega
            if (cliente.FlagEntrega)
            {
                enderecoEntrega = new Endereco(
                    cliente.Endereco.Apelido, cliente.Endereco.Logradouro, cliente.Endereco.Numero, cliente.Endereco.Complemento,
                    cliente.Endereco.Bairro, cliente.Endereco.Cep, cliente.Endereco.Observacoes, cliente.Endereco.Cidade,
                    cliente.Endereco.TipoResidencia, cliente.Endereco.TipoLogradouro, TipoEndereco.Entrega);
                
            }
            else
            {
                enderecoEntrega = new Endereco(
                    cliente.EnderecoEntrega.Apelido, cliente.EnderecoEntrega.Logradouro, cliente.EnderecoEntrega.Numero, cliente.EnderecoEntrega.Complemento,
                    cliente.EnderecoEntrega.Bairro, cliente.EnderecoEntrega.Cep, cliente.EnderecoEntrega.Observacoes, cliente.EnderecoEntrega.Cidade,
                    cliente.EnderecoEntrega.TipoResidencia, cliente.EnderecoEntrega.TipoLogradouro, TipoEndereco.Entrega);                
            }

            enderecoEntrega.Id = 0;
            enderecoEntrega.CadastroInicial = true;
            enderecoEntrega.ClienteId = cliente.Id;
            string confirmacaoEnderecoEntrega = Cadastrar(enderecoEntrega);

            //Endereço Cobranca
            if (cliente.FlagCobranca)
            {
                enderecoCobranca = new Endereco(cliente.Endereco.Apelido, cliente.Endereco.Logradouro, cliente.Endereco.Numero, cliente.Endereco.Complemento,
                    cliente.Endereco.Bairro, cliente.Endereco.Cep, cliente.Endereco.Observacoes, cliente.Endereco.Cidade,
                    cliente.Endereco.TipoResidencia, cliente.Endereco.TipoLogradouro, TipoEndereco.Cobrança);                              
            }
            else
            {
                enderecoCobranca = new Endereco(cliente.EnderecoCobranca.Apelido, cliente.EnderecoCobranca.Logradouro, cliente.EnderecoCobranca.Numero, cliente.EnderecoCobranca.Complemento,
                    cliente.EnderecoCobranca.Bairro, cliente.EnderecoCobranca.Cep, cliente.EnderecoCobranca.Observacoes, cliente.EnderecoCobranca.Cidade,
                    cliente.EnderecoCobranca.TipoResidencia, cliente.EnderecoCobranca.TipoLogradouro, TipoEndereco.Cobrança);                
            }

            enderecoCobranca.Id = 0;
            enderecoCobranca.CadastroInicial = true;
            enderecoCobranca.ClienteId = cliente.Id;
            string confirmacaoEnderecoCobranca = Cadastrar(enderecoCobranca);


            if (confirmacaoEnderecoResidencial == null && confirmacaoEnderecoEntrega == null && confirmacaoEnderecoCobranca == null)
                return null;
            else
                return "Houve um erro ao cadastrar os endereços";

        }

        public ICollection<Produto> ConsultarFiltroProdutos(Produto produto)
        {
            return dal.ConsultarFiltroProdutos(produto);
        }

        public string ProdutoCarrinho(Produto produto, int id)
        {
            Produto produtoRetornado = (Produto)dal.ConsultarId(produto);
            ProdutoCliente produtoCliente = new ProdutoCliente { ProdutoId = produto.Id, ClienteId = id, Quantidade = 1, Valor = produtoRetornado.Valor };
            List<EntidadeDominio> retornoBanco = dal.Consultar(produtoCliente);

            if (retornoBanco.Count == 0)
                return dal.Cadastrar(produtoCliente);
            else
                return null;
        }

        public string RemoverCarrinho(Produto produto, int id)
        {
            ProdutoCliente produtoCliente = new ProdutoCliente { ProdutoId = produto.Id, ClienteId = id };
            List<EntidadeDominio> retornoBanco = dal.Consultar(produtoCliente);
            string confirmacao = null, erro = "";
            if (retornoBanco.Count > 0)
            {
                foreach (var item in retornoBanco)
                {
                    confirmacao = dal.Excluir(item);
                    if (confirmacao != null)
                        erro += confirmacao;
                }

                if (erro != null)
                    return erro;
                else
                    return null;
            }
            else
                return null;
        }

        public Pedido RegistrarVenda(DadosPedidoViewModel dados, List<ProdutoCliente> produtoClientes)
        {
            //Montar o obj pedido
            Pedido pedido = new Pedido();           

            foreach (var item in produtoClientes)
            {
                Produto produto = new Produto { Id = item.ProdutoId };
                produto = (Produto)dal.ConsultarId(produto);

                ProdutoPedido produtoPedido = new ProdutoPedido
                {
                    ProdutoEstoqueId = produto.Id,
                    Nome = produto.Nome,
                    Modelo = produto.Modelo,
                    Valor = produto.Valor,
                    ValorSubtotal = item.Valor,
                    CodigoBarra = produto.CodigoBarra,
                    URLFoto = produto.URLFoto,
                    Descricao = produto.Descricao,
                    Quantidade = item.Quantidade,
                    GrupoPrecificacao = produto.GrupoPrecificacao,
                    Fornecedor = produto.Fornecedor,
                    Marca = produto.Marca,
                    CorPrimariaProduto = produto.CorPrimariaProduto,
                    CorSecundariaProduto = produto.CorSecundariaProduto,
                    Genero = produto.Genero,
                    Tamanho = produto.Tamanho,
                    FichaTecnica = produto.FichaTecnica
                };

                pedido.Produtos.Add(produtoPedido);

                Cliente cliente = new Cliente { Id = item.ClienteId };
                cliente = (Cliente)dal.ConsultarId(cliente);
                pedido.Cliente = cliente;
            }

            pedido.NumeroPedido = dados.NumeroPedido;
            pedido.Status = Models.Enums.StatusPedido.EmProcessamento;
            pedido.DataCompra = DateTime.Now;
            pedido.FormaPagamento = Models.Enums.FormaPagamento.Credito;


            pedido.SubTotalProdutos = dados.SubTotalProdutos;
            pedido.ApelidoEnderecoEntrega = dados.ApelidoEnderecoEntrega;
            Endereco endereco = (Endereco)dal.ConsultarId(new Endereco { Id = dados.IdEnderecoEntrega });

            pedido.EnderecoEntrega = endereco.Apelido + " - " + endereco.Logradouro + ", " + endereco.Numero + ", " + endereco.Complemento + ", "
               + endereco.Bairro + ", " + endereco.Cidade.Descricao + " - " + endereco.Cidade.Estado.Descricao + " - " + endereco.Cep;

            pedido.ValorFrete = dados.ValorFrete;
            pedido.SubTotalFrete = dados.SubTotalFrete;
            Cupom cupom = (Cupom)dal.ConsultarId(new Cupom { Id = dados.IdCupom });

            pedido.Cupom = cupom;
            pedido.SubTotalCupom = dados.SubTotalCupom;
            pedido.ValorTotal = dados.valorTotal;

            pedido.NumeroCartoesUsados = dados.CartoesUsados;
            pedido.Cartao1Apelido = dados.Cartao1Texto;
            pedido.Cartao1Valor = dados.Cartao1Valor;
            pedido.Parcelamento1Valor = dados.Parcelamento1;

            if (pedido.NumeroCartoesUsados == 2)
            {
                pedido.Cartao2Apelido = dados.Cartao2Texto;
                pedido.Cartao2Valor = dados.Cartao2Valor;
                pedido.Parcelamento2Valor = dados.Parcelamento2;
            }            

            dal.Cadastrar(pedido);
            
            foreach (var item in pedido.Produtos)
            {
                item.PedidoId = pedido.Id;
                dal.Cadastrar(item);
            }

            LimparCarrinhoPedido(pedido);

            return pedido;
        }

        private void LimparCarrinhoPedido(Pedido pedido)
        {
           
            Carrinho carrinho =  dal.BuscarCarrinho(pedido.Cliente.Id);
            foreach (var produtoEstoque in carrinho.Produtos)
            {
                foreach (var produtoComprado in pedido.Produtos)
                {
                    if(produtoComprado.ProdutoEstoqueId == produtoEstoque.Id)
                    {
                        produtoEstoque.Quantidade -= produtoComprado.Quantidade;

                        if (produtoEstoque.Quantidade == 0)
                            produtoEstoque.Status = Status.Inativo;

                        dal.Alterar(produtoEstoque);

                        
                    }
                }
                
                string conf = RemoverCarrinho(produtoEstoque, pedido.Cliente.Id);
            }

            if(pedido.Cupom != null)
            {
                pedido.Cupom.Status = Status.Inativo;
                dal.Alterar(pedido);
            }
        }

        public Carrinho BuscarCarrinho(int idCliente)
        {
            return dal.BuscarCarrinho(idCliente);
        } 
        
        public List<ProdutoCliente> BuscaProdutoCliente(int idCliente)
        {
            return dal.BuscaProdutoCliente(idCliente);
        }

        public List<Cupom> BuscarCuponsCliente(int idCliente)
        { 
            List<Cupom> cupomLista = new List<Cupom>();
            List<EntidadeDominio> cuponsClientesResult = dal.Consultar(new Cupom { ClienteId = idCliente });
            List<CupomCliente> cupomClientes = new List<CupomCliente>();

            foreach (var item in cuponsClientesResult)
            {
                cupomLista.Add((Cupom)item);
            }   

            return cupomLista;
        }

        public List<Pedido> ConsultarFiltroPedidosAdmin(Pedido pedido)
        {
            return dal.ConsultarFiltroPedidoAdmin(pedido);
        }

        public List<Troca> ConsultarFiltroTrocasAdmin(Troca troca)
        {
            return dal.ConsultarFiltroTrocasAdmin(troca);
        }

    }
}
