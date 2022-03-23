using RaellShoes.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RaellShoes.Models.Administrador
{
    public class GrupoPrecificacao
    {
        [Required(ErrorMessage = "{0} obrigatório")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public Status Status { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public DateTime DataCadastro { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [Display(Name = "Margem Min.(%)")]
        public int MargemMin { get; set; }

        [Display(Name = "Margem Max.(%)")]
        [Required(ErrorMessage = "{0} obrigatório")]
        public int MargemMax { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public TipoGrupoPrecificacao TipoGrupoPrecificacao { get; set; }

        public GrupoPrecificacao()
        {

        }

        public GrupoPrecificacao(string nome, Status status, DateTime dataCadastro, int margemMin, int margemMax, TipoGrupoPrecificacao tipoGrupoPrecificacao)
        {
            Nome = nome;
            Status = status;
            DataCadastro = dataCadastro;
            MargemMin = margemMin;
            MargemMax = margemMax;
            TipoGrupoPrecificacao = tipoGrupoPrecificacao;
        }
    }
}
