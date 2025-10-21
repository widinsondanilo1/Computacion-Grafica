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
    public partial class FormCuadrado : Form
    {
        private Cuadrado cuadrado = new Cuadrado();
        public FormCuadrado()
        {
            InitializeComponent();
        }

        private void FormCuadrado_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtLado.Text, out float lado) && lado > 0)
            {
                cuadrado.Lado = lado;

                lblArea.Text = $"Área: {cuadrado.CalcularArea():F2}";
                lblPerimetro.Text = $"Perímetro: {cuadrado.CalcularPerimetro():F2}";
            }
            else
            {
                MessageBox.Show("Ingrese un valor válido mayor a 0.");
            }

        }

        private void txtLado_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPerimetro_Click(object sender, EventArgs e)
        {

        }
    }
}
