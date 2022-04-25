using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RaellShoes.Data;
using RaellShoes.Facadee;
using RaellShoes.Models;
using RaellShoes.Models.Administrador;
using RaellShoes.Models.Clientes;
using RaellShoes.Models.NN;
using RaellShoes.Models.ViewModel;

namespace RaellShoes.Controllers
{
    public class ClientesController : Controller
    {
        private readonly DataBaseContext dbContext;
        private readonly Facade facade;

        public ClientesController(DataBaseContext dbContext)
        {
            this.dbContext = dbContext;
            facade = new Facade(dbContext);
        }


        public IActionResult Index(LoginViewModel cliente)
        {
            int idLogado = 0;
            if (HttpContext.Session.GetInt32("UsuarioId") != null)
                idLogado = (int)HttpContext.Session.GetInt32("UsuarioId");

            if (idLogado > 0)
            {
                return View(cliente);
            }
            else
                return RedirectToAction("Login", "Home");
           
        }

        //**************************PERFIL**************************
        public IActionResult MeuPerfil()
        { 
            int idLogado = 0;
            if(HttpContext.Session.GetInt32("UsuarioId") != null)
                idLogado = (int)HttpContext.Session.GetInt32("UsuarioId");
            
            if(idLogado > 0)
            {
                Cliente cliente = new Cliente { Id = idLogado };
                Cliente clienteBanco = (Cliente)facade.ConsultarId(cliente);

                if (clienteBanco == null) 
                    return RedirectToAction("Index");

                return View(clienteBanco); 

            }else
                return RedirectToAction("Login", "Home");
          
        }

        [HttpPost]
        public IActionResult AlterarPerfil(Cliente cliente)
        {             
            string confirmacao = facade.Alterar(cliente);            

            if (confirmacao == null) 
                return View("MeuPerfil", cliente);

            return RedirectToAction(nameof(Error), new { message = confirmacao });
        }

        [HttpPost]
        public IActionResult ExcluirPerfil(Cliente cliente)
        {
            string confirmacao = facade.Excluir(cliente);

            if (confirmacao == null) 
                return RedirectToAction("Index", "Home");

            return RedirectToAction(nameof(Error), new { message = confirmacao });
        }



        //**************************ENDEREÇOS**************************        
        public IActionResult MeusEnderecos()
        {
            int idLogado = 0;
            if (HttpContext.Session.GetInt32("UsuarioId") != null)
                idLogado = (int)HttpContext.Session.GetInt32("UsuarioId");

            if (idLogado > 0)
            {
                Endereco endereco = new Endereco() { Id = idLogado };
                List<EntidadeDominio> resultEnderecos = facade.Consultar(endereco);
                EnderecoViewModel enderecoViewModel = new EnderecoViewModel();

                if (resultEnderecos != null)
                {
                    List<Endereco> enderecos = new List<Endereco>();
                    foreach (var item in resultEnderecos)
                    {
                        enderecos.Add((Endereco)item);
                    }

                    enderecoViewModel.Enderecos = enderecos;

                    return View(enderecoViewModel);
                }
                return View(enderecoViewModel);
            }
            else
                return RedirectToAction("Login", "Home");

        }

       
        [HttpPost]
        public IActionResult CadastrarEndereco(Endereco endereco)
        {
            int idLogado = 0;
            if (HttpContext.Session.GetInt32("UsuarioId") != null)
                idLogado = (int)HttpContext.Session.GetInt32("UsuarioId");

            if (idLogado > 0)
            {               
                endereco.ClienteId = idLogado;
                string confirmacao = facade.Cadastrar(endereco);
                //Falta redirecionar para tela de erro caso não cadastre
                return RedirectToAction("MeusEnderecos");
            }
            else
                return RedirectToAction("Login", "Home");
        }        

        [HttpPost]
        public IActionResult AlterarEndereco(Endereco endereco)
        {
            string confirmacao = facade.Alterar(endereco);

            if (confirmacao == null)
                return RedirectToAction("MeusEnderecos");

            return RedirectToAction(nameof(Error), new { message = confirmacao });
        }


        public IActionResult ExcluirEndereco(Endereco endereco)
        {
            string confirmacao = facade.Excluir(endereco);

            if (confirmacao == null) 
                return RedirectToAction("MeusEnderecos");

            return RedirectToAction(nameof(Error), new { message = confirmacao });
        }


