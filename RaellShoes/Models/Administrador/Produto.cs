using RaellShoes.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RaellShoes.Models.Administrador
{
    public class Produto
    {
        [Required(ErrorMessage = "{0} obrigatório")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public String Modelo { get; set; }       

        [Required(ErrorMessage = "{0} obrigatório")]
        public int Valor { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [Display(Name ="Código de Barras")]
        public String CodigoBarra { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public String URLFoto { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public String Descricao { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public Status Status { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public DateTime DataCadastro { get; set; }


        [Required(ErrorMessage = "{0} obrigatório")]
        public GrupoPrecificacao GrupoPrecificacao { get; set; }        

        [Required(ErrorMessage = "{0} obrigatório")]
        public Fornecedor Fornecedor { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public Marca Marca { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [Display(Name = "Cor Primária")]
        public CorPrimariaProduto CorPrimariaProduto { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [Display(Name = "Cor Secundária")]
        public CorSecundariaProduto CorSecundariaProduto { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [Display(Name = "Gênero")]
        public GeneroProduto Genero { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public Tamanho Tamanho { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public FichaTecnica FichaTecnica { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public List<Categoria> Categorias { get; set; }

        public Produto()
        {
            Categorias = new List<Categoria>();
        }

        public Produto(string nome, string modelo, int valor, string codigoBarra, string url, string descricao, int quantidade, Status status,
            DateTime dataCadastro, GrupoPrecificacao grupoPrecificacao, Fornecedor fornecedor, Marca marca, CorPrimariaProduto corPrimariaProduto, CorSecundariaProduto corSecundariaProduto,
            GeneroProduto generoProduto, Tamanho tamanho, FichaTecnica fichaTecnica, List<Categoria> categorias)
        {
            Categorias = new List<Categoria>();
            Nome = nome;
            Modelo = modelo;
            CodigoBarra = codigoBarra;
            Valor = valor;
            URLFoto = url;
            Descricao = descricao;
            Quantidade = quantidade;
            Status = status;
            DataCadastro = dataCadastro;
            GrupoPrecificacao = grupoPrecificacao;
            Fornecedor = fornecedor;
            Marca = marca;
            CorPrimariaProduto = corPrimariaProduto;
            CorSecundariaProduto = corSecundariaProduto;
            Genero = generoProduto;
            Tamanho = tamanho;
            FichaTecnica = fichaTecnica;

            foreach (var item in categorias)
            {
                Categorias.Add(item);
            }
        } 
    }
}
