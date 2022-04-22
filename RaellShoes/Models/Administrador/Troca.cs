using RaellShoes.Models.Clientes;
using RaellShoes.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RaellShoes.Models.Administrador
{
    public class Troca : EntidadeDominio
    {
       
        public DateTime DataSolicitacao { get; set; }

   
        public Cliente Cliente { get; set; }

       
        public Pedido Pedido { get; set; }

        public ProdutoPedido Produto { get; set; }

      
        public TipoReembolso TipoReembolso { get; set; }

      
        public MetodoColeta MetodoColeta { get; set; }

       
        public StatusPedido Status { get; set; }
        public MotivoTroca MotivoTroca { get; set; }
        public String OutroMotivo { get; set; }
        public Tamanho Tamanho { get; set; }
        public String Comentarios { get; set; }

        [NotMapped]
        public int IddoProduto { get; set; }


        public Troca()
        {

        }

        public Troca(DateTime dataSolicitacao, Cliente cliente, Pedido pedido, ProdutoPedido produto, TipoReembolso tipoReembolso, MetodoColeta metodoColeta, StatusPedido status)
        {
            DataSolicitacao = dataSolicitacao;
            Cliente = cliente;
            Pedido = pedido;
            Produto = produto;
            TipoReembolso = TipoReembolso;
            MetodoColeta = metodoColeta;
            Status = status;
        }
    }
}
