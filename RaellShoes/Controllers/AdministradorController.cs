using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RaellShoes.Data;
using RaellShoes.Facadee;
using RaellShoes.Models;
using RaellShoes.Models.Administrador;
using RaellShoes.Models.Clientes;
using RaellShoes.Models.ViewModel;
using System;
using System.Collections.Generic;
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
                return View();
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
            return View();
        }
    }
}
