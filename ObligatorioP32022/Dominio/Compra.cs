using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public abstract class Compra
    {
        public int IdCompra { get; set; }
        public DateTime FechaCompra { get; set; }
        public double PrecioCompra { get; set; }
        public List<PlantaComprada> PlantasCompradas { get; set; }
    }
}
