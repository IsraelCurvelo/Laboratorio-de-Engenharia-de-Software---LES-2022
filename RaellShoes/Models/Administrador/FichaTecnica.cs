using RaellShoes.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RaellShoes.Models.Administrador
{
    public class FichaTecnica
    {
        [Required(ErrorMessage = "{0} obrigatório")]
        public String Material { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public String Palmilha { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public String Solado { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public int GarantiaMeses { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public Altura Altura { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public String Limpeza { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public String Cuidados { get; set; }

        public FichaTecnica()
        {

        }

        public FichaTecnica(string material, string palmilha, string solado, int meses, Altura altura, string limpeza, string cuidados)
        {
            Material = material;
            Palmilha = palmilha;
            Solado = solado;
            GarantiaMeses = meses;
            Altura = altura;
            Limpeza = limpeza;
            Cuidados = cuidados;
        }

    }
}
