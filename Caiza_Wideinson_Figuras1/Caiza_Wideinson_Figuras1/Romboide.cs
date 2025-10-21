using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caiza_Wideinson_Figuras1
{
    public class Romboide : Figura
    {
        public float Base { get; set; }
        public float Altura { get; set; }
        public float Lado { get; set; }

        public override double CalcularArea()
            => Base * Altura;

        public override double CalcularPerimetro()
            => 2 * (Base + Lado);

  
        
    }

}
