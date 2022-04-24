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
        
        public IActionResult AprovarPedido(Pedido pedido)
        {
            return View();
        }
        
        public IActionResult AprovarEntrega(Pedido pedido)
        {
            return View();
        }
    }
}
