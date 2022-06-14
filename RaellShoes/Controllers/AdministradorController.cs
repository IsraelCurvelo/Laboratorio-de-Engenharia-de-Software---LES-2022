using Microsoft.AspNetCore.Http;
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

        //********************PEDIDOS************************

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

        //***********************TROCA*******************************

        public IActionResult VerSolicitacaoTroca(Pedido pedidoSolicitacao)
        {
            //IMPLEMENTAR APÒS TROCA

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

        //****************PRODUTO********************
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
            return Ok();
        }

        //*****************GRAFICO********************
        [HttpPost]
        public IActionResult GerarGrafico(DashViewModel dashViewModel)
        {           

            dashViewModel.MostrarGrafico = true;   

            return View("Index", dashViewModel);
        }

        //Retorna dados JSO da população de cada estado
        public JsonResult JsonGrafico()
        {
            /*
            var lista = new List<DashVendasPeriodo>();
            lista.Add(new DashVendasPeriodo { Data = String.Format("{0:dd/MM/yyyy}", "2022, 05,01",) Casual = 330, Corrida = 390,Treino = 200, Skate = 100 });
            lista.Add(new DashVendasPeriodo { Data = String.Format("{0:dd/MM/yyyy}", "2022, 05,06",) Casual = 320, Corrida = 380,Treino = 300, Skate = 120 });
            lista.Add(new DashVendasPeriodo { Data = String.Format("{0:dd/MM/yyyy}", "2022, 05, 09"), Casual = 310, Corrida = 360, Treino = 560, Skate = 190 });
            lista.Add(new DashVendasPeriodo { Data = String.Format("{0:dd/MM/yyyy}", "2022, 05, 10"), Casual = 380, Corrida = 320, Treino = 593, Skate = 220 });
            lista.Add(new DashVendasPeriodo { Data = String.Format("{0:dd/MM/yyyy}", "2022, 05, 11"), Casual = 390, Corrida = 380, Treino = 530, Skate = 400 });
            */
            DashViewModel dashViewModel = new DashViewModel() { DataInicio = new DateTime(2020, 02, 02), DataFinal = DateTime.Now };
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
                        if(lista.Count > 0)
                        {
                            foreach (var grafico in lista)
                            {
                                if(grafico.Data == String.Format("{0:dd/MM/yyyy}", item.DataCompra)){
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
                    else if (produto.Categoria.Nome.ToLower() == "corrida")
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
                    else if (produto.Categoria.Nome.ToLower() == "treino")
                    {
                        if(lista.Count > 0)
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
                    else if (produto.Categoria.Nome.ToLower() == "skate")
                    {
                        if(lista.Count > 0)
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
                    else if (produto.Categoria.Nome.ToLower() == "basquete")
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
                    else if (produto.Categoria.Nome.ToLower() == "esporte")
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
                    else if (produto.Categoria.Nome.ToLower() == "social")
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
                    else if (produto.Categoria.Nome.ToLower() == "outro")
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

            return Json(lista);
        }

        //*****************************PARAMETROS*****************************************

        public IActionResult Categorias()
        {
            return View(new Categoria());
        }

        [HttpPost]
        public IActionResult NovaCategoria(Categoria categoria)
        {
            if(categoria.Nome != null)
            {
                categoria.Status = Models.Enums.Status.Ativo;
                categoria.DataCadastro = DateTime.Now;
                string confirmacao = facade.Cadastrar(categoria);
                return RedirectToAction("Categorias");
            }
            else
                return RedirectToAction("ErroCadastro", "Home", new string("Categoria não contém nome"));

        }
    }
}
