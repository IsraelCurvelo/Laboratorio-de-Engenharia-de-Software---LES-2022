using RaellShoes.Models.Administrador;
using RaellShoes.Models.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaellShoes.Data
{
    public class PopularBanco
    {
        private DataBaseContext dbContext;

        public PopularBanco(DataBaseContext context)
        {
            dbContext = context;
        }

        public void Popular()
        {
            if (dbContext.Fornecedor.Any()|| dbContext.Categoria.Any() || dbContext.GrupoPrecificacao.Any() 
                || dbContext.Cliente.Any() || dbContext.Cupom.Any() || dbContext.Produto.Any())
                return;
               
          

            Fornecedor fornecedor1 = new Fornecedor
            {
                DataCadastro = DateTime.Now,
                Nome = "SportBras",
                Status = Models.Enums.Status.Ativo,
                CNPJ = "19.547.216/0001-08"
            };

            Fornecedor fornecedor2 = new Fornecedor
            {
                DataCadastro = DateTime.Now,
                Nome = "NM Store",
                Status = Models.Enums.Status.Ativo,
                CNPJ = "64.491.902/0001-50"
            };
            Fornecedor fornecedor3 = new Fornecedor
            {
                DataCadastro = DateTime.Now,
                Nome = "ShoesBR",
                Status = Models.Enums.Status.Ativo,
                CNPJ = "78.895.909/0001-42"
            };
            Fornecedor fornecedor4 = new Fornecedor
            {
                DataCadastro = DateTime.Now,
                Nome = "YHI Tenis",
                Status = Models.Enums.Status.Ativo,
                CNPJ = "12.476.481/0001-95"
            };
            Fornecedor fornecedor5 = new Fornecedor
            {
                DataCadastro = DateTime.Now,
                Nome = "Centauro Shoes",
                Status = Models.Enums.Status.Ativo,
                CNPJ = "31.344.467/0001-82"
            };

            Categoria categoria1 = new Categoria {
                DataCadastro = DateTime.Now,
                Nome = "Treino",
                Status = Models.Enums.Status.Ativo
            };

            Categoria categoria2 = new Categoria
            {
                DataCadastro = DateTime.Now,
                Nome = "Casual",
                Status = Models.Enums.Status.Ativo
            };

            Categoria categoria3 = new Categoria
            {
                DataCadastro = DateTime.Now,
                Nome = "Social",
                Status = Models.Enums.Status.Ativo
            };

            Categoria categoria4 = new Categoria
            {
                DataCadastro = DateTime.Now,
                Nome = "Skateboarding",
                Status = Models.Enums.Status.Ativo
            };

            Categoria categoria5 = new Categoria
            {
                DataCadastro = DateTime.Now,
                Nome = "Corrida",
                Status = Models.Enums.Status.Ativo
            };

            Categoria categoria6 = new Categoria
            {
                DataCadastro = DateTime.Now,
                Nome = "Social",
                Status = Models.Enums.Status.Ativo
            };

            Categoria categoria7 = new Categoria
            {
                DataCadastro = DateTime.Now,
                Nome = "Basquete",
                Status = Models.Enums.Status.Ativo
            };

            Categoria categoria8 = new Categoria
            {
                DataCadastro = DateTime.Now,
                Nome = "Outro",
                Status = Models.Enums.Status.Ativo
            };

            Cupom cupom1 = new Cupom
            {
                Descricao = "20.00 Aniversário",
                Codigo = "NIVER20",
                Status = Models.Enums.Status.Ativo,
                DataCadastro = DateTime.Now,
                Desconto = 20
            };

            GrupoPrecificacao grupo1 = new GrupoPrecificacao
            {
                Nome = "Outlet",
                Status = Models.Enums.Status.Ativo,
                DataCadastro = DateTime.Now,
                MargemMin = 0,
                MargemMax = 12,
                TipoGrupoPrecificacao = Models.Enums.TipoGrupoPrecificacao.Outlet
            };

            GrupoPrecificacao grupo2 = new GrupoPrecificacao
            {
                Nome = "Lançamento",
                Status = Models.Enums.Status.Ativo,
                DataCadastro = DateTime.Now,
                MargemMin = 10,
                MargemMax = 22,
                TipoGrupoPrecificacao = Models.Enums.TipoGrupoPrecificacao.Lancamento
            };

            GrupoPrecificacao grupo3 = new GrupoPrecificacao
            {
                Nome = "Vigente",
                Status = Models.Enums.Status.Ativo,
                DataCadastro = DateTime.Now,
                MargemMin = 5,
                MargemMax = 10,
                TipoGrupoPrecificacao = Models.Enums.TipoGrupoPrecificacao.Vigente
            };

            FichaTecnica ficha1 = new FichaTecnica
            {
                Altura = Models.Enums.Altura.Baixo,
                Cuidados = "Secar ao sol",
                GarantiaMeses = 12,
                Limpeza = "Agua e sabão",
                Material = "Tecido",
                Palmilha= "EVA",
                Solado = "Borracha"
            };

            FichaTecnica ficha2 = new FichaTecnica
            {
                Altura = Models.Enums.Altura.Baixo,
                Cuidados = "Secar ao sol",
                GarantiaMeses = 3,
                Limpeza = "Agua e sabão",
                Material = "Couro",
                Palmilha = "EVA",
                Solado = "Couro"
            };

            FichaTecnica ficha3 = new FichaTecnica
            {
                Altura = Models.Enums.Altura.Medio,
                Cuidados = "Pano Umido",
                GarantiaMeses = 2,
                Limpeza = "Agua e sabão",
                Material = "Couro",
                Palmilha = "EVA",
                Solado = "Borracha"
            };

            FichaTecnica ficha4 = new FichaTecnica
            {
                Altura = Models.Enums.Altura.Alto,
                Cuidados = "Secar ao sol",
                GarantiaMeses = 6,
                Limpeza = "Agua e sabão",
                Material = "Couro",
                Palmilha = "Borracha",
                Solado = "Couro"
            };

            FichaTecnica ficha5 = new FichaTecnica
            {
                Altura = Models.Enums.Altura.Alto,
                Cuidados = "Secar ao sol",
                GarantiaMeses = 2,
                Limpeza = "Agua e sabão",
                Material = "Tecido",
                Palmilha = "Borracha",
                Solado = "Borracha"
            };


            Cliente admin = new Cliente
            {
                Nome = "Admin",
                Sobrenome = "Admin",
                Cpf = "123.123.123-12",
                DataNascimento = DateTime.Now,
                Status = true,
                Usuario = new Models.Usuario { 
                    Admin = true,
                    DataCadastro = DateTime.Now,
                    Email = "admin@raellshoes.com",
                    Senha = "b75964858590f9c5db8f2044fd34f097"
                }
            };

            Produto produto1 = new Produto
            {
                Nome = "Tênis Adidas Busenitz",
                Modelo = "Az9088",
                Valor = 299.99,
                CodigoBarra = "783462478364237846",
                URLFoto = "Adidas/Tênis Adidas Busenitz/Tenis_Busenitz_Cinza_H03345_01_standard.jpg",
                Descricao = "Produto1",
                Quantidade = 12,
                Status = Models.Enums.Status.Ativo,
                DataCadastro = DateTime.Now,
                GrupoPrecificacao = grupo1,
                Fornecedor = fornecedor1,
                Marca = Models.Enums.Marca.Adidas,
                CorPrimariaProduto = Models.Enums.CorPrimariaProduto.Grafitti,
                CorSecundariaProduto= Models.Enums.CorSecundariaProduto.Branco,
                Genero = Models.Enums.GeneroProduto.Masculino,
                Tamanho = Models.Enums.Tamanho.QuarentaDois,
                FichaTecnica =  ficha1               

            };
            Produto produto2 = new Produto
            {
                Nome = "Tênis Nike Air Force",
                Modelo = "CT23",
                Valor = 399.99,
                CodigoBarra = "525435435345453342",
                URLFoto = "Nike/Tênis Nike Air Force 1 '07 Masculino/1tenis-air-force-1-07-lv8-emb-CT2301-001-1.jpg",
                Descricao = "Produto2",
                Quantidade = 6,
                Status = Models.Enums.Status.Ativo,
                DataCadastro = DateTime.Now,
                GrupoPrecificacao = grupo2,
                Fornecedor = fornecedor2,
                Marca = Models.Enums.Marca.Nike,
                CorPrimariaProduto = Models.Enums.CorPrimariaProduto.Branco,
                CorSecundariaProduto= Models.Enums.CorSecundariaProduto.Preto,
                Genero = Models.Enums.GeneroProduto.Masculino,
                Tamanho = Models.Enums.Tamanho.TrintaNove,
                FichaTecnica =  ficha1               

            };

            Produto produto3 = new Produto
            {
                Nome = "Tênis Adidas Court",
                Modelo = "F36483",
                Valor = 199.99,
                CodigoBarra = "12345678965432333",
                URLFoto = "Adidas/Tênis Adidas Grand Court Base Masculino/adidas.jpg",
                Descricao = "Produto3",
                Quantidade = 6,
                Status = Models.Enums.Status.Ativo,
                DataCadastro = DateTime.Now,
                GrupoPrecificacao = grupo2,
                Fornecedor = fornecedor2,
                Marca = Models.Enums.Marca.Adidas,
                CorPrimariaProduto = Models.Enums.CorPrimariaProduto.Branco,
                CorSecundariaProduto = Models.Enums.CorSecundariaProduto.Branco,
                Genero = Models.Enums.GeneroProduto.Masculino,
                Tamanho = Models.Enums.Tamanho.Quarenta,
                FichaTecnica = ficha3

            };

            Produto produto4 = new Produto
            {
                Nome = "Tênis Nike Court",
                Modelo = "DJ6260",
                Valor = 149.99,
                CodigoBarra = "12345678965432333",
                URLFoto = "Nike/Tênis Nike Court/1tenis-nike-court-vision-lo-DJ6260-001-3-31628872466.jpg",
                Descricao = "Produto4",
                Quantidade = 1,
                Status = Models.Enums.Status.Inativo,
                DataCadastro = DateTime.Now,
                GrupoPrecificacao = grupo3,
                Fornecedor = fornecedor4,
                Marca = Models.Enums.Marca.Nike,
                CorPrimariaProduto = Models.Enums.CorPrimariaProduto.Preto,
                CorSecundariaProduto = Models.Enums.CorSecundariaProduto.Preto,
                Genero = Models.Enums.GeneroProduto.Masculino,
                Tamanho = Models.Enums.Tamanho.Quarenta,
                FichaTecnica = ficha2

            };



            dbContext.AddRange(fornecedor1, fornecedor2, fornecedor3, fornecedor4, fornecedor5);
            dbContext.AddRange(categoria1, categoria2, categoria3, categoria4, categoria5, categoria6, categoria7, categoria8);
            dbContext.AddRange(cupom1);
            dbContext.AddRange(grupo1, grupo2, grupo3);
            dbContext.AddRange(ficha1, ficha2, ficha3, ficha4, ficha5);
            dbContext.AddRange(admin);
            dbContext.AddRange(produto1, produto2, produto3, produto4);

            dbContext.SaveChanges();
        }
    }
}
