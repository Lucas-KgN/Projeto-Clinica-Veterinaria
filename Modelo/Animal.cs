using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Animal
    {
        public int AnimalID { get; set; }
        public int ClienteID { get; set; }

        public string Nome { get; set; }
        public double Idade { get; set; }
        public string Tipo { get; set; }
        public string Raca { get; set; }

        public Cliente Dono;
    }
}
