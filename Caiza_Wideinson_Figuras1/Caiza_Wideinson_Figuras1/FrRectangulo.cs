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
    public partial class FrRectangulo : Form
    {
        Rectangulo rectangulo= new Rectangulo();
        public FrRectangulo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtBase.Text, out float d1) &&
             float.TryParse(txtAltura.Text, out float d2) &&
             d1 > 0 && d2 > 0)
            {
                rectangulo.bases= d1;
                rectangulo.altura = d2;
                lblArea.Text = $"Área: {rectangulo.CalcularArea():F2}";
                lblPerimetro.Text = $"Perímetro: {rectangulo.CalcularPerimetro():F2}";

            }
            else
            {
                MessageBox.Show("Ingrese valores válidos mayores a 0.");
            }
        }
    }
}