        //**************************CARTÕES**************************
        public IActionResult MeusCartoes()
        {
            int idLogado = 0;
            if (HttpContext.Session.GetInt32("UsuarioId") != null)
                idLogado = (int)HttpContext.Session.GetInt32("UsuarioId");

            if (idLogado > 0)
            {
                Cartao cartao = new Cartao() { Id = idLogado };
                List<EntidadeDominio> resultEnderecos = facade.Consultar(cartao);
                CartaoViewModel cartaoViewModel = new CartaoViewModel();

                if (resultEnderecos != null)
                {
                    List<Cartao> cartoes = new List<Cartao>();
                    foreach (var item in resultEnderecos)
                    {
                        cartoes.Add((Cartao)item);
                    }

                    cartaoViewModel.Cartoes = cartoes;
                    return View(cartaoViewModel);
                }
                return View(cartaoViewModel);
            }
            else
                return RedirectToAction("Login", "Home");
        }


        public IActionResult CadastrarCartao()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarCartao(Cartao cartao)
        {
            int idLogado = 0;
            if (HttpContext.Session.GetInt32("UsuarioId") != null)
                idLogado = (int)HttpContext.Session.GetInt32("UsuarioId");

            if (idLogado > 0)
            {
                cartao.ClienteId = idLogado;
                string confirmacao = facade.Cadastrar(cartao);
                //Falta redirecionar caso não cadastre
                return RedirectToAction("MeusCartoes");
            }
            else
                return RedirectToAction("Login", "Home");
            
        }

        [HttpPost]
        public IActionResult AlterarCartao(Cartao cartao)
        {
            string confirmacao = facade.Alterar(cartao);
            if (confirmacao == null) return RedirectToAction("MeusCartoes");

            return RedirectToAction(nameof(Error), new { message = confirmacao });
        }

        public IActionResult ExcluirCartao(Cartao cartao)
        {
            string confirmacao = facade.Excluir(cartao);
            if (confirmacao == null) return RedirectToAction("MeusCartoes");

            return RedirectToAction(nameof(Error), new { message = confirmacao });
        }

        //**************************PRODUTO**************************

        public IActionResult ProcurarProduto()
        {
            int idLogado = 0;
            if (HttpContext.Session.GetInt32("UsuarioId") != null)
                idLogado = (int)HttpContext.Session.GetInt32("UsuarioId");

            if (idLogado > 0)
            {
                return View();
            }
            else
                return RedirectToAction("Login", "Home");
            
        }

        [HttpPost]
       
        public IActionResult FiltrarProdutos(Produto produto)
        {
            var listaProdutos = facade.ConsultarFiltroProdutos(produto);
            return View("FiltroProdutos", listaProdutos);
        }

        public IActionResult DetalhesProduto(Produto produto)
        {
            Produto produtoResult = (Produto)facade.ConsultarId(produto);
            return View(produtoResult);
        }


        //**************************SENHA**************************
        public IActionResult EsqueceuSenha()
        {
            return View();
        }

        public IActionResult TrocarSenha()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TrocarSenha(TrocarSenhaViewModel model)
        {
            return RedirectToAction("Login", "Home");
        }

        //**************************CARRINHO**************************
        //Exibir o carrinho              
        public IActionResult Carrinho()
        {
            int idLogado = 0;
            if (HttpContext.Session.GetInt32("UsuarioId") != null)
                idLogado = (int)HttpContext.Session.GetInt32("UsuarioId");

            if (idLogado > 0)
            {
                Carrinho carrinho = facade.BuscarCarrinho(idLogado);
                List<ProdutoCliente> produtoClientes = facade.BuscaProdutoCliente(idLogado);

                //Setar o campo QuantidadeCarrinho em Produto
                foreach (var produto in carrinho.Produtos)
                {
                    foreach (var produtoCliente in produtoClientes)
                    {
                        if (produto.Id == produtoCliente.ProdutoId)
                        {
                            produto.QuantidadeCarrinho = produtoCliente.Quantidade;
                        }
                    }
                }
                //Setar o campo ValorSubtotal do Produto com base na quantidade
                foreach (var item in carrinho.Produtos)
                {
                    item.ValorSubtotal = item.Valor * item.QuantidadeCarrinho;
                }

                List<EntidadeDominio> enderecosResult = facade.Consultar(new Endereco { Id = idLogado });
                List<Endereco> enderecos = new List<Endereco>();
                foreach (var item in enderecosResult)
                {
                    enderecos.Add((Endereco)item);
                }

                List<EntidadeDominio> cartoesResult = facade.Consultar(new Cartao { Id = idLogado });
                List<Cartao> cartoes = new List<Cartao>();
                foreach (var item in cartoesResult)
                {
                    cartoes.Add((Cartao)item);
                }

                List<Cupom> cupons = facade.BuscarCuponsCliente(idLogado);


                CarrinhoViewModel carrinhoViewModel = new CarrinhoViewModel()
                {
                    Carrinho = carrinho,
                    Enderecos = enderecos,
                    Cartoes = cartoes,
                    Cupons = cupons
                };

                return View(carrinhoViewModel);
            }
            else
                return RedirectToAction("Login", "Home");

        }


