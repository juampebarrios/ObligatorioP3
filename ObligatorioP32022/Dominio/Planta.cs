using Microsoft.AspNetCore.Http;
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

        public Planta()
        {
        }
        public Planta(TipoPlanta miTipo, string nom, string nomv, string desc, string amb, double alt, double precio, IFormFile imagen)
        {
            this.MiTipoPlanta = miTipo;
            this.NombreCientifico = nom;
            this.NombreVulgar = nomv;
            this.Descripcion = desc;
            this.Ambiente = amb;
            this.AlturaMax = alt;
            this.Precio = precio;
        }
        
    }
}
