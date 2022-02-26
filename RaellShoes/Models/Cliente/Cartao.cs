using RaellShoes.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace RaellShoes.Models.Clientes
{
    public class Cartao : EntidadeDominio
    {
        public String Apelido { get; set; }
        
        public String NomeImpresso { get; set; }
        
        public String CodigoSeguranca { get; set; }
        
        public String Numero { get; set; }
        
        public String Validade { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public bool Preferencial { get; set; }
        
        public TipoCartao TipoCartao { get; set; }

        public Bandeira Bandeira { get; set; }

        public int ClienteId { get; set; }

        public Cartao()
        {
        }

        public Cartao(string apelido, string nomeImpresso, string codigoSeguranca, string numero, string validade, TipoCartao tipoCartao, Bandeira bandeira)
        {
            Apelido = apelido;
            NomeImpresso = nomeImpresso;
            CodigoSeguranca = codigoSeguranca;
            Numero = numero;
            Validade = validade;
            TipoCartao = tipoCartao;
            Bandeira = bandeira;
        }
    }
}