        [HttpPost]
        //Atualizar a edição de produtos do carrinho
        public IActionResult AtualizarCarrinho(string data)
        {
            int idLogado = 0;
            if (HttpContext.Session.GetInt32("UsuarioId") != null)
                idLogado = (int)HttpContext.Session.GetInt32("UsuarioId");

            if (idLogado > 0)
            {
                ProdutoCliente produtoCliente = JsonConvert.DeserializeObject<ProdutoCliente>(data);
                produtoCliente.ClienteId = idLogado;

                List<EntidadeDominio> listaProdutoCliente = facade.Consultar(produtoCliente);

                foreach (var item in listaProdutoCliente)
                {
                    produtoCliente.Id = item.Id;
                }

                return RedirectToAction("ExtensaoAtualizarCarrinho", produtoCliente);
            }
            else
                return RedirectToAction("Index");
        }

        public IActionResult ExtensaoAtualizarCarrinho(ProdutoCliente produtoCliente)
        {
            string conf = facade.Alterar(produtoCliente);

            return View("carrinho");
        }


        //Adicionar Produto no carrinho
        public IActionResult ProdutoCarrinho(Produto produto)
        {
            int idLogado = 0;
            if (HttpContext.Session.GetInt32("UsuarioId") != null)
                idLogado = (int)HttpContext.Session.GetInt32("UsuarioId");

            if (idLogado > 0)
            {
                string confirmacao = facade.ProdutoCarrinho(produto, idLogado);

                if (confirmacao != null)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("Carrinho");
                }
            }
            else
                return RedirectToAction("Login", "Home");
        }

        //Remover produto do carrinho
        public IActionResult RemoverProduto(Produto produto)
        {
            int idLogado = 0;
            if (HttpContext.Session.GetInt32("UsuarioId") != null)
                idLogado = (int)HttpContext.Session.GetInt32("UsuarioId");

            if (idLogado > 0)
            {
                string confirmacao = facade.RemoverCarrinho(produto, idLogado);

                return RedirectToAction("Carrinho");
            }
            else
                return RedirectToAction("Login", "Home");
        }

        
        

        [HttpPost]
        public IActionResult CadastrarEnderecoCarrinho(Endereco endereco)
        {
            int idLogado = 0;
            if (HttpContext.Session.GetInt32("UsuarioId") != null)
                idLogado = (int)HttpContext.Session.GetInt32("UsuarioId");

            if (idLogado > 0)
            {
                endereco.ClienteId = idLogado;
                string confirmacao = facade.Cadastrar(endereco);
                //Falta redirecionar para tela de erro caso não cadastre
                return RedirectToAction("Carrinho");
            }
            else
                return RedirectToAction("Index");
        }
        
        [HttpPost]
        public IActionResult CadastrarCartaoCarrinho(Cartao cartao)
        {
            int idLogado = 0;
            if (HttpContext.Session.GetInt32("UsuarioId") != null)
                idLogado = (int)HttpContext.Session.GetInt32("UsuarioId");

            if (idLogado > 0)
            {
                cartao.ClienteId = idLogado;
                string confirmacao = facade.Cadastrar(cartao);
                //Falta redirecionar caso não cadastre
                return RedirectToAction("Carrinho");
            }
            else
                return RedirectToAction("Index");
           
        }


        //**************************PEDIDOS**************************
                
