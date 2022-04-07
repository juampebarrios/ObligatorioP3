using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Importacion : Compra   
    {
        public double TasaImpuesto { get; set; }
        public bool EsAmericaSur { get; set; }
        public string Descripcion { get; set; }
    }
}
