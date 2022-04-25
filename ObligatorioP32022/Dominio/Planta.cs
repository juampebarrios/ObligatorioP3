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
        public FichaCuidado FichaCuidado { get; set; }
        public string imagen { get; set; }
        public string Descripcion { get; set; }
        public string Ambiente { get; set; }
        public double AlturaMax { get; set; }
        public string Foto { get; set; }
        public double Precio { get; set; }

        public Planta()
        {
        }
        public Planta(//int id,
                      string nom, string nomv, TipoPlanta tipoPlanta, string desc, string imagen, string amb, double alt, double precio)
        {
            //this.IdPlanta = id;
            this.NombreCientifico = nom;
            this.NombreVulgar = nomv;
            this.MiTipoPlanta = tipoPlanta;
            this.Descripcion = desc;
            this.imagen = imagen;
            this.Ambiente = amb;
            this.AlturaMax = alt;
            this.Precio = precio;
        }
        
    }
}
