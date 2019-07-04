using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Caixa
    {
        public int CaixaID { get; set; }
        public int ContasAReceberID { get; set; }
        public double ValorTotal { get; set; }
        public DateTime Data { get; set; }
    }
}
