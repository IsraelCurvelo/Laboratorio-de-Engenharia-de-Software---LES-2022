using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RaellShoes.Data;
using RaellShoes.Facadee;
using RaellShoes.Models;
using RaellShoes.Models.Clientes;
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
            return View(cliente);
        }

        //**************************PERFIL**************************
        public IActionResult MeuPerfil()
        {
            Cliente cliente = new Cliente { Id = 1 };
            Cliente clienteBanco = (Cliente)facade.ConsultarId(cliente);

            if (clienteBanco == null) 
                RedirectToAction("Index");

            return View(clienteBanco);
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
            Endereco endereco = new Endereco() { Id = 1 };
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

       
        [HttpPost]
        public IActionResult CadastrarEndereco(Endereco endereco)
        {
            //Após criar autenticação pegar o ID do cliente logado
            endereco.ClienteId = 1;
            string confirmacao = facade.Cadastrar(endereco);

            return RedirectToAction("MeusEnderecos");
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
            Cartao cartao = new Cartao() { Id = 1 };
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


        public IActionResult CadastrarCartao()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarCartao(Cartao cartao)
        {
            cartao.ClienteId = 1;
            string confirmacao = facade.Cadastrar(cartao);

            return RedirectToAction("MeusCartoes");
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



        //**************************PEDIDOS**************************
        public IActionResult Pedidos()
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

