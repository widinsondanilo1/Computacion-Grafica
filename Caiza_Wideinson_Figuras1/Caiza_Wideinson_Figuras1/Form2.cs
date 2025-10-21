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
   
    public partial class Form2 : Form
    {
        private Rombo rombo = new Rombo();
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtD1.Text, out float d1) &&
               float.TryParse(txtD2.Text, out float d2) &&
               d1 > 0 && d2 > 0)
            {
                rombo.DiagonalMayor = d1;
                rombo.DiagonalMenor = d2;
                lblArea.Text = $"Área: {rombo.CalcularArea():F2}";
                lblPerimetro.Text = $"Perímetro: {rombo.CalcularPerimetro():F2}";
                
            }
            else
            {
                MessageBox.Show("Ingrese valores válidos mayores a 0.");
            }
        }

        private void txtD1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblD2_Click(object sender, EventArgs e)
        {

        }

        private void txtD2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblArea_Click(object sender, EventArgs e)
        {

        }

        private void lblPerimetro_Click(object sender, EventArgs e)
        {

        }
    }
}
