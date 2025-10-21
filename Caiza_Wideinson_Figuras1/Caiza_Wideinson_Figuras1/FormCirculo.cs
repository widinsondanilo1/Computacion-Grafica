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
    public partial class FormCirculo : Form
    {
        Circulo circulo = new Circulo();
        public FormCirculo()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtRadio.Text) &&
    float.TryParse(txtRadio.Text, System.Globalization.NumberStyles.Float,
    System.Globalization.CultureInfo.InvariantCulture, out float r) && r > 0)
            {
                Circulo c = new Circulo();
                c.radio = r;

                lblArea.Text = $"Área: {c.CalcularArea():F2}";
                lblPerimetro.Text = $"Circunferencia: {c.CalcularPerimetro():F2}";
            }
            else
            {
                MessageBox.Show("Ingrese un valor numérico válido mayor que 0 (solo números y punto decimal).");
            }

        }

        private void txtRadio_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormCirculo_Load(object sender, EventArgs e)
        {

        }
    }
}
