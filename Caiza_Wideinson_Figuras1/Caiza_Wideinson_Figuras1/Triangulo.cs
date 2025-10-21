using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caiza_Wideinson_Figuras1
{
    internal class Triangulo : Figura
    {
        public float bases { get; set; }
        public float altura { get; set; }
        public float lado1{get; set;}
        public float lado2 { get; set; }
        public float lado3 { get; set; }

        public override double CalcularArea()
            => (bases * altura)/2;

        public override double CalcularPerimetro()
            => lado1 + lado2 + lado3;

        public override string ToString()
        {
            return $"Triangulo , Área: {CalcularArea():F2}, Perímetro: {CalcularPerimetro():F2}";
        }
    }
}
