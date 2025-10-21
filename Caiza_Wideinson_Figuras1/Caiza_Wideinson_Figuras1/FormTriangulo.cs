using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caiza_Wideinson_Figuras1
{
    public partial class FormTriangulo : Form
    {
        Triangulo triangulo=  new Triangulo();
        public FormTriangulo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtBase.Text, out float d1) &&
                float.TryParse(txtAltura.Text, out float d2) &&
                float.TryParse(txtLado1.Text, out float d3) &&
                float.TryParse(txtLado2.Text, out float d4) &&
                float.TryParse(txtLado3.Text, out float d5) &&
                d1 > 0 && d2 > 0 && d3 > 0 && d4 > 0 && d5 > 0)
            {
                // Validación de triángulo
                if ((d3 + d4 > d5) && (d3 + d5 > d4) && (d4 + d5 > d3))
                {
                    triangulo.bases = d1;
                    triangulo.altura = d2;
                    triangulo.lado1 = d3;
                    triangulo.lado2 = d4;
                    triangulo.lado3 = d5;

                    lblArea.Text = $"Área: {triangulo.CalcularArea():F2}";
                    lblPerimetro.Text = $"Perímetro: {triangulo.CalcularPerimetro():F2}";
                }
                else
                {
                    MessageBox.Show("Los lados ingresados no forman un triángulo válido.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos válidos y mayores que 0.");
            }
        }

    }
}
