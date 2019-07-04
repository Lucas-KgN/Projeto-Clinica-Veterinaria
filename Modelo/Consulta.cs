using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Consulta
    {
        public int ConsultaID { get; set; }

        public int ClienteID { get; set; }
        public int AnimalID { get; set; }
        public int VeterinarioID { get; set; }

        public string NomeVeterinario { get; set; }
        public string NomeDono { get; set; } 
        public string NomePet { get; set; }

        public string Resumo { get; set; }
        public string Remedios { get; set; }
        public double ValorConsulta { get; set; }
        public DateTime Data { get; set; }
    }
}
