using RaellShoes.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace RaellShoes.Models.Clientes
{
    public class Endereco : EntidadeDominio
    {
        [Required(ErrorMessage = "{0} obrigatório")]
        [Display(Name = "Apelido do Endereço")]
        public String Apelido { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]       
        public String Logradouro { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [Display(Name = "Número")]
        public String Numero { get; set; }

      
        public String Complemento { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]     
        public String Bairro { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]    
        [StringLength(9, MinimumLength = 8, ErrorMessage = "O {0} deve conter {2}caracteres")]
        public String Cep { get; set; }

        public String Observacoes { get; set; }

        public Cidade Cidade { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public TipoResidencia TipoResidencia { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public TipoLogradouro TipoLogradouro { get; set; }

      
        public TipoEndereco TipoEndereco  { get; set; }

        public int ClienteId { get; set; }

        public bool CadastroInicial { get; set; }

        public Endereco()
        {
        }

        public Endereco(string apelido, string logradouro, string numero, string complemento, string bairro, string cep, string observacoes,
            Cidade cidade, TipoResidencia tipoResidencia, TipoLogradouro tipoLogradouro, TipoEndereco tipoEndereco)
        {
            Apelido = apelido;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cep = cep;
            Observacoes = observacoes;
            Cidade = cidade;
            TipoResidencia = tipoResidencia;
            TipoLogradouro = tipoLogradouro;
            TipoEndereco = tipoEndereco;
        }
    }
}
