using Microsoft.EntityFrameworkCore;
using RaellShoes.Data;
using RaellShoes.Models;
using RaellShoes.Models.Administrador;
using RaellShoes.Models.Clientes;
using RaellShoes.Models.NN;
using RaellShoes.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RaellShoes.Dal
{
    public class DAL : IDAL
    {
        protected readonly DataBaseContext dbContext;
        public DAL(DataBaseContext dbContext)
        {
            this.dbContext = dbContext;
        }        

        //MÉTODOS GENÉRICOS
        public string Cadastrar(EntidadeDominio entidadeDominio)
        {
            try
            {
                dbContext.Add(entidadeDominio);
                dbContext.SaveChanges();
                return null;
            }
            catch (Exception e)
            {
                return e.Message;
            }
            
        }

        public string Alterar(EntidadeDominio entidadeDominio)
        {
            
            switch (entidadeDominio.GetType().Name.ToLower())
            {
                case ("cliente"):
                    if (!dbContext.Cliente.Any(x => x.Id == entidadeDominio.Id))
                    {
                        throw new ApplicationException("Objeto não encontrado");
                    }
                    return ExtensaoAlterar(entidadeDominio);

                case ("endereco"):
                    if (!dbContext.Endereco.Any(x => x.Id == entidadeDominio.Id))
                    {
                        throw new ApplicationException("Objeto não encontrado");
                    }
                    return ExtensaoAlterar(entidadeDominio);

                case ("cartao"):
                    if (!dbContext.Cartao.Any(x => x.Id == entidadeDominio.Id))
                    {
                        throw new ApplicationException("Objeto não encontrado");
                    }
                    return ExtensaoAlterar(entidadeDominio);

                case ("produtocliente"):
                    if (!dbContext.ProdutoCliente.Any(x => x.Id == entidadeDominio.Id))
                    {
                        throw new ApplicationException("Objeto não encontrado");
                    }
                    return ExtensaoAlterar(entidadeDominio);

                case ("produto"):
                    if (!dbContext.Produto.Any(x => x.Id == entidadeDominio.Id))
                    {
                        throw new ApplicationException("Objeto não encontrado");
                    }
                    return ExtensaoAlterar(entidadeDominio);

                case ("categoria"):
                    if (!dbContext.Categoria.Any(x => x.Id == entidadeDominio.Id))
                    {
                        throw new ApplicationException("Objeto não encontrado");
                    }
                    return ExtensaoAlterar(entidadeDominio);
                case ("fornecedor"):
                    if (!dbContext.Fornecedor.Any(x => x.Id == entidadeDominio.Id))
                    {
                        throw new ApplicationException("Objeto não encontrado");
                    }
                    return ExtensaoAlterar(entidadeDominio);
                case ("grupoprecificacao"):
                    if (!dbContext.GrupoPrecificacao.Any(x => x.Id == entidadeDominio.Id))
                    {
                        throw new ApplicationException("Objeto não encontrado");
                    }
                    return ExtensaoAlterar(entidadeDominio);


                default:
                    return null;
            }
        }

        private string ExtensaoAlterar(EntidadeDominio entidadeDominio)
        {
            try
            {                
                dbContext.Update(entidadeDominio);
                dbContext.SaveChanges();
                return null;
            }
            catch (ApplicationException e)
            {
                return e.Message;
            }
        }

        public string Excluir(EntidadeDominio entidadeDominio)
        {
            try
            {
                dbContext.Remove(entidadeDominio);
                dbContext.SaveChanges();
                return null;
            }
            catch (Exception e )
            {
                return e.Message;
            }
            
        }

        public List<EntidadeDominio> Consultar(EntidadeDominio entidadeDominio)
        {
            List<EntidadeDominio> resultado = new List<EntidadeDominio>(); 

            switch (entidadeDominio.GetType().Name.ToLower())
            {
                case ("endereco"): 
                    foreach (EntidadeDominio x in dbContext.Endereco.Include(x => x.Cidade).Include(x => x.Cidade.Estado).Include(x => x.Cidade.Estado.Pais)
                     .ToList().Where(x => x.ClienteId == entidadeDominio.Id && x.TipoEndereco != 0))
                    {
                        resultado.Add(x);
                    }
                    return resultado;

                case ("cartao"):
                    foreach (EntidadeDominio x in dbContext.Cartao.ToList().Where(x => x.ClienteId == entidadeDominio.Id))
                    {
                        resultado.Add(x);
                    }
                    return resultado;

                case ("produtocliente"):
                    ProdutoCliente produtoCliente = (ProdutoCliente)entidadeDominio;
                    foreach (EntidadeDominio x in dbContext.ProdutoCliente.ToList().Where(x => x.ClienteId == produtoCliente.ClienteId && x.ProdutoId == produtoCliente.ProdutoId))
                    {
                        resultado.Add(x);
                    }
                    return resultado;

                case ("cupomcliente"):
                    CupomCliente cupomCliente = (CupomCliente)entidadeDominio;

                    foreach (EntidadeDominio x in dbContext.CupomCliente.ToList().Where(x => x.ClienteId == cupomCliente.ClienteId ))
                    {
                        resultado.Add(x);
                    }
                    return resultado;

                case ("cupom"):
                    Cupom cupom = (Cupom)entidadeDominio;

                    foreach (EntidadeDominio x in dbContext.Cupom.ToList().Where(x => x.ClienteId == cupom.ClienteId && x.Status == Models.Enums.Status.Ativo))
                    {
                        resultado.Add(x);
                    }

                    foreach (EntidadeDominio x in dbContext.Cupom.ToList().Where(x => x.Promocional == true && x.Status == Models.Enums.Status.Ativo))
                    {
                        resultado.Add(x);
                    }
                    return resultado;

                case ("pedido"):
                    Pedido pedido = (Pedido)entidadeDominio;

                    foreach (EntidadeDominio x in dbContext.Pedido.ToList().Where(x => x.ClienteId == pedido.ClienteId))
                    {
                        resultado.Add(x);
                    }
                    return resultado;

                case ("produtopedido"):
                    ProdutoPedido produtoPedido = (ProdutoPedido)entidadeDominio;

                    foreach (EntidadeDominio x in dbContext.ProdutoPedido.ToList().Where(x => x.PedidoId == produtoPedido.PedidoId))
                    {
                        resultado.Add(x);
                    }
                    return resultado;

                case ("troca"):
                    Troca troca = (Troca)entidadeDominio;

                    foreach (EntidadeDominio x in dbContext.Troca.Include(x => x.Pedido).Include(x => x.Produto).ToList().Where(x => x.IddoCliente == troca.IddoCliente))
                    {
                        resultado.Add(x);
                    }
                    return resultado;

                case ("categoria"):
                    Categoria categoria = (Categoria)entidadeDominio;

                    foreach (EntidadeDominio x in dbContext.Categoria.ToList().Where(x => x.Status == Models.Enums.Status.Ativo))
                    {
                        resultado.Add(x);
                    }
                    return resultado;

                case ("grupoprecificacao"):
                    GrupoPrecificacao grupo = (GrupoPrecificacao)entidadeDominio;

                    foreach (EntidadeDominio x in dbContext.GrupoPrecificacao.ToList().Where(x => x.Status == Models.Enums.Status.Ativo))
                    {
                        resultado.Add(x);
                    }
                    return resultado;

                case ("fornecedor"):
                    Fornecedor fornecedor = (Fornecedor)entidadeDominio;

                    foreach (EntidadeDominio x in dbContext.Fornecedor.ToList().Where(x => x.Status == Models.Enums.Status.Ativo))
                    {
                        resultado.Add(x);
                    }
                    return resultado;


                default:
                    return null;
            }
        }

        public EntidadeDominio ConsultarId(EntidadeDominio entidadeDominio)
        {          
           
            if (entidadeDominio.GetType().Name.ToLower().Equals("cliente"))
            {
                 Cliente cliente = dbContext.Cliente
                    .Include(x => x.Telefone)
                    .Include(x => x.Usuario)
                    .FirstOrDefault(x => x.Id == entidadeDominio.Id); 

                Endereco enderecoResidencial = dbContext.Endereco
                   .Include(x => x.Cidade)
                   .Include(x => x.Cidade.Estado)
                   .Include(x => x.Cidade.Estado.Pais)
                   .FirstOrDefault(x => x.ClienteId == entidadeDominio.Id && x.TipoEndereco == 0);

                cliente.Endereco = enderecoResidencial;

                return cliente;

            }

            if (entidadeDominio.GetType().Name.ToLower().Equals("usuario"))
            {
                Usuario usuario = dbContext.Usuario.FirstOrDefault(x => x.Id == entidadeDominio.Id);  
                return usuario;
            }

            if (entidadeDominio.GetType().Name.ToLower().Equals("endereco"))
            {
                  return dbContext.Endereco                   
                   .Include(x => x.Cidade)
                   .Include(x => x.Cidade.Estado)
                   .Include(x => x.Cidade.Estado.Pais)
                   .FirstOrDefault(x => x.Id == entidadeDominio.Id);
            }

            if (entidadeDominio.GetType().Name.ToLower().Equals("produto"))
            {
                try
                {
                    Produto produto = dbContext.Produto
                        .Include(obj => obj.FichaTecnica)
                        .Include(obj => obj.Categoria)
                        .Include(obj => obj.Fornecedor)
                        .Include(obj => obj.GrupoPrecificacao)                        
                        .FirstOrDefault(x => x.Id == entidadeDominio.Id);
                    
                    return produto;
                    
                }
                catch (ApplicationException e)
                {
                    throw new ApplicationException(e.Message);
                }
            }

            if (entidadeDominio.GetType().Name.ToLower().Equals("produtopedido"))
            {
                try
                {
                    ProdutoPedido produto = dbContext.ProdutoPedido
                        .Include(obj => obj.FichaTecnica)                        
                        .Include(obj => obj.Fornecedor)
                        .Include(obj => obj.GrupoPrecificacao)
                         .Include(obj => obj.Categoria)
                        .FirstOrDefault(x => x.Id == entidadeDominio.Id);

                    return produto;

                }
                catch (ApplicationException e)
                {
                    throw new ApplicationException(e.Message);
                }
            }
            if (entidadeDominio.GetType().Name.ToLower().Equals("pedido"))
            {
                try
                {
                    Pedido pedido = dbContext.Pedido
                        .Include(obj => obj.Cliente)
                        .Include(obj => obj.Cliente.Telefone)
                        .Include(obj => obj.Cliente.Usuario)
                        .Include(obj => obj.Cupom)                       
                        .FirstOrDefault(x => x.Id == entidadeDominio.Id);

                    return pedido;

                }
                catch (ApplicationException e)
                {
                    throw new ApplicationException(e.Message);
                }
            }

            if (entidadeDominio.GetType().Name.ToLower().Equals("troca"))
            {
                try
                {
                    Troca troca = dbContext.Troca
                        .Include(obj => obj.Pedido)
                        .Include(obj => obj.Pedido.Cliente)
                        .Include(obj => obj.Pedido.Cliente.Telefone)
                        .Include(obj => obj.Pedido.Cliente.Usuario)
                        .Include(obj => obj.Produto)
                        .FirstOrDefault(x => x.Id == entidadeDominio.Id);

                    return troca;

                }
                catch (ApplicationException e)
                {
                    throw new ApplicationException(e.Message);
                }
            }

            if (entidadeDominio.GetType().Name.ToLower().Equals("cupom"))
            {
                try
                {
                    Cupom cupom = dbContext.Cupom.FirstOrDefault(x => x.Id == entidadeDominio.Id);

                    return cupom;

                }
                catch (ApplicationException e)
                {
                    throw new ApplicationException(e.Message);
                }
            }

            if (entidadeDominio.GetType().Name.ToLower().Equals("categoria"))
            {
                try
                {
                    Categoria categoria = dbContext.Categoria.FirstOrDefault(x => x.Id == entidadeDominio.Id);

                    return categoria;

                }
                catch (ApplicationException e)
                {
                    throw new ApplicationException(e.Message);
                }
            }
            if (entidadeDominio.GetType().Name.ToLower().Equals("grupoprecificacao"))
            {
                try
                {
                    GrupoPrecificacao grupo = dbContext.GrupoPrecificacao.FirstOrDefault(x => x.Id == entidadeDominio.Id);

                    return grupo;

                }
                catch (ApplicationException e)
                {
                    throw new ApplicationException(e.Message);
                }
            }
            if (entidadeDominio.GetType().Name.ToLower().Equals("fornecedor"))
            {
                try
                {
                    Fornecedor fornecedor = dbContext.Fornecedor.FirstOrDefault(x => x.Id == entidadeDominio.Id);

                    return fornecedor;

                }
                catch (ApplicationException e)
                {
                    throw new ApplicationException(e.Message);
                }
            }
            return null;                    
        }
        
        public Cliente ConsultarEmail(String email)
        {
            return dbContext.Cliente.Include(x => x.Usuario).FirstOrDefault(x => x.Usuario.Email == email);           
        }


        //*********MÉTODOS ESPECIALISTA****************        

        public Cliente Login(Cliente cliente)
        {
            Cliente clienteBanco = ConsultarEmail(cliente.Usuario.Email);
            if (clienteBanco != null)
            {
                if (cliente.Usuario.Senha.Equals(clienteBanco.Usuario.Senha))
                    return clienteBanco;
            }
            return null;
        }

        public ICollection<Produto> ConsultarFiltroProdutos(Produto produto)
        {
            HashSet<Produto> consulta = new HashSet<Produto>();

            if (produto.Marca != null)
            {
                var resultado = dbContext.Produto.Where(x => x.Marca == produto.Marca && x.Status == Models.Enums.Status.Ativo).ToList();
                foreach (Produto item in resultado)
                {
                    Produto retornoProduto = (Produto)ConsultarId(item);
                    consulta.Add(retornoProduto);
                }
            }

            if (produto.Nome != null)
            {
                var resultado = dbContext.Produto.Where(x => x.Nome == produto.Nome &&  x.Status == Models.Enums.Status.Ativo).ToList();
                foreach (Produto item in resultado)
                {
                    Produto retornoProduto = (Produto)ConsultarId(item);
                    consulta.Add(retornoProduto);
                }
            }

            if (produto.Modelo != null)
            {
                var resultado = dbContext.Produto.Where(x => x.Modelo == produto.Modelo && x.Status == Models.Enums.Status.Ativo).ToList();
                foreach (Produto item in resultado)
                {
                    Produto retornoProduto = (Produto)ConsultarId(item);
                    consulta.Add(retornoProduto);
                }
            }

            if (produto.CorPrimariaProduto != null)
            {
                var resultado = dbContext.Produto.Where(x => x.CorPrimariaProduto == produto.CorPrimariaProduto && x.Status == Models.Enums.Status.Ativo).ToList();
                foreach (Produto item in resultado)
                {
                    Produto retornoProduto = (Produto)ConsultarId(item);
                    consulta.Add(retornoProduto);
                }
            }

            if (produto.Genero != null)
            {
                var resultado = dbContext.Produto.Where(x => x.Genero == produto.Genero && x.Status == Models.Enums.Status.Ativo).ToList();
                foreach (Produto item in resultado)
                {
                    Produto retornoProduto = (Produto)ConsultarId(item);
                    consulta.Add(retornoProduto);
                }
            }
            

            if (produto.Tamanho != null)
            {
                var resultado = dbContext.Produto.Where(x => x.Tamanho == produto.Tamanho && x.Status == Models.Enums.Status.Ativo).ToList();
                foreach (Produto item in resultado)
                {
                    Produto retornoProduto = (Produto)ConsultarId(item);
                    consulta.Add(retornoProduto);
                }
            }

            if (produto.Valor != null)
            {
                var resultado = dbContext.Produto.Where(x => x.Valor == produto.Valor && x.Status == Models.Enums.Status.Ativo).ToList();
                foreach (Produto item in resultado)
                {
                    Produto retornoProduto = (Produto)ConsultarId(item);
                    consulta.Add(retornoProduto);
                }
            }

            
            return consulta;
        }

        public ICollection<Produto> ConsultarFiltroProdutosAdmin(Produto produto)
        {
            HashSet<Produto> consulta = new HashSet<Produto>();

            if (produto.Marca != null)
            {
                var resultado = dbContext.Produto.Where(x => x.Marca == produto.Marca).ToList();
                foreach (Produto item in resultado)
                {
                    Produto retornoProduto = (Produto)ConsultarId(item);
                    consulta.Add(retornoProduto);
                }
            }

            if (produto.Nome != null)
            {
                var resultado = dbContext.Produto.Where(x => x.Nome == produto.Nome).ToList();
                foreach (Produto item in resultado)
                {
                    Produto retornoProduto = (Produto)ConsultarId(item);
                    consulta.Add(retornoProduto);
                }
            }

            if (produto.Modelo != null)
            {
                var resultado = dbContext.Produto.Where(x => x.Modelo == produto.Modelo).ToList();
                foreach (Produto item in resultado)
                {
                    Produto retornoProduto = (Produto)ConsultarId(item);
                    consulta.Add(retornoProduto);
                }
            }

            if (produto.CorPrimariaProduto != null)
            {
                var resultado = dbContext.Produto.Where(x => x.CorPrimariaProduto == produto.CorPrimariaProduto).ToList();
                foreach (Produto item in resultado)
                {
                    Produto retornoProduto = (Produto)ConsultarId(item);
                    consulta.Add(retornoProduto);
                }
            }

            if (produto.Genero != null)
            {
                var resultado = dbContext.Produto.Where(x => x.Genero == produto.Genero).ToList();
                foreach (Produto item in resultado)
                {
                    Produto retornoProduto = (Produto)ConsultarId(item);
                    consulta.Add(retornoProduto);
                }
            }


            if (produto.Tamanho != null)
            {
                var resultado = dbContext.Produto.Where(x => x.Tamanho == produto.Tamanho).ToList();
                foreach (Produto item in resultado)
                {
                    Produto retornoProduto = (Produto)ConsultarId(item);
                    consulta.Add(retornoProduto);
                }
            }

            if (produto.Valor != null)
            {
                var resultado = dbContext.Produto.Where(x => x.Valor == produto.Valor).ToList();
                foreach (Produto item in resultado)
                {
                    Produto retornoProduto = (Produto)ConsultarId(item);
                    consulta.Add(retornoProduto);
                }
            }

            if(produto.DataCadastro != null)
            {
                var resultado = dbContext.Produto.Where(x => x.DataCadastro == produto.DataCadastro).ToList();
                foreach (Produto item in resultado)
                {
                    Produto retornoProduto = (Produto)ConsultarId(item);
                    consulta.Add(retornoProduto);
                }
            }

            if(produto.Categoria != null)
            {
                var resultado = dbContext.Produto.Where(x => x.Categoria == produto.Categoria).ToList();
                foreach (Produto item in resultado)
                {
                    Produto retornoProduto = (Produto)ConsultarId(item);
                    consulta.Add(retornoProduto);
                }
            }

            if(produto.CodigoBarra != null)
            {
                var resultado = dbContext.Produto.Where(x => x.CodigoBarra == produto.CodigoBarra).ToList();
                foreach (Produto item in resultado)
                {
                    Produto retornoProduto = (Produto)ConsultarId(item);
                    consulta.Add(retornoProduto);
                }
            }

            if(produto.Status != null)
            {
                var resultado = dbContext.Produto.Where(x => x.Status == produto.Status).ToList();
                foreach (Produto item in resultado)
                {
                    Produto retornoProduto = (Produto)ConsultarId(item);
                    consulta.Add(retornoProduto);
                }
            }

            if(produto.GrupoPrecificacao != null)
            {
                var resultado = dbContext.Produto.Where(x => x.GrupoPrecificacao == produto.GrupoPrecificacao).ToList();
                foreach (Produto item in resultado)
                {
                    Produto retornoProduto = (Produto)ConsultarId(item);
                    consulta.Add(retornoProduto);
                }
            }

            if(produto.Fornecedor != null)
            {
                var resultado = dbContext.Produto.Where(x => x.Fornecedor == produto.Fornecedor).ToList();
                foreach (Produto item in resultado)
                {
                    Produto retornoProduto = (Produto)ConsultarId(item);
                    consulta.Add(retornoProduto);
                }
            }


            return consulta;
        }

        private Produto FiltroProdutosCliente(Produto produto)
        {
            try
            {
                Produto produtoAtivo = dbContext.Produto.Where(x=> x.Status == Models.Enums.Status.Ativo)
                    .Include(obj => obj.FichaTecnica)
                    .Include(obj => obj.Categoria)
                    .Include(obj => obj.Fornecedor)
                    .Include(obj => obj.GrupoPrecificacao)
                    .FirstOrDefault(x => x.Id == produto.Id);

                return produtoAtivo;

            }
            catch (ApplicationException e)
            {
                throw new ApplicationException(e.Message);
            }
        }

        public List<ProdutoCliente> BuscaProdutoCliente(int idCliente)
        {
             return dbContext.ProdutoCliente.Where(x => x.ClienteId == idCliente).ToList();          
             
        }

        public Carrinho BuscarCarrinho(int idCliente)
        {
            var resultado = dbContext.ProdutoCliente.Where(x => x.ClienteId == idCliente).ToList();
            Carrinho carrinho = new Carrinho();
            Produto produto = new Produto();
            foreach (var item in resultado)
            {
                produto.Id = item.ProdutoId;
                Produto produtoResult = (Produto)ConsultarId(produto);
                
                if(produtoResult != null)
                {     
                                      
                    carrinho.Produtos.Add(produtoResult);
                }
            }

            return carrinho;
        }

        public List<Pedido> ConsultarFiltroPedidoAdmin(Pedido pedido)
        {
            HashSet<Pedido> consulta = new HashSet<Pedido>();
            List<Pedido> pedidos = new List<Pedido>();

            if (pedido.NumeroPedido != null)
            {
                var resultado = dbContext.Pedido.Where(x => x.NumeroPedido == pedido.NumeroPedido).ToList();
                foreach (Pedido item in resultado)
                {
                    Pedido retornoPedido = (Pedido)ConsultarId(item);
                    consulta.Add(retornoPedido);
                }
            }

            if (pedido.DataCompra != null)
            {
                var resultado = dbContext.Pedido.Where(x => x.DataCompra == pedido.DataCompra).ToList();
                foreach (Pedido item in resultado)
                {
                    Pedido retornoPedido = (Pedido)ConsultarId(item);
                    consulta.Add(retornoPedido);
                }
            }

            if (pedido.FormaPagamento != null)
            {
                var resultado = dbContext.Pedido.Where(x => x.FormaPagamento == pedido.FormaPagamento).ToList();
                foreach (Pedido item in resultado)
                {
                    Pedido retornoPedido = (Pedido)ConsultarId(item);
                    consulta.Add(retornoPedido);
                }
            }

            if (pedido.Status != null)
            {
                var resultado = dbContext.Pedido.Where(x => x.Status == pedido.Status).ToList();
                foreach (Pedido item in resultado)
                {
                    Pedido retornoPedido = (Pedido)ConsultarId(item);
                    consulta.Add(retornoPedido);
                }
            }

            foreach (var item in consulta)
            {
                pedidos.Add(item);
            }

            return pedidos;
        }

        public List<Troca> ConsultarFiltroTrocasAdmin(Troca troca)
        {
            HashSet<Troca> consulta = new HashSet<Troca>();
            List<Troca> listaTrocas = new List<Troca>();

            if (troca.Pedido.NumeroPedido != null)
            {
                var resultado = dbContext.Troca.Where(x => x.Pedido.NumeroPedido == troca.Pedido.NumeroPedido).ToList();
                foreach (Troca item in resultado)
                {
                    Troca retornoPedido = (Troca)ConsultarId(item);
                    consulta.Add(retornoPedido);
                }
            }

            if (troca.DataSolicitacao != null)
            {
                var resultado = dbContext.Troca.Where(x => x.DataSolicitacao == troca.DataSolicitacao).ToList();
                foreach (Troca item in resultado)
                {
                    Troca retornoPedido = (Troca)ConsultarId(item);
                    consulta.Add(retornoPedido);
                }
            }

            if (troca.Pedido.Cliente.Cpf != null)
            {
                var resultado = dbContext.Troca.Where(x => x.Pedido.Cliente.Cpf == troca.Pedido.Cliente.Cpf).ToList();
                foreach (Troca item in resultado)
                {
                    Troca retornoPedido = (Troca)ConsultarId(item);
                    consulta.Add(retornoPedido);
                }
            }

            if (troca.Status != null)
            {
                var resultado = dbContext.Troca.Where(x => x.Status == troca.Status).ToList();
                foreach (Troca item in resultado)
                {
                    Troca retornoPedido = (Troca)ConsultarId(item);
                    consulta.Add(retornoPedido);
                }
            }

            foreach (var item in consulta)
            {
                listaTrocas.Add(item);
            }

            return listaTrocas;
        }

         public List<Categoria> ConsultarCategoriasDash()
        {
            return dbContext.Categoria.ToList();
        }

        public List<Pedido> GerarGrafico(DashViewModel model)
        {
           return dbContext.Pedido.Where(x => x.DataCompra >= model.DataInicio && x.DataCompra <= model.DataFinal).OrderBy(x => x.DataCompra).ToList();
        }

        public List<ProdutoPedido> ConsultarProdutosDoPedido(Pedido pedido)
        {
            return dbContext.ProdutoPedido.Where(x => x.PedidoId == pedido.Id)
                .Include(obj => obj.Categoria).ToList();
        }

        public List<Categoria> ListarCategorias()
        {
            return dbContext.Categoria.ToList();
        }
        public List<Fornecedor> ListarFornecedores()
        {
            return dbContext.Fornecedor.ToList();
        }
        public List<GrupoPrecificacao> ListarGruposPrecificacao()
        {
            return dbContext.GrupoPrecificacao.ToList();
        }


    }
}
