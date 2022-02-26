using System;
using System.ComponentModel.DataAnnotations;

namespace RaellShoes.Models
{
    public class Usuario : EntidadeDominio
    {
        [Required(ErrorMessage = "{0} obrigatório")]
        [EmailAddress(ErrorMessage = "Digite um email válido")]
        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }

        [Required(ErrorMessage = "{0} obrigatória")]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "A Senha deve ser composta de pelo menos {2} caracteres, ter letras maiúsculas e minúsculas e também conter caracteres especiais.")]
        public String Senha { get; set; }
    }
}
