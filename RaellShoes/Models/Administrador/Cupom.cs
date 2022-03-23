﻿using RaellShoes.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RaellShoes.Models.Administrador
{
    public class Cupom
    {
        [Required(ErrorMessage = "{0} obrigatório")]
        public String Descricao { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public Status Status { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public DateTime DataCadastro { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public String Codigo { get; set; }

        public Cupom()
        {

        }

        public Cupom(string nome, Status status, DateTime dataCadastro, string codigo)
        {
            Descricao = nome;
            Status = status;
            DataCadastro = dataCadastro;
            Codigo = codigo;
        }
    }
}
