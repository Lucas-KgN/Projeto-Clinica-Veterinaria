using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Exame
    {
        public int ExameID { get; set; }
       
        public string NomeExame { get; set; }
        public string Objetivo { get; set; }
        public string TempoExecucao { get; set; }
        public double Valor { get; set; }
        
    }
}
