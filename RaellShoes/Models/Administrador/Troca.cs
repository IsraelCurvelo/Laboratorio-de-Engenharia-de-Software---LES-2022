using RaellShoes.Models.Clientes;
using RaellShoes.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RaellShoes.Models.Administrador
{
    public class Troca : EntidadeDominio
    {
        [Required(ErrorMessage = "{0} obrigatório")]
        public DateTime DataSolicitacao { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public Cliente Cliente { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public Pedido Pedido { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public Produto Produto { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public TipoReembolso TipoReembolso { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public MetodoColeta MetodoColeta { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public StatusPedido Status { get; set; }


        public Troca()
        {

        }

        public Troca(DateTime dataSolicitacao, Cliente cliente, Pedido pedido, Produto produto, TipoReembolso tipoReembolso, MetodoColeta metodoColeta, StatusPedido status)
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
