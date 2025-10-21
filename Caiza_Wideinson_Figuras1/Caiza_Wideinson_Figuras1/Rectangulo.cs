using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caiza_Wideinson_Figuras1
{
    internal class Rectangulo :Figura
    {
        public float bases { get; set; }
        public float altura { get; set; }

        public override double CalcularArea()
            => bases * altura;

        public override double CalcularPerimetro()
            => 2*(bases) + 2*(  altura);

        public override string ToString()
        {
            return $"Rectanuglo - base: {bases}, Área: {CalcularArea():F2}, Perímetro: {CalcularPerimetro():F2}";
        }
    }
}
