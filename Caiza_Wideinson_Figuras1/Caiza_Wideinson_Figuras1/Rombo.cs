using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caiza_Wideinson_Figuras1
{
    public class Rombo : Figura
    {
        public float DiagonalMayor { get; set; }
        public float DiagonalMenor { get; set; }

        public override double CalcularArea()
            => (DiagonalMayor * DiagonalMenor) / 2.0;

        public override double CalcularPerimetro()
        {
            double a = DiagonalMayor / 2.0;
            double b = DiagonalMenor / 2.0;
            return 4 * Math.Sqrt(a * a + b * b);
        }

        

        
    }
}
