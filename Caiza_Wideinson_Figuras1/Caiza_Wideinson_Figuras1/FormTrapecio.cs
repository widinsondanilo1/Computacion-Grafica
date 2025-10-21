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
    public partial class FormTrapecio : Form
    {
        private Trapecio trapecio = new Trapecio(); 
        public FormTrapecio()
        {
            InitializeComponent();
        }

        private void txtBaseMayor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtBaseMayor.Text, out float bM) &&
    float.TryParse(txtBaseMenor.Text, out float bmen) &&
    float.TryParse(txtAltura.Text, out float h) &&
    float.TryParse(txtLado1.Text, out float l1) &&
    float.TryParse(txtLado2.Text, out float l2) &&
    bM > 0 && bmen > 0 && h > 0 && l1 > 0 && l2 > 0)
            {
                trapecio.BaseMayor = bM;
                trapecio.BaseMenor = bmen;
                trapecio.Altura = h;
                trapecio.Lado1 = l1;
                trapecio.Lado2 = l2;
                lblArea.Text = $"Área: {trapecio.CalcularArea():F2}";
                lblPerimetro.Text = $"Perímetro: {trapecio.CalcularPerimetro():F2}";
                
            }
            else
            {
                MessageBox.Show("Ingrese valores válidos mayores a 0.");
            }
        }
    }
}
