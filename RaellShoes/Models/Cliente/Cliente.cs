using RaellShoes.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RaellShoes.Models.Clientes
{
    public class Cliente : EntidadeDominio
    {
        [Required(ErrorMessage = "{0} obrigatório")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public String Sobrenome { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [Display(Name = "CPF")]
        [StringLength(14, MinimumLength = 11, ErrorMessage = "O CPF deve conter 11 caracteres")]
        public String Cpf { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "{0} obrigatório")]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        public bool Status { get; set; }

        public bool FlagEntrega { get; set; }

        public bool FlagCobranca { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public Genero Genero { get; set; }
        
        public Usuario Usuario { get; set; }

        public Telefone Telefone { get; set; }  
        
        public Cartao Cartao { get; set; }

        public List<Endereco> Enderecos { get; set; }

        [NotMapped]
        public Endereco Endereco { get; set; }
        [NotMapped]
        public Endereco EnderecoEntrega { get; set; }
        [NotMapped]
        public Endereco EnderecoCobranca { get; set; }

        public Cliente()
        {
             
        }
        
        public Cliente(String nome, String sobrenome, String cpf, DateTime dataNascimento, Genero genero, 
            Usuario usuario, Telefone telefone, bool flagEntrega, bool flagCobranca, Endereco endereco)
        {
            Status = true;
            Nome = nome;
            Sobrenome = sobrenome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            Genero = genero;
            Usuario = usuario;
            Telefone = telefone;
            FlagCobranca = flagCobranca;
            FlagEntrega = flagEntrega;
            Endereco = endereco;          
           
        }



    }
}
