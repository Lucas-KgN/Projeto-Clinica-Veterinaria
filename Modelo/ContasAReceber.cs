using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class ContasAReceber
    {   
        public int ContasAReceberID { get; set; }
        public int ClienteID { get; set; }
        public bool Pago { get; set; }
        public string NomeCliente { get; set; }
        public double Valor { get; set; }
        public DateTime Data { get; set; }
    }
}
