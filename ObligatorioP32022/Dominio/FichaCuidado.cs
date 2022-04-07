using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class FichaCuidado
    {
        public int idFicha { get; set; }
        public string  FrecuenciaRiego { get; set; }
        public string TipoIluminacion { get; set; }
        public int Temperatura { get; set; }
    }
}
