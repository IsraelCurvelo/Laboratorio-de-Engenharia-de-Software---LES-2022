using RaellShoes.Models.Administrador;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace RaellShoes.Models.ViewModel
{
    public class DashViewModel
    {
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }
        public bool MostrarGrafico { get; set; }
        public List<Categoria> Categorias { get; set; }       
        public string[,] TabelaGrafico { get; set; }

        public bool Basquete { get; set; }
        public bool Treino { get; set; }
        public bool Casual { get; set; }
        public bool Social { get; set; }
        public bool Skateboarding { get; set; }
        public bool Corrida { get; set; }       
        public bool Outro { get; set; }

        public DataTable Tabela { get; set; }

        public DashViewModel()
        {
            Categorias = new List<Categoria>();            
        }

        public DashViewModel(DateTime dataInicio, DateTime dataFinal, bool mostrarGrafico)
        {
            DataInicio = dataInicio;
            DataFinal = dataFinal;
            MostrarGrafico = mostrarGrafico;
            Categorias = new List<Categoria>();
            
        }

        public DashViewModel(DateTime dataInicio, DateTime dataFinal, bool mostrarGrafico, bool basquete, bool treino, bool casual, bool social, bool skateboarding, bool corrida, bool outro) : this(dataInicio, dataFinal, mostrarGrafico)
        {
            Basquete = basquete;
            Treino = treino;
            Casual = casual;
            Social = social;
            Skateboarding = skateboarding;
            Corrida = corrida;
            Outro = outro;
        }
    }
}
