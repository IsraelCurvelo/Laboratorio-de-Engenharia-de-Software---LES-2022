﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RaellShoes.Data;
using RaellShoes.Facadee;
using RaellShoes.Models;
using RaellShoes.Models.Administrador;
using RaellShoes.Models.Clientes;
using RaellShoes.Models.ViewModel;
using RaellShoes.Strategy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace RaellShoes.Controllers
{
    public class AdministradorController : Controller
    {
        private readonly DataBaseContext dbContext;
        private readonly Facade facade;

        public AdministradorController(DataBaseContext dbContext)
        {
            this.dbContext = dbContext;
            facade = new Facade(dbContext);
        }

        #region INDEX

        public IActionResult Index(LoginViewModel admin)
        {
            int idLogado = 0;
            if (HttpContext.Session.GetInt32("UsuarioId") != null)
                idLogado = (int)HttpContext.Session.GetInt32("UsuarioId");

            Cliente cliente = (Cliente)facade.ConsultarId(new Cliente { Id = idLogado });

            if (idLogado > 0)
            {

                if (!cliente.Usuario.Admin)
                {
                    return RedirectToAction("Index", "home");
                }
                
                List<Categoria> ListaCategorias = facade.ConsultarCategoriasDash();

                DashViewModel dashViewModel = new DashViewModel() { MostrarGrafico = false, Categorias = ListaCategorias };               

                return View(dashViewModel);
            }
            else
                return RedirectToAction("Login", "Home");           
        }

        #endregion

        #region PEDIDOS

        public IActionResult Pedidos()
        {
            int idLogado = 0;
            if (HttpContext.Session.GetInt32("UsuarioId") != null)
                idLogado = (int)HttpContext.Session.GetInt32("UsuarioId");

            Cliente cliente = (Cliente)facade.ConsultarId(new Cliente { Id = idLogado });

            if (idLogado > 0)
            {

                if (!cliente.Usuario.Admin)
                {
                    return RedirectToAction("Index", "home");
                }
                PedidoViewModel pedido = new PedidoViewModel();
                return View(pedido);
            }
            else
                return RedirectToAction("Login", "Home");


        }

        [HttpPost]
        public IActionResult Pedidos(PedidoViewModel pedidoViewModel)
        {
            return View(pedidoViewModel);

        }

        [HttpPost]
        public IActionResult FiltrarPedidosAdmin(Pedido pedido)
        {
            List<Pedido> pedidos = facade.ConsultarFiltroPedidosAdmin(pedido);

            PedidoViewModel pedidoViewModel = new PedidoViewModel { Pedidos = pedidos };
            
            return View("Pedidos", pedidoViewModel);

        }

        public IActionResult DetalhesPedido(Pedido pedidoProcurar)
        {
            Pedido pedido = (Pedido)facade.ConsultarId(pedidoProcurar);           
            List<EntidadeDominio> listaProdutos = facade.Consultar(new ProdutoPedido { PedidoId = pedido.Id });
            List<ProdutoPedido> produtos = new List<ProdutoPedido>();

            foreach (var item in listaProdutos)
            {
                produtos.Add((ProdutoPedido) item);
            }

            PedidoViewModel pedidoViewModel = new PedidoViewModel { Pedido = pedido, ProdutosPedidos = produtos };
            return View(pedidoViewModel);
        } 
        
        public IActionResult AprovarPedido(Pedido pedidoSolicitacao)
        {
            Pedido pedido = (Pedido)facade.ConsultarId(pedidoSolicitacao);
            pedido.Status = Models.Enums.StatusPedido.EmTransporte;
            string conf = facade.Alterar(pedido);

            return RedirectToAction("DetalhesPedido", pedido);
        }

        public IActionResult ReprovarPedido(Pedido pedidoSolicitacao)
        {
            Pedido pedido = (Pedido)facade.ConsultarId(pedidoSolicitacao);
            pedido.Status = Models.Enums.StatusPedido.Reprovado;
            string conf = facade.Alterar(pedido);

            return RedirectToAction("DetalhesPedido", pedido);
        }

        public IActionResult AprovarEntrega(Pedido pedidoSolicitacao)
        {
            Pedido pedido = (Pedido)facade.ConsultarId(pedidoSolicitacao);
            pedido.Status = Models.Enums.StatusPedido.Entregue;
            string conf = facade.Alterar(pedido);

            return RedirectToAction("DetalhesPedido", pedido);
        }

        #endregion

        #region TROCA

        public IActionResult VerSolicitacaoTroca(Pedido pedidoSolicitacao)
        {           
            return View();
        }

        public IActionResult Trocas()
        {
            int idLogado = 0;
            if (HttpContext.Session.GetInt32("UsuarioId") != null)
                idLogado = (int)HttpContext.Session.GetInt32("UsuarioId");

            Cliente cliente = (Cliente)facade.ConsultarId(new Cliente { Id = idLogado });

            if (idLogado > 0)
            {

                if (!cliente.Usuario.Admin)
                {
                    return RedirectToAction("Index", "home");
                }
                TrocaViewModel troca = new TrocaViewModel();
                return View(troca);
            }
            else
                return RedirectToAction("Login", "Home");
        }

        [HttpPost]
        public IActionResult Trocas(TrocaViewModel trocaViewModel)
        {
            int idLogado = 0;
            if (HttpContext.Session.GetInt32("UsuarioId") != null)
                idLogado = (int)HttpContext.Session.GetInt32("UsuarioId");

            Cliente cliente = (Cliente)facade.ConsultarId(new Cliente { Id = idLogado });

            if (idLogado > 0)
            {

                if (!cliente.Usuario.Admin)
                {
                    return RedirectToAction("Index", "home");
                }
                TrocaViewModel troca = new TrocaViewModel();
                return View(troca);
            }
            else
                return RedirectToAction("Login", "Home");
        }

        [HttpPost]
        public IActionResult FiltrarTrocasAdmin(Troca troca)
        {
            List<Troca> trocas = facade.ConsultarFiltroTrocasAdmin(troca);

            TrocaViewModel trocaViewModel = new TrocaViewModel { Trocas = trocas };

            return View("Trocas", trocaViewModel);
        }

        public IActionResult DetalhesTroca(Troca trocaProcurar)
        {
            Troca troca = (Troca)facade.ConsultarId(trocaProcurar);
            return View(troca);
        }

        public IActionResult AutorizarTroca(Troca trocaSolicitacao)
        {
            Troca troca = (Troca)facade.ConsultarId(trocaSolicitacao);
            troca.Status = Models.Enums.StatusPedido.TrocaAutorizada;
            string conf = facade.Alterar(troca);

            return RedirectToAction("DetalhesTroca", troca);            
        }

        public IActionResult ReprovarTroca(Troca trocaSolicitacao)
        {
            Troca troca = (Troca)facade.ConsultarId(trocaSolicitacao);
            troca.Status = Models.Enums.StatusPedido.Reprovado;
            string conf = facade.Alterar(troca);

            return RedirectToAction("DetalhesTroca", troca);
        }

        public IActionResult ReceberProdutoTrocaSim(Troca trocaSolicitacao)
        {
            Troca troca = (Troca)facade.ConsultarId(trocaSolicitacao);
            troca.Status = Models.Enums.StatusPedido.ProdutoRecebido;
            string conf = facade.Alterar(troca);

            Produto produto = (Produto)facade.ConsultarId(new Produto { Id = troca.Produto.ProdutoEstoqueId });
            produto.Quantidade += troca.Produto.Quantidade;
            string confirm = facade.Alterar(produto);

            //FALTA GERAR CUPOM SE FOI SELECIONADO ESSA OPCAO[
            double valorProduto = produto.Valor;
            string valorStringProduto = valorProduto.ToString("#########0.00");
            valorStringProduto = valorStringProduto.Replace(",", ".");
            Cupom cupom = new Cupom
            {
                Status = Models.Enums.Status.Ativo,
                DataCadastro = DateTime.Now,
                Codigo = "TROCA_"+troca.Pedido.Cliente.Cpf + valorStringProduto,
                Desconto = valorProduto,
                ClienteId = troca.IddoCliente,
                Promocional = false,
                Descricao = valorStringProduto + " CUPOM DE TROCA" 
            };

            string a = facade.Cadastrar(cupom);


            return RedirectToAction("DetalhesTroca", troca);
        }

        public IActionResult ReceberProdutoTrocaNao(Troca trocaSolicitacao)
        {
            Troca troca = (Troca)facade.ConsultarId(trocaSolicitacao);
            troca.Status = Models.Enums.StatusPedido.ProdutoRecebido;
            string conf = facade.Alterar(troca);
            
            //FALTA GERAR CUPOM SE FOI SELECIONADO ESSA OPCAO

            return RedirectToAction("DetalhesTroca", troca);
        }

        public IActionResult ConfirmarEntregaProdutoTroca(Troca trocaSolicitacao)
        {
            Troca troca = (Troca)facade.ConsultarId(trocaSolicitacao);
            troca.Status = Models.Enums.StatusPedido.Trocado;
            string conf = facade.Alterar(troca);

            return RedirectToAction("DetalhesTroca", troca);
        }

        #endregion

        #region PRODUTOS
        public IActionResult Produtos()
        {
            List<EntidadeDominio> entidadeDominioCategorias = facade.Consultar(new Categoria());
            List<Categoria> categorias = new List<Categoria>();

            foreach (var item in entidadeDominioCategorias)
            {
                categorias.Add((Categoria)item);
            }

            List<EntidadeDominio> entidadeDominioGrupo = facade.Consultar(new GrupoPrecificacao());
            List<GrupoPrecificacao> gruposPrecificacao = new List<GrupoPrecificacao>();

            foreach (var item in entidadeDominioGrupo)
            {
                gruposPrecificacao.Add((GrupoPrecificacao)item);
            }

            List<EntidadeDominio> entidadeDominioFornecedor = facade.Consultar(new Fornecedor());
            List<Fornecedor> fornecedores = new List<Fornecedor>();

            foreach (var item in entidadeDominioFornecedor)
            {
                fornecedores.Add((Fornecedor)item);
            }

            return View(new ProdutoViewModel { Categorias = categorias, Fornecedores = fornecedores, GruposPrecificacao = gruposPrecificacao });
        }

        [HttpPost]
        public IActionResult NovoProduto(Produto produto)
        {
            ValidarDadosProduto validarDadosProduto = new ValidarDadosProduto();
            string confirmacaoDadosProduto = validarDadosProduto.Processar(produto);

            if(confirmacaoDadosProduto == null)
            {
                Categoria categoria = (Categoria)facade.ConsultarId(produto.Categoria);
                GrupoPrecificacao grupoPrecificacao = (GrupoPrecificacao)facade.ConsultarId(produto.GrupoPrecificacao);
                Fornecedor fornecedor = (Fornecedor)facade.ConsultarId(produto.Fornecedor);

                produto.Categoria = categoria;
                produto.GrupoPrecificacao = grupoPrecificacao;
                produto.Fornecedor = fornecedor;

                string confSalvar = facade.Cadastrar(produto);
                return RedirectToAction("Produtos");
            }
            else
            {
                return RedirectToAction("ErroCadastro", "Home", confirmacaoDadosProduto);
            }              
        }

        [HttpPost]
        public IActionResult ProcurarProduto(Produto produto)
        {
            var listaProdutos = facade.ConsultarFiltroProdutosAdmin(produto);
            List<Produto> produtos = new List<Produto>();

            foreach (var item in listaProdutos)
            {
                produtos.Add(item);
            }

            List<EntidadeDominio> entidadeDominioCategorias = facade.Consultar(new Categoria());
            List<Categoria> categorias = new List<Categoria>();

            foreach (var item in entidadeDominioCategorias)
            {
                categorias.Add((Categoria)item);
            }

            List<EntidadeDominio> entidadeDominioGrupo = facade.Consultar(new GrupoPrecificacao());
            List<GrupoPrecificacao> gruposPrecificacao = new List<GrupoPrecificacao>();

            foreach (var item in entidadeDominioGrupo)
            {
                gruposPrecificacao.Add((GrupoPrecificacao)item);
            }

            List<EntidadeDominio> entidadeDominioFornecedor = facade.Consultar(new Fornecedor());
            List<Fornecedor> fornecedores = new List<Fornecedor>();

            foreach (var item in entidadeDominioFornecedor)
            {
                fornecedores.Add((Fornecedor)item);
            }

            ProdutoViewModel produtoViewModel = new ProdutoViewModel();
            produtoViewModel.Categorias = categorias;
            produtoViewModel.Fornecedores = fornecedores;
            produtoViewModel.GruposPrecificacao = gruposPrecificacao;
            produtoViewModel.Produtos = produtos;

            return View("Produtos", produtoViewModel);

           
        }

        public IActionResult AtivarProduto(Produto produto)
        {
            Produto ativarProduto = (Produto)facade.ConsultarId(produto);
            ativarProduto.Status = Models.Enums.Status.Ativo;

            string conf = facade.Alterar(ativarProduto);

            return RedirectToAction("Produtos");
        }

        public IActionResult InativarProduto(Produto produto)
        {
            Produto ativarProduto = (Produto)facade.ConsultarId(produto);
            ativarProduto.Status = Models.Enums.Status.Inativo;

            string conf = facade.Alterar(ativarProduto);

            return RedirectToAction("Produtos");
        }

       
        public IActionResult DetalhesProduto(Produto produto)
        {
            Produto detalhesProduto = (Produto)facade.ConsultarId(produto);

            List<EntidadeDominio> entidadeDominioCategorias = facade.Consultar(new Categoria());
            List<Categoria> categorias = new List<Categoria>();

            foreach (var item in entidadeDominioCategorias)
            {
                categorias.Add((Categoria)item);
            }

            List<EntidadeDominio> entidadeDominioGrupo = facade.Consultar(new GrupoPrecificacao());
            List<GrupoPrecificacao> gruposPrecificacao = new List<GrupoPrecificacao>();

            foreach (var item in entidadeDominioGrupo)
            {
                gruposPrecificacao.Add((GrupoPrecificacao)item);
            }

            List<EntidadeDominio> entidadeDominioFornecedor = facade.Consultar(new Fornecedor());
            List<Fornecedor> fornecedores = new List<Fornecedor>();

            foreach (var item in entidadeDominioFornecedor)
            {
                fornecedores.Add((Fornecedor)item);
            }

            ProdutoViewModel produtoViewModel = new ProdutoViewModel();
            produtoViewModel.Categorias = categorias;
            produtoViewModel.Fornecedores = fornecedores;
            produtoViewModel.GruposPrecificacao = gruposPrecificacao;
            produtoViewModel.Produto = detalhesProduto;

            return View(produtoViewModel);            
        }

        [HttpPost]
        public IActionResult AlterarProduto(Produto produto)
        {            
            ValidarDadosProduto validar = new ValidarDadosProduto();
            string confirmacao = validar.Processar(produto);
            if(confirmacao == null)
            {
                Categoria categoria = (Categoria)facade.ConsultarId(produto.Categoria);
                Fornecedor fornecedor = (Fornecedor)facade.ConsultarId(produto.Fornecedor);
                GrupoPrecificacao grupo = (GrupoPrecificacao)facade.ConsultarId(produto.GrupoPrecificacao);
                produto.Categoria = categoria;
                produto.Fornecedor = fornecedor;
                produto.GrupoPrecificacao = grupo;

                string conf = facade.Alterar(produto);
            }
            return RedirectToAction("DetalhesProduto", produto);
        }

     
        public IActionResult ExcluirProduto(Produto produto)
        {
            Produto produtoBanco = (Produto)facade.ConsultarId(produto);
            string conf = facade.Excluir(produtoBanco);

            return RedirectToAction("Produtos");
        }

        #endregion

        #region CLIENTES

        public IActionResult Clientes()
        {
            return View(new ClienteViewModel());            
        }

        [HttpPost]
        public IActionResult ProcurarCliente(Cliente cliente)
        {
            List<Cliente> clientes = facade.ConsultarFiltroClienteAdmin(cliente);
            return View("Clientes", new ClienteViewModel() { Clientes = clientes });
        }

        public IActionResult AtivarCliente(Cliente cliente)
        {
            Cliente clienteAtualizar = (Cliente)facade.ConsultarId(cliente);
            clienteAtualizar.Status = true;

            string conf = facade.Alterar(clienteAtualizar);

            return RedirectToAction("Clientes");
        }
                
        public IActionResult InativarCliente(Cliente cliente)
        {
            Cliente clienteAtualizar = (Cliente)facade.ConsultarId(cliente);
            clienteAtualizar.Status = false;

            string conf = facade.Alterar(clienteAtualizar);

            return RedirectToAction("Clientes");
        }
                
        public IActionResult DetalhesCliente(Cliente cliente)
        {
            Cliente clienteRetornado = (Cliente)facade.ConsultarId(cliente);
            return View(clienteRetornado);
        }

        #endregion

        #region DASH
        [HttpPost]
        public IActionResult GerarGrafico(DashViewModel dashViewModel)
        {         
            dashViewModel.MostrarGrafico = true; 
            return View("Index", dashViewModel);
        }

        //Retorna dados JSON para o gráfico     

        [HttpPost]
        public JsonResult JsonGrafico(DashViewModel dashViewModel)
        {
            /*
            var lista = new List<DashVendasPeriodo>();
            lista.Add(new DashVendasPeriodo { Data = String.Format("{0:dd/MM/yyyy}", "2022, 05,01",) Casual = 330, Corrida = 390,Treino = 200, Skate = 100 });
            lista.Add(new DashVendasPeriodo { Data = String.Format("{0:dd/MM/yyyy}", "2022, 05,06",) Casual = 320, Corrida = 380,Treino = 300, Skate = 120 });
            lista.Add(new DashVendasPeriodo { Data = String.Format("{0:dd/MM/yyyy}", "2022, 05, 09"), Casual = 310, Corrida = 360, Treino = 560, Skate = 190 });
            lista.Add(new DashVendasPeriodo { Data = String.Format("{0:dd/MM/yyyy}", "2022, 05, 10"), Casual = 380, Corrida = 320, Treino = 593, Skate = 220 });
            lista.Add(new DashVendasPeriodo { Data = String.Format("{0:dd/MM/yyyy}", "2022, 05, 11"), Casual = 390, Corrida = 380, Treino = 530, Skate = 400 });
            */            
            var lista = new List<DashVendasPeriodo>();
            var listaPedidos = facade.GerarGrafico(dashViewModel);
            List<ProdutoPedido> listaProdutos = new List<ProdutoPedido>();
            bool conf = false;

            foreach (var item in listaPedidos)
            {
                var listaProdutosDoPedido = facade.ConsultarProdutosDoPedido(item);
                foreach (var produto in listaProdutosDoPedido)
                {
                    
                    if (produto.Categoria.Nome.ToLower() == "casual")
                    {
                        if (dashViewModel.Casual)
                        {
                            if (lista.Count > 0)
                            {
                                foreach (var grafico in lista)
                                {
                                    if (grafico.Data == String.Format("{0:dd/MM/yyyy}", item.DataCompra))
                                    {
                                        grafico.Casual += (int)produto.ValorSubtotal;
                                        conf = false;
                                        continue;
                                    }
                                    else
                                    {
                                        conf = true;
                                    }
                                }
                                if (conf)
                                {
                                    lista.Add(new DashVendasPeriodo { Data = String.Format("{0:dd/MM/yyyy}", item.DataCompra), Casual = (int)produto.ValorSubtotal });
                                    conf = false;
                                }
                            }
                            else
                            {
                                lista.Add(new DashVendasPeriodo { Data = String.Format("{0:dd/MM/yyyy}", item.DataCompra), Casual = (int)produto.ValorSubtotal });
                            }
                        }
                        
                    }
                    else if (produto.Categoria.Nome.ToLower() == "corrida")
                    {
                        if (dashViewModel.Corrida)
                        {
                            if (lista.Count > 0)
                            {
                                foreach (var grafico in lista)
                                {
                                    if (grafico.Data == String.Format("{0:dd/MM/yyyy}", item.DataCompra))
                                    {
                                        grafico.Corrida += (int)produto.ValorSubtotal;
                                        conf = false;
                                        continue;
                                    }
                                    else
                                    {
                                        conf = true;
                                    }
                                }
                                if (conf)
                                {
                                    lista.Add(new DashVendasPeriodo { Data = String.Format("{0:dd/MM/yyyy}", item.DataCompra), Corrida = (int)produto.ValorSubtotal });
                                    conf = false;
                                }
                            }
                            else
                            {
                                lista.Add(new DashVendasPeriodo { Data = String.Format("{0:dd/MM/yyyy}", item.DataCompra), Corrida = (int)produto.ValorSubtotal });
                            }
                        }
                        
                    }
                    else if (produto.Categoria.Nome.ToLower() == "treino")
                    {
                        if (dashViewModel.Treino)
                        {
                            if (lista.Count > 0)
                            {
                                foreach (var grafico in lista)
                                {
                                    if (grafico.Data == String.Format("{0:dd/MM/yyyy}", item.DataCompra))
                                    {
                                        grafico.Treino += (int)produto.ValorSubtotal;
                                        conf = false;
                                        continue;
                                    }
                                    else
                                    {
                                        conf = true;
                                    }
                                }
                                if (conf)
                                {
                                    lista.Add(new DashVendasPeriodo { Data = String.Format("{0:dd/MM/yyyy}", item.DataCompra), Treino = (int)produto.ValorSubtotal });
                                    conf = false;
                                }
                            }
                            else
                            {
                                lista.Add(new DashVendasPeriodo { Data = String.Format("{0:dd/MM/yyyy}", item.DataCompra), Treino = (int)produto.ValorSubtotal });
                            }
                        }
                        
                    }
                    else if (produto.Categoria.Nome.ToLower() == "skate")
                    {
                        if (dashViewModel.Skateboarding)
                        {
                            if (lista.Count > 0)
                            {
                                foreach (var grafico in lista)
                                {
                                    if (grafico.Data == String.Format("{0:dd/MM/yyyy}", item.DataCompra))
                                    {
                                        grafico.Skate += (int)produto.ValorSubtotal;
                                        conf = false;
                                        continue;
                                    }
                                    else
                                    {
                                        conf = true;
                                    }
                                }
                                if (conf)
                                {
                                    lista.Add(new DashVendasPeriodo { Data = String.Format("{0:dd/MM/yyyy}", item.DataCompra), Skate = (int)produto.ValorSubtotal });
                                    conf = false;
                                }
                            }
                            else
                            {
                                lista.Add(new DashVendasPeriodo { Data = String.Format("{0:dd/MM/yyyy}", item.DataCompra), Skate = (int)produto.ValorSubtotal });
                            }
                        }
                        
                    }
                    else if (produto.Categoria.Nome.ToLower() == "basquete")
                    {
                        if (dashViewModel.Basquete)
                        {
                            if (lista.Count > 0)
                            {
                                foreach (var grafico in lista)
                                {
                                    if (grafico.Data == String.Format("{0:dd/MM/yyyy}", item.DataCompra))
                                    {
                                        grafico.Basquete += (int)produto.ValorSubtotal;
                                        conf = false;
                                        continue;
                                    }
                                    else
                                    {
                                        conf = true;
                                    }
                                }
                                if (conf)
                                {
                                    lista.Add(new DashVendasPeriodo { Data = String.Format("{0:dd/MM/yyyy}", item.DataCompra), Basquete = (int)produto.ValorSubtotal });
                                    conf = false;
                                }
                            }
                            else
                            {
                                lista.Add(new DashVendasPeriodo { Data = String.Format("{0:dd/MM/yyyy}", item.DataCompra), Basquete = (int)produto.ValorSubtotal });
                            }
                        }
                    }
                    else if (produto.Categoria.Nome.ToLower() == "esporte")
                    {
                        if (dashViewModel.Esporte)
                        {
                            if (lista.Count > 0)
                            {
                                foreach (var grafico in lista)
                                {
                                    if (grafico.Data == String.Format("{0:dd/MM/yyyy}", item.DataCompra))
                                    {
                                        grafico.Esporte += (int)produto.ValorSubtotal;
                                        conf = false;
                                        continue;
                                    }
                                    else
                                    {
                                        conf = true;
                                    }
                                }
                                if (conf)
                                {
                                    lista.Add(new DashVendasPeriodo { Data = String.Format("{0:dd/MM/yyyy}", item.DataCompra), Esporte = (int)produto.ValorSubtotal });
                                    conf = false;
                                }
                            }
                            else
                            {
                                lista.Add(new DashVendasPeriodo { Data = String.Format("{0:dd/MM/yyyy}", item.DataCompra), Esporte = (int)produto.ValorSubtotal });
                            }
                        }                       

                    }
                    else if (produto.Categoria.Nome.ToLower() == "social")
                    {
                        if (dashViewModel.Social)
                        {
                            if (lista.Count > 0)
                            {
                                foreach (var grafico in lista)
                                {
                                    if (grafico.Data == String.Format("{0:dd/MM/yyyy}", item.DataCompra))
                                    {
                                        grafico.Social += (int)produto.ValorSubtotal;
                                        conf = false;
                                        continue;
                                    }
                                    else
                                    {
                                        conf = true;
                                    }
                                }
                                if (conf)
                                {
                                    lista.Add(new DashVendasPeriodo { Data = String.Format("{0:dd/MM/yyyy}", item.DataCompra), Social = (int)produto.ValorSubtotal });
                                    conf = false;
                                }
                            }
                            else
                            {
                                lista.Add(new DashVendasPeriodo { Data = String.Format("{0:dd/MM/yyyy}", item.DataCompra), Social = (int)produto.ValorSubtotal });
                            }
                        }
                    }
                    else if (produto.Categoria.Nome.ToLower() == "outro")
                    {
                        if (dashViewModel.Outro)
                        {
                            if (lista.Count > 0)
                            {
                                foreach (var grafico in lista)
                                {
                                    if (grafico.Data == String.Format("{0:dd/MM/yyyy}", item.DataCompra))
                                    {
                                        grafico.Outro += (int)produto.ValorSubtotal;
                                        conf = false;
                                        continue;
                                    }
                                    else
                                    {
                                        conf = true;
                                    }
                                }
                                if (conf)
                                {
                                    lista.Add(new DashVendasPeriodo { Data = String.Format("{0:dd/MM/yyyy}", item.DataCompra), Outro = (int)produto.ValorSubtotal });
                                    conf = false;
                                }
                            }
                            else
                            {
                                lista.Add(new DashVendasPeriodo { Data = String.Format("{0:dd/MM/yyyy}", item.DataCompra), Outro = (int)produto.ValorSubtotal });
                            }
                        }
                    }
                }
            }

            return Json(lista);
        }
        #endregion

        #region Categorias

        public IActionResult Categorias()
        {
            List<Categoria> categorias = facade.ListarCategorias();
            return View(new CategoriaViewModel() { Categorias = categorias});
        }

        [HttpPost]
        public IActionResult NovaCategoria(Categoria categoria)
        {            
            categoria.Status = Models.Enums.Status.Ativo;
            categoria.DataCadastro = DateTime.Now;
            ValidarDadosCategoria validarDadosCategoria = new ValidarDadosCategoria();
            string confirmacaoDados = validarDadosCategoria.Processar(categoria);

            if(confirmacaoDados == null) { 
                string confirmacao = facade.Cadastrar(categoria);                
            }
            return RedirectToAction("Categorias");
        }

        [HttpPost]
        public IActionResult AlterarCategoria(Categoria categoria)
        {
            ValidarDadosCategoria validarDadosCategoria = new ValidarDadosCategoria();
            string confirmacaoDados = validarDadosCategoria.Processar(categoria);

            if (confirmacaoDados == null)
            {
                string conf = facade.Alterar(categoria);                
            }
            return RedirectToAction("Categorias");
        }

        [HttpPost]
        public IActionResult ExcluirCategoria(Categoria categoria)
        {
            string conf = facade.Excluir(categoria);
            return RedirectToAction("Categorias");
        }
        #endregion

        #region Fornecedores

        public IActionResult Fornecedores()
        {
            List<Fornecedor> fornecedores = facade.ListarFornecedores();
            return View(new FornecedorViewModel() { Fornecedores = fornecedores });
        }

        [HttpPost]
        public IActionResult NovoFornecedor(Fornecedor fornecedor)
        {
            fornecedor.Status = Models.Enums.Status.Ativo;
            fornecedor.DataCadastro = DateTime.Now;
            ValidarDadosFornecedor validarDadosFornecedor = new ValidarDadosFornecedor();
            string confirmacaoDados = validarDadosFornecedor.Processar(fornecedor);

            if (confirmacaoDados == null)
            {                
                string confirmacao = facade.Cadastrar(fornecedor);
                
            }
            return RedirectToAction("Fornecedores");           
        }

        [HttpPost]
        public IActionResult AlterarFornecedor(Fornecedor fornecedor)
        {
            ValidarDadosFornecedor validarDadosFornecedor = new ValidarDadosFornecedor();
            string confirmacaoDados = validarDadosFornecedor.Processar(fornecedor);

            if (confirmacaoDados == null)
            {
                string conf = facade.Alterar(fornecedor);                 
            }
            return RedirectToAction("Fornecedores");
        }

        [HttpPost]
        public IActionResult ExcluirFornecedor(Fornecedor fornecedor)
        {
            string conf = facade.Excluir(fornecedor);
            return RedirectToAction("Fornecedores");
        }

        #endregion

        #region GrupoPrecificacao

        public IActionResult GruposPrecificacao()
        {
            List<GrupoPrecificacao> grupos = facade.ListarGruposPrecificacao();
            return View(new GrupoPrecificacaoViewModel() { GruposPrecificacao = grupos });
        }

        [HttpPost]
        public IActionResult NovoGrupoPrecificacao(GrupoPrecificacao grupoPrecificacao)
        {
            grupoPrecificacao.Status = Models.Enums.Status.Ativo;
            grupoPrecificacao.DataCadastro = DateTime.Now;
            ValidarDadosGrupoPrecificacao validarDadosGrupoPrecificacao = new ValidarDadosGrupoPrecificacao();
            string confirmacaoDados = validarDadosGrupoPrecificacao.Processar(grupoPrecificacao);

            if (confirmacaoDados == null)
            {
                string conf = facade.Cadastrar(grupoPrecificacao);                
            }   
            return RedirectToAction("GruposPrecificacao");         
            
        }

        [HttpPost]
        public IActionResult AlterarGrupoPrecificacao(GrupoPrecificacao grupoPrecificacao)
        {
            ValidarDadosGrupoPrecificacao validarDadosGrupoPrecificacao = new ValidarDadosGrupoPrecificacao();
            string confirmacaoDados = validarDadosGrupoPrecificacao.Processar(grupoPrecificacao);

            if (confirmacaoDados == null)
            {
                string conf = facade.Alterar(grupoPrecificacao); 
                
            }
            return RedirectToAction("GruposPrecificacao");
        }

        [HttpPost]
        public IActionResult ExcluirGrupoPrecificacao(GrupoPrecificacao grupoPrecificacao)
        {
            string conf = facade.Excluir(grupoPrecificacao);
            return RedirectToAction("GruposPrecificacao");
        }
        #endregion

        #region Cupons

        public IActionResult Cupons()
        {

            return View(new CupomViewModel());
        }

        [HttpPost]
        public IActionResult NovoCupom(Cupom cupom)
        {
            cupom.Promocional = true;
            cupom.Status = Models.Enums.Status.Ativo;
            cupom.DataCadastro = DateTime.Now;
            ValidarDadosCupom validarDadosCupom = new ValidarDadosCupom();
            string confirmacao = validarDadosCupom.Processar(cupom);
            if(confirmacao == null)
            {
                string conf = facade.Cadastrar(cupom);               
            }
            return RedirectToAction("Cupons");
        }

        public IActionResult ProcurarCupons(Cupom cupom)
        {
            var cupons = facade.ConsultarFiltroCupom(cupom);
            return View("Cupons", new CupomViewModel() { Cupons = cupons });
        }

        public IActionResult AtivarCupom(Cupom cupom)
        {
            Cupom cupomRetornado = (Cupom)facade.ConsultarId(cupom);
            cupomRetornado.Status = Models.Enums.Status.Ativo;
            string conf = facade.Alterar(cupomRetornado);
            return View("Cupons", new CupomViewModel());
        }

        public IActionResult InativarCupom(Cupom cupom)
        {
            Cupom cupomRetornado = (Cupom)facade.ConsultarId(cupom);
            cupomRetornado.Status = Models.Enums.Status.Inativo;
            string conf = facade.Alterar(cupomRetornado);
            return View("Cupons", new CupomViewModel());
        }

        public IActionResult ExcluirCupom(Cupom cupom)
        {
            Cupom cupomRetornado = (Cupom)facade.ConsultarId(cupom);            
            string conf = facade.Excluir(cupomRetornado);
            return View("Cupons", new CupomViewModel());
        }

        #endregion
    }
}
