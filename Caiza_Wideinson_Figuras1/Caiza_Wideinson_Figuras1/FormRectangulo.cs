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
    public partial class FormRectangulo : Form
    {
        private Rectangulo rectangulo = new Rectangulo();
        public FormRectangulo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLado_Click(object sender, EventArgs e)
        {

        }

        private void FormRectangulo_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtbase.Text, out float baseRect) &&
                  float.TryParse(txtaltura.Text, out float altura) &&
                  baseRect > 0 && altura > 0)
            {
                rectangulo.Base = baseRect;
                rectangulo.Altura = altura;

                lblArea.Text = $"Área: {rectangulo.CalcularArea():F2}";
                lblPerimetro.Text = $"Perímetro: {rectangulo.CalcularPerimetro():F2}";
            }
            else
            {
                MessageBox.Show("Ingrese valores válidos mayores a 0.");
            }
        }

        private void txtLado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