        public IActionResult RegistrarVenda(string data)
        {
            System.Threading.Thread.Sleep(5000);
            int idLogado = 0;
            if (HttpContext.Session.GetInt32("UsuarioId") != null)
                idLogado = (int)HttpContext.Session.GetInt32("UsuarioId");

            if (idLogado > 0)
            {
                DadosPedidoViewModel dados = JsonConvert.DeserializeObject<DadosPedidoViewModel>(data);
                List<ProdutoCliente> produtoClientes = facade.BuscaProdutoCliente(idLogado);

                Pedido pedido = facade.RegistrarVenda(dados, produtoClientes);

                if(pedido.Cliente != null)
                    pedido.ClienteId = pedido.Cliente.Id;

                if(pedido.Cupom != null)
                    pedido.CupomId = pedido.Cupom.Id;

                return RedirectToAction("PedidoRealizado", pedido);
            }
            else
                return RedirectToAction("Login");          

            
        }


        public IActionResult PedidoRealizado(Pedido pedido)
        {
            if (pedido.Id > 0)
            {
                if (pedido.CupomId > 0)
                    pedido.Cupom = (Cupom)facade.ConsultarId(new Cupom { Id = pedido.CupomId });

                if (pedido.ClienteId > 0)
                {
                    pedido.Cliente = (Cliente)facade.ConsultarId(new Cliente { Id = pedido.ClienteId });
                    return View("PedidoRealizado", pedido);
                }
                else
                    return View("Index");

            }
            return View("Index");
        }

        public IActionResult MeusPedidos()
        {
            int idLogado = 0;
            if (HttpContext.Session.GetInt32("UsuarioId") != null)
                idLogado = (int)HttpContext.Session.GetInt32("UsuarioId");

            if (idLogado > 0)
            {                
                List<EntidadeDominio> listaPedidos = facade.Consultar(new Pedido { ClienteId = idLogado });
                List<Pedido> pedidos = new List<Pedido>();
                List<ProdutoPedido> produtos = new List<ProdutoPedido>();

                foreach (var item in listaPedidos)
                {
                    pedidos.Add((Pedido)item);

                    List<EntidadeDominio> listaProdutos = facade.Consultar(new ProdutoPedido { PedidoId = item.Id });
                    foreach (var produto in listaProdutos)
                    {
                        produtos.Add((ProdutoPedido)produto);
                    }                    
                }

                PedidoViewModel pedidoViewModel = new PedidoViewModel { Pedidos = pedidos, ProdutosPedidos = produtos };

                return View(pedidoViewModel);
            }
            else
                return RedirectToAction("Login");

        }

        //**************************TROCA*************************
        public IActionResult SolicitacaoTroca(Troca troca)
        {
            troca.DataSolicitacao = DateTime.Now;
            troca.Status = Models.Enums.StatusPedido.EmTroca;

            ProdutoPedido produto = (ProdutoPedido)facade.ConsultarId(new ProdutoPedido { Id = troca.IddoProduto });
            Pedido pedido = (Pedido)facade.ConsultarId(new Pedido { Id = produto.PedidoId });            

            troca.Produto = produto;
            troca.Pedido = pedido;
            troca.IddoCliente = pedido.Cliente.Id;

            string conf = facade.Cadastrar(troca);

            return View("Troca");
        }

        public IActionResult Troca()
        {
            int idLogado = 0;
            if (HttpContext.Session.GetInt32("UsuarioId") != null)
                idLogado = (int)HttpContext.Session.GetInt32("UsuarioId");

            if (idLogado > 0)
            {
                List<EntidadeDominio> listaTrocas = facade.Consultar(new Troca { IddoCliente = idLogado });
                List<Troca> trocas = new List<Troca>();

                foreach (var item in listaTrocas)
                {
                    trocas.Add((Troca)item);  
                }
                
                TrocaViewModel trocaViewModel = new TrocaViewModel { Trocas = trocas};

                return View(trocaViewModel);
            }
            else
                return RedirectToAction("Login");
            
        }

        
        //**************************SENHA*************************

        [HttpPost]
        public IActionResult AlterarSenha(TrocarSenhaViewModel senha)
        {
           
            return View();
        }
        
        //**************************ERRO*************************
        public IActionResult Error(String message)
        {
            var viewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(viewModel);
        }

    }
}

