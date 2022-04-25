using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class TipoPlanta
    {
        public int id { get; set; }
        public string NombreUnico { get; set; }
        public string DescripcionTipo { get; set; }

        public TipoPlanta()
        {
        }
        public TipoPlanta(string nom, string desc)
        {
            this.id = id;
            this.NombreUnico = nom;
            this.DescripcionTipo = desc;
        }

    }
}
