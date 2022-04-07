using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Planta
    {
        public int IdPlanta { get; set; }
        public TipoPlanta MiTipoPlanta { get; set; }
        public string NombreCientifico { get; set; }
        public string NombreVulgar { get; set; }
        public string Descripcion { get; set; }

        public string Ambiente { get; set; }
        public double AlturaMax { get; set; }
        public string Foto { get; set; }
        public double Precio { get; set; }
        public FichaCuidado MiFichaCuidado { get; set; }
    }
}
