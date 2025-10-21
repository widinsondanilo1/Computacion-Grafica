using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caiza_Wideinson_Figuras1
{
    public class Trapecio : Figura
    {
        public float BaseMayor { get; set; }
        public float BaseMenor { get; set; }
        public float Altura { get; set; }
        public float Lado1 { get; set; }
        public float Lado2 { get; set; }

        public override double CalcularArea()
            => ((BaseMayor + BaseMenor) * Altura) / 2.0;

        public override double CalcularPerimetro()
            => BaseMayor + BaseMenor + Lado1 + Lado2;

       
    }
}
