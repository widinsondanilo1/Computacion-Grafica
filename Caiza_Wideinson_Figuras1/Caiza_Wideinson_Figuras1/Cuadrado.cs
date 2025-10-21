using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caiza_Wideinson_Figuras1
{
    public class Cuadrado : Figura
    {
        public float Lado { get; set; }

        public override double CalcularArea()
            => Lado * Lado;

        public override double CalcularPerimetro()
            => 4 * Lado;

        public override string ToString()
        {
            return $"Cuadrado - Lado: {Lado}, Área: {CalcularArea():F2}, Perímetro: {CalcularPerimetro():F2}";
        }
    }
}
