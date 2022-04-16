using RaellShoes.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RaellShoes.Models.Administrador
{
    public class ProdutoPedido : EntidadeDominio
    {
        
        public String Nome { get; set; }

        
        public String Modelo { get; set; }       

       
        public Double Valor { get; set; }

       
        [Display(Name ="Código de Barras")]
        public String CodigoBarra { get; set; }

      
        public String URLFoto { get; set; }

       
        public String Descricao { get; set; }

       
        public int Quantidade { get; set; }
       
        public int QuantidadeCarrinho { get; set; }
        
        public double ValorSubtotal { get; set; }

       
        public Status Status { get; set; }

            
        public GrupoPrecificacao GrupoPrecificacao { get; set; }        

       
        public Fornecedor Fornecedor { get; set; }

        
        public Marca Marca { get; set; }

   
        [Display(Name = "Cor Primária")]
        public CorPrimariaProduto CorPrimariaProduto { get; set; }

      
        [Display(Name = "Cor Secundária")]
        public CorSecundariaProduto CorSecundariaProduto { get; set; }

     
        [Display(Name = "Gênero")]
        public GeneroProduto Genero { get; set; }

        public Tamanho Tamanho { get; set; }

      
        public FichaTecnica FichaTecnica { get; set; }


        public int PedidoId { get; set; }

        public int ProdutoEstoqueId { get; set; }

        public ProdutoPedido()
        {
        }
       

        public ProdutoPedido(string nome, string modelo, double valor, string codigoBarra, string url, string descricao, int quantidade, Status status,
            GrupoPrecificacao grupoPrecificacao, Fornecedor fornecedor, Marca marca, CorPrimariaProduto corPrimariaProduto, CorSecundariaProduto corSecundariaProduto,
            GeneroProduto generoProduto, Tamanho tamanho, FichaTecnica fichaTecnica, int pedidoId, int produtoEstoqueId)
        {
            Nome = nome;
            Modelo = modelo;
            CodigoBarra = codigoBarra;
            Valor = valor;
            URLFoto = url;
            Descricao = descricao;
            Quantidade = quantidade;
            Status = status;           
            GrupoPrecificacao = grupoPrecificacao;
            Fornecedor = fornecedor;
            Marca = marca;
            CorPrimariaProduto = corPrimariaProduto;
            CorSecundariaProduto = corSecundariaProduto;
            Genero = generoProduto;
            Tamanho = tamanho;
            FichaTecnica = fichaTecnica;
            PedidoId = pedidoId;
            ProdutoEstoqueId = produtoEstoqueId;
    } 
    }
}
