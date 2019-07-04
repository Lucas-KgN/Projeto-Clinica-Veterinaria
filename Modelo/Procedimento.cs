using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Procedimento
    {   
        public int ProcedimentoID { get; set; }
        public int ExameID { get; set; }
        public int ClienteID { get; set; }
        public int AnimalID { get; set; }
        
        public DateTime Data { get; set; }
    }
}
