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
                Nome = "Esporte",
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
                Descricao = "10.00 Aniversário RaellShoes",
                Codigo = "NIVER10",
                Status = Models.Enums.Status.Ativo,
                DataCadastro = DateTime.Now,
                Desconto = 10,
                Promocional = true
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
                URLFoto = "Tenis_Busenitz_Cinza_H03345_01_standard.jpg",
                Descricao = "O melhor conseguiu se superar. " +
                "\nA nova versão do tênis assinado pelo lendário skatista Dennis Busenitz sobe um nível em relação ao original com ainda mais amortecimento e durabilidade. " +
                "\nCaso você precise pisar no freio repentinamente, a biqueira resistente à abrasão te dá cobertura.",
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
                FichaTecnica =  ficha1 ,
                Categoria = categoria4

            };
            Produto produto2 = new Produto
            {
                Nome = "Tênis Nike Air Max Force",
                Modelo = "CT23",
                Valor = 399.99,
                CodigoBarra = "525435435345453342",
                URLFoto = "1tenis-air-force-1-07-lv8-emb-CT2301-001-1.jpg",
                Descricao = "LOOK RETRÔ. CONFORTO CONTEMPORÂNEO. " +
                "\nApresentando um design casual, o look de herança do atletismo e, claro, amortecimento Air visível, o Nike Air Max SC é o melhor complemento para qualquer outfit. " +
                "\nA rica mistura de materiais acrescenta profundidade, ao mesmo tempo que faz dele um tênis durável e leve para uso diário." +
                "\nBenefíciosO couro legítimo e sintético combina com a tela para uma construção durável, respirável e confortável de usar o dia todo." +
                "\nOriginalmente projetada para a corrida, a unidade Max Air proporciona um amortecimento leve a cada passo.A entressola de espuma acrescenta amortecimento duradouro." +
                "\nA sola de borracha oferece tração e durabilidade." +
                "\nDetalhes do produto:" +
                "\nAmarração de cadarços tradicionalOs sulcos flexíveis na sola permitem que o pé se movimente naturalmenteOrigens do Nike Air Max" +
                "\nA revolucionária tecnologia Air apareceu pela primeira vez nos calçados Nike em 1978. Em 1987, o Air Max 1 estreou com a tecnologia Air visível no seu calcanhar, permitindo que os fãs não só sentissem o amortecimento do Air, mas pudessem vê-lo." +
                "\nDesde então, cada nova geração do Air Max tem sido uma sensação entre atletas e colecionadores, oferecendo combinações impressionantes de cor e um amortecimento confiável e leve.",
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
                FichaTecnica =  ficha1,
                Categoria = categoria1

            };

            Produto produto3 = new Produto
            {
                Nome = "Tênis Adidas Court",
                Modelo = "F36483",
                Valor = 199.99,
                CodigoBarra = "12345678965432333",
                URLFoto = "adidas.jpg",
                Descricao = "Este tênis inspirado nos anos 70 tem cabedal sintético macio. " +
                "\nEle exibe as Três Listras perfuradas em um dos lados e costuradas em contraste do outro. " +
                "\nO Tênis adidas possui entressola e solado emborrachados que oferecem aderência e estabilidade em todas as superfícies.",
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
                FichaTecnica = ficha3,
                Categoria = categoria3

            };

            Produto produto4 = new Produto
            {
                Nome = "Tênis Nike Court Vision",
                Modelo = "DJ6260",
                Valor = 149.99,
                CodigoBarra = "12345678965432333",
                URLFoto = "1tenis-nike-court-vision-lo-DJ6260-001-3-31628872466.jpg",
                Descricao = "Então você é apaixonado pelo look clássico do basquete dos anos 80, mas também tem uma forte queda pela cultura de ritmo rápido do esporte contemporâneo. " +
                "\nConheça o novo Nike Court Vision Low. " +
                "\nEle apresenta uma parte de cima versátil e sobreposições costuradas inspiradas nos arremessos de bandeja do basquete das antigas, enquanto a boca extremamente macia e de corte baixo confere um look elegante e confortável para o dia a dia.",
                Quantidade = 1,
                Status = Models.Enums.Status.Ativo,
                DataCadastro = DateTime.Now,
                GrupoPrecificacao = grupo3,
                Fornecedor = fornecedor4,
                Marca = Models.Enums.Marca.Nike,
                CorPrimariaProduto = Models.Enums.CorPrimariaProduto.Preto,
                CorSecundariaProduto = Models.Enums.CorSecundariaProduto.Preto,
                Genero = Models.Enums.GeneroProduto.Masculino,
                Tamanho = Models.Enums.Tamanho.Quarenta,
                FichaTecnica = ficha2,
                Categoria = categoria4
            };  
            
            Produto produto5 = new Produto
            {
                Nome = "Tênis Air Jordan",
                Modelo = "H85MASC",
                Valor = 549.99,
                CodigoBarra = "123445675489654352333",
                URLFoto = "1tenis-air-jordan-1-high-85-masculino-BQ4422-400-5-51643217806.jpg",
                Descricao = "Entregue-se ao conforto do Air Jordan 1 Zoom Air Comfort. " +
                "\nAperfeiçoado para tornar um dos tênis mais icônicos da história mais usável, ele combina couro de grão integral na parte de cima com um forro aconchegante e amortecimento ágil.",
                Quantidade = 12,
                Status = Models.Enums.Status.Ativo,
                DataCadastro = DateTime.Now,
                GrupoPrecificacao = grupo1,
                Fornecedor = fornecedor1,
                Marca = Models.Enums.Marca.Nike,
                CorPrimariaProduto = Models.Enums.CorPrimariaProduto.Azul,
                CorSecundariaProduto = Models.Enums.CorSecundariaProduto.Branco,
                Genero = Models.Enums.GeneroProduto.Masculino,
                Tamanho = Models.Enums.Tamanho.Quarenta,
                FichaTecnica = ficha2,
                Categoria = categoria5
            };

            Produto produto6 = new Produto
            {
                Nome = "Tênis New Balance Bege",
                Modelo = "N4374",
                Valor = 249.99,
                CodigoBarra = "123445675489654352333",
                URLFoto = "NewBege.png",
                Descricao = "Da caminhada às corridas, o novo Tênis da New Balance é a pedida para você superar seus limites em busca do melhor pace. " +
                "\nCom design moderno, o modelo possui cabedal confeccionado com material respirável e detalhes em sintético para melhor estrutura e suporte. " +
                "\nO calcanhar acolchoado com puxador garante conforto e fácil calce. A entressola junto ao solado em EVA garante amortecimento leve e suavidade entre uma passada e outra. " +
                "\nNa esteira ou na rua, aposte no running da New Balance para ir mais longe. Aproveite!",
                Quantidade = 1,
                Status = Models.Enums.Status.Inativo,
                DataCadastro = DateTime.Now,
                GrupoPrecificacao = grupo1,
                Fornecedor = fornecedor1,
                Marca = Models.Enums.Marca.NewBalance,
                CorPrimariaProduto = Models.Enums.CorPrimariaProduto.Bege,
                CorSecundariaProduto = Models.Enums.CorSecundariaProduto.Branco,
                Genero = Models.Enums.GeneroProduto.Unissex,
                Tamanho = Models.Enums.Tamanho.TrintaNove,
                FichaTecnica = ficha2,
                Categoria = categoria6
            };
            
            Produto produto7 = new Produto
            {
                Nome = "Tênis Eco Run Kids",
                Modelo = "ECK4736",
                Valor = 209.99,
                CodigoBarra = "34324324324324",
                URLFoto = "1tenis-nike-eco-run-tdv-DC5862-500-1-11638989187.jpg",
                Descricao = "O Tênis Infantil Nike Eco Run Unissex é pensado para a criançada que está sempre em movimento! " +
                "\nO material em mesh auxilia na flexibilidade e na ventilação interna, enquanto a palmilha leve fornece conforto em cada passo. " +
                "\nO design esportivo dá um up no visual. Compre já esse tênis infantil Nike unissex!",
                Quantidade = 2,
                Status = Models.Enums.Status.Ativo,
                DataCadastro = DateTime.Now,
                GrupoPrecificacao = grupo3,
                Fornecedor = fornecedor4,
                Marca = Models.Enums.Marca.Nike,
                CorPrimariaProduto = Models.Enums.CorPrimariaProduto.Azul,
                CorSecundariaProduto = Models.Enums.CorSecundariaProduto.Branco,
                Genero = Models.Enums.GeneroProduto.Unissex,
                Tamanho = Models.Enums.Tamanho.TrintaTres,
                FichaTecnica = ficha4,
                Categoria = categoria7
            };
            
            Produto produto8 = new Produto
            {
                Nome = "Tênis Nike Court Vision",
                Modelo = "CV64735",
                Valor = 299.99,
                CodigoBarra = "34324324324324",
                URLFoto = "1tenis-w-nike-court-vision-lo-be-DH3158-102-1-11637853827.jpg",
                Descricao = "Então você é apaixonado pelo look clássico do basquete dos anos 80, mas também tem uma forte queda pela cultura de ritmo rápido do esporte contemporâneo. " +
                "\nConheça o novo Nike Court Vision Low. " +
                "\nEle apresenta uma parte de cima versátil e sobreposições costuradas inspiradas nos arremessos de bandeja do basquete das antigas, enquanto a boca extremamente macia e de corte baixo confere um look elegante e confortável para o dia a dia.",
                Quantidade = 3,
                Status = Models.Enums.Status.Ativo,
                DataCadastro = DateTime.Now,
                GrupoPrecificacao = grupo3,
                Fornecedor = fornecedor4,
                Marca = Models.Enums.Marca.Nike,
                CorPrimariaProduto = Models.Enums.CorPrimariaProduto.Azul,
                CorSecundariaProduto = Models.Enums.CorSecundariaProduto.Branco,
                Genero = Models.Enums.GeneroProduto.Feminino,
                Tamanho = Models.Enums.Tamanho.TrintaSeis,
                FichaTecnica = ficha4,
                Categoria = categoria7
            };

            Produto produto9 = new Produto
            {
                Nome = "Tênis Mizuno Way",
                Modelo = "Way356",
                Valor = 599.99,
                CodigoBarra = "34343424324324324",
                URLFoto = "D16-7769-124_zoom1.jpg",
                Descricao = "Para quem sempre está em movimento, o Tênis Mizuno Way chega em sua nova versão pensando na qualidade e estabilidade. " +
                "A pessoa que busca amortecimento responsivo para uma corrida performance, confeccionado em material resistente e durável, esse tênis de corrida tem cabedal em Mesh, garantindo respirabilidade. " +
                "\nEntressola com amortecimento U4ic, eva leve com alta absorção de impactos. " +
                "\nO solado possui a borracha Smooth ride, para durabilidade e maior tração durante o contato solado e solo. Não deixe de aproveitar para adquirir o melhor tênis performance para a sua corrida diária, aposte na Mizuno!",
                Quantidade = 5,
                Status = Models.Enums.Status.Ativo,
                DataCadastro = DateTime.Now,
                GrupoPrecificacao = grupo2,
                Fornecedor = fornecedor3,
                Marca = Models.Enums.Marca.Mizuno,
                CorPrimariaProduto = Models.Enums.CorPrimariaProduto.Azul,
                CorSecundariaProduto = Models.Enums.CorSecundariaProduto.Branco,
                Genero = Models.Enums.GeneroProduto.Unissex,
                Tamanho = Models.Enums.Tamanho.QuarentaQuatro,
                FichaTecnica = ficha5,
                Categoria = categoria1
            };

            Produto produto10 = new Produto
            {
                Nome = "Tênis New Balance Rose",
                Modelo = "N4374R",
                Valor = 249.99,
                CodigoBarra = "1234456754896543523333",
                URLFoto = "New.jpeg",
                Descricao = "Da caminhada às corridas, o novo Tênis da New Balance é a pedida para você superar seus limites em busca do melhor pace. " +
                "\nCom design moderno, o modelo possui cabedal confeccionado com material respirável e detalhes em sintético para melhor estrutura e suporte. " +
                "\nO calcanhar acolchoado com puxador garante conforto e fácil calce. A entressola junto ao solado em EVA garante amortecimento leve e suavidade entre uma passada e outra. " +
                "\nNa esteira ou na rua, aposte no running da New Balance para ir mais longe. Aproveite!",
                Quantidade = 4,
                Status = Models.Enums.Status.Ativo,
                DataCadastro = DateTime.Now,
                GrupoPrecificacao = grupo1,
                Fornecedor = fornecedor4,
                Marca = Models.Enums.Marca.NewBalance,
                CorPrimariaProduto = Models.Enums.CorPrimariaProduto.Vermelho,
                CorSecundariaProduto = Models.Enums.CorSecundariaProduto.Branco,
                Genero = Models.Enums.GeneroProduto.Feminino,
                Tamanho = Models.Enums.Tamanho.TrintaOito,
                FichaTecnica = ficha2,
                Categoria = categoria2
            };

            Produto produto11 = new Produto
            {
                Nome = "Tênis New Balance Gray",
                Modelo = "N4374RG",
                Valor = 249.99,
                CodigoBarra = "1234456754896543523333",
                URLFoto = "NewCinza.jpeg",
                Descricao = "Da caminhada às corridas, o novo Tênis da New Balance é a pedida para você superar seus limites em busca do melhor pace. " +
                "\nCom design moderno, o modelo possui cabedal confeccionado com material respirável e detalhes em sintético para melhor estrutura e suporte. " +
                "\nO calcanhar acolchoado com puxador garante conforto e fácil calce. A entressola junto ao solado em EVA garante amortecimento leve e suavidade entre uma passada e outra. " +
                "\nNa esteira ou na rua, aposte no running da New Balance para ir mais longe. Aproveite!",
                Quantidade = 4,
                Status = Models.Enums.Status.Ativo,
                DataCadastro = DateTime.Now,
                GrupoPrecificacao = grupo2,
                Fornecedor = fornecedor2,
                Marca = Models.Enums.Marca.NewBalance,
                CorPrimariaProduto = Models.Enums.CorPrimariaProduto.Grafitti,
                CorSecundariaProduto = Models.Enums.CorSecundariaProduto.Branco,
                Genero = Models.Enums.GeneroProduto.Masculino,
                Tamanho = Models.Enums.Tamanho.QuarentaDois,
                FichaTecnica = ficha1,
                Categoria = categoria1
            };

            Produto produto12 = new Produto
            {
                Nome = "Tênis Adidas Forum Bold",
                Modelo = "ADD6483",
                Valor = 599.99,
                CodigoBarra = "12345678965432333",
                URLFoto = "Tenis_Forum_Bold_HER_Studio_London_Branco_H00472_01_standard.jpg",
                Descricao = "Este tênis inspirado nos anos 70 tem cabedal sintético macio. " +
               "\nEle exibe o logo clássico em um dos lados e costuradas em contraste do outro. " +
               "\nO Tênis adidas possui entressola e solado emborrachados que oferecem aderência e estabilidade em todas as superfícies.",
                Quantidade = 2,
                Status = Models.Enums.Status.Ativo,
                DataCadastro = DateTime.Now,
                GrupoPrecificacao = grupo1,
                Fornecedor = fornecedor1,
                Marca = Models.Enums.Marca.Adidas,
                CorPrimariaProduto = Models.Enums.CorPrimariaProduto.Branco,
                CorSecundariaProduto = Models.Enums.CorSecundariaProduto.Branco,
                Genero = Models.Enums.GeneroProduto.Feminino,
                Tamanho = Models.Enums.Tamanho.TrintaQuatro,
                FichaTecnica = ficha3,
                Categoria = categoria2

            };
            Produto produto13 = new Produto
            {
                Nome = "Tênis Adidas Superstar",
                Modelo = "ADT76",
                Valor = 599.99,
                CodigoBarra = "1234563278965432333",
                URLFoto = "Tenis_Superstar_Preto_EG4957_01_standard.jpg",
                Descricao = "Este tênis inspirado nos anos 70 tem cabedal sintético macio. " +
               "\nEle exibe as listras em um dos lados e costuradas em contraste do outro. " +
               "\nO Tênis adidas possui entressola e solado emborrachados que oferecem aderência e estabilidade em todas as superfícies.",
                Quantidade = 2,
                Status = Models.Enums.Status.Ativo,
                DataCadastro = DateTime.Now,
                GrupoPrecificacao = grupo1,
                Fornecedor = fornecedor5,
                Marca = Models.Enums.Marca.Adidas,
                CorPrimariaProduto = Models.Enums.CorPrimariaProduto.Preto,
                CorSecundariaProduto = Models.Enums.CorSecundariaProduto.Branco,
                Genero = Models.Enums.GeneroProduto.Unissex,
                Tamanho = Models.Enums.Tamanho.TrintaNove,
                FichaTecnica = ficha3,
                Categoria = categoria8

            };
            Produto produto14 = new Produto
            {
                Nome = "Tênis Adidas Superstar",
                Modelo = "ADT76",
                Valor = 599.99,
                CodigoBarra = "1234563278965432333",
                URLFoto = "Tenis_Superstar_Pride_Branco_GW2415_01_standard.jpg",
                Descricao = "Este tênis inspirado nos anos 70 tem cabedal sintético macio. " +
               "\nEle exibe as listras em um dos lados e costuradas em contraste do outro. " +
               "\nO Tênis adidas possui entressola e solado emborrachados que oferecem aderência e estabilidade em todas as superfícies.",
                Quantidade = 0,
                Status = Models.Enums.Status.Inativo,
                DataCadastro = DateTime.Now,
                GrupoPrecificacao = grupo1,
                Fornecedor = fornecedor5,
                Marca = Models.Enums.Marca.Adidas,
                CorPrimariaProduto = Models.Enums.CorPrimariaProduto.Branco,
                CorSecundariaProduto = Models.Enums.CorSecundariaProduto.Branco,
                Genero = Models.Enums.GeneroProduto.Unissex,
                Tamanho = Models.Enums.Tamanho.TrintaSeis,
                FichaTecnica = ficha3,
                Categoria = categoria8

            };
            Produto produto15 = new Produto
            {
                Nome = "Tênis Adidas VS Switch",
                Modelo = "VSW4235",
                Valor = 199.99,
                CodigoBarra = "1234563278965432333",
                URLFoto = "Tenis_VS_Switch_(UNISSEX)_Branco_GW2978_01_standard.jpg",
                Descricao = "Este tênis inspirado nos anos 70 tem cabedal sintético macio. " +
               "\nEle exibe as listras em um dos lados e costuradas em contraste do outro. " +
               "\nO Tênis adidas possui entressola e solado emborrachados que oferecem aderência e estabilidade em todas as superfícies.",
                Quantidade = 0,
                Status = Models.Enums.Status.Inativo,
                DataCadastro = DateTime.Now,
                GrupoPrecificacao = grupo3,
                Fornecedor = fornecedor2,
                Marca = Models.Enums.Marca.Adidas,
                CorPrimariaProduto = Models.Enums.CorPrimariaProduto.Branco,
                CorSecundariaProduto = Models.Enums.CorSecundariaProduto.Branco,
                Genero = Models.Enums.GeneroProduto.Unissex,
                Tamanho = Models.Enums.Tamanho.TrintaTres,
                FichaTecnica = ficha1,
                Categoria = categoria5

            };

            dbContext.AddRange(fornecedor1, fornecedor2, fornecedor3, fornecedor4, fornecedor5);
            dbContext.AddRange(categoria1, categoria2, categoria3, categoria4, categoria5, categoria6, categoria7, categoria8);
            dbContext.AddRange(cupom1);
            dbContext.AddRange(grupo1, grupo2, grupo3);
            dbContext.AddRange(ficha1, ficha2, ficha3, ficha4, ficha5);
            dbContext.AddRange(admin);
            dbContext.AddRange(produto1, produto2, produto3, produto4, produto5, produto6, produto7, produto8, produto9, produto10, produto11, produto12, produto13, produto14,produto15);

            dbContext.SaveChanges();
        }
    }
}
