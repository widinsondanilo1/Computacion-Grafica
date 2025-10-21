using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caiza_Wideinson_Figuras1
{
    public class Poligono : Figura
    {
        public float Lado { get; set; }
        public float numeroLado { get; set; }
        public float Apotema { get; set; }

        public override double CalcularArea()
            => (numeroLado * Lado * Apotema) / 2.0;

        public override double CalcularPerimetro()
            => numeroLado * Lado;

      

           
        
    }
}
