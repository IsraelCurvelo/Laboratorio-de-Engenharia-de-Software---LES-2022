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

        public IActionResult VerSolicitacaoTroca(Pedido pedidoSolicitacao)
        {
            //IMPLEMENTAR APÒS TROCA

            return View();
        }
    }
}
