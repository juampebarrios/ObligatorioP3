using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class FichaCuidado
    {
        public int idFicha { get; set; }
        public string FrecuenciaRiego { get; set; }
        public string TipoIluminacion { get; set; }
        public int Temperatura { get; set; }
        public Planta miPlanta { get; set; }

        public FichaCuidado() { }

        public FichaCuidado(string fr, string ti, int temp, Planta p) 
        {
            this.FrecuenciaRiego = fr;
            this.TipoIluminacion = ti;
            this.Temperatura = temp;
            this.miPlanta = p;
        }
    }
}
