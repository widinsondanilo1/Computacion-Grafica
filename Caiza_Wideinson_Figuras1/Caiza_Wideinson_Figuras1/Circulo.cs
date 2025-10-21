using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caiza_Wideinson_Figuras1
{
    internal class Circulo : Figura
    {
        public float radio { get; set; }

        // Área = π * r²
        public override double CalcularArea()
            => Math.PI * Math.Pow(radio, 2);

        // Circunferencia = 2 * π * r
        public override double CalcularPerimetro()
            => 2 * Math.PI * radio;

        public override string ToString()
        {
            return $"Círculo, Área: {CalcularArea():F2}, Circunferencia: {CalcularPerimetro():F2}";
        }
    }
}
