using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RaellShoes.Data;
using RaellShoes.Facadee;
using RaellShoes.Models;
using RaellShoes.Models.Clientes;
using RaellShoes.Models.Enums;
using RaellShoes.Models.ViewModel;

namespace RaellShoes.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataBaseContext dbContext;
        private readonly Facade facade;

        public HomeController(DataBaseContext dbContext)
        {
            this.dbContext = dbContext;
            facade = new Facade(dbContext);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contato()
        { 
            return View();
        }

        public IActionResult SobreNos()
        {
            return View();
        }

        public IActionResult PerguntasFrequentes()
        {
            return View();
        }

        public IActionResult EsqueceuSenha()
        {            
            return View();
        }

        [HttpPost]
        public IActionResult EsqueceuSenha(Cliente cliente)
        {
            //Fazer validações
            return View("Login");
        }

        public IActionResult Login()
        {           
            return View();
        }

        [HttpPost]
        public IActionResult Login(Cliente cliente)
        {
            LoginViewModel clienteLogado = facade.Login(cliente);              
            

            if (clienteLogado != null && !clienteLogado.Admin)
            {
                HttpContext.Session.SetInt32("UsuarioId", clienteLogado.IdCliente);                
                return RedirectToAction("Index", "clientes", clienteLogado);

            }else if(clienteLogado != null && clienteLogado.Admin)
            {
                HttpContext.Session.SetInt32("UsuarioId", clienteLogado.IdCliente);
                
                return RedirectToAction("Index", "administrador", clienteLogado);
            } 
                

            return View();
        }

        public IActionResult ConfirmarEmail()
        {
            return View();
        }

        public IActionResult CadastreSe(Cliente emailCliente)
        {
            Cliente cliente = facade.ConsultarEmail(emailCliente.Usuario.Email);

            //Falta Redirecionar mensagem de erro
            if (cliente != null && cliente.Usuario.Email == emailCliente.Usuario.Email) 
                return RedirectToAction("Login");


            return View(emailCliente);
        }

        [HttpPost]
        public IActionResult CadastrarCliente(Cliente cliente)
        {          

            string confirmacaoCliente = facade.Cadastrar(cliente);

            string retornoEnderecos = facade.CadastrarEnderecosIniciais(cliente);

            if (confirmacaoCliente == null && retornoEnderecos == null)            
                return View("SucessoCadastro");           
               
            else           
                return View("ErroCadastro", new String("Houve um erro ao cadastrar as informações!!! \n Erro: " + confirmacaoCliente));          
        }

        public IActionResult SucessoCadastro()
        {
            return View();
        }

        public IActionResult DetalhesProduto()
        {
            return View();
        }

        public IActionResult Erro(String mensagem)
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}
