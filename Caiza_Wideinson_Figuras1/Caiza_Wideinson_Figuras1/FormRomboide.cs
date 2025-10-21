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
    public partial class FormRomboide : Form
    {
        private Romboide romboide = new Romboide();
        public FormRomboide()
        {
            InitializeComponent();
        }

        private void lblBase_Click(object sender, EventArgs e)
        {

        }

        private void txtBase_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLado_Click(object sender, EventArgs e)
        {

        }

        private void txtLado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (float.TryParse(txtBase.Text, out float b) &&
               float.TryParse(txtAltura.Text, out float h) &&
               float.TryParse(txtLado.Text, out float l) &&
               b > 0 && h > 0 && l > 0)
            {
                romboide.Base = b;
                romboide.Altura = h;
                romboide.Lado = l;
                lblArea.Text = $"Área: {romboide.CalcularArea():F2}";
                lblPerimetro.Text = $"Perímetro: {romboide.CalcularPerimetro():F2}";
               
            }
            else
            {
                MessageBox.Show("Ingrese valores válidos mayores a 0.");
            }

        }

        private void lblPerimetro_Click(object sender, EventArgs e)
        {

        }

        private void FormRomboide_Load(object sender, EventArgs e)
        {

        }
    }
}
