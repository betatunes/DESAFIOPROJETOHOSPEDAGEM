using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagem.Models
{
    public class Suite
    {

        public Suite(string tiposuite, int capacidade, decimal valordiaria)
        {
            TipoSuite = tiposuite;
            Capacidade = capacidade;
            ValorDiaria = valordiaria;
        }


        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }

        public decimal  ValorDiaria { get; set; }
    }
}