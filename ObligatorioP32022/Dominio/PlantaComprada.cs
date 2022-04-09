using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class PlantaComprada
    {
        public int IdPlantaComprada { get; set; }
        public Planta UnaPlanta { get; set; }
        public int Cantidad { get; set; }
        public double PrecioUnitario { get; set; }
        
    }
}
