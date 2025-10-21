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
    public partial class FormPoligono : Form
    {
        private Poligono poligono = new Poligono();
        public FormPoligono()
        {
            InitializeComponent();
        }

        private void FormPoligono_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtLado.Text, out float lado) &&
         float.TryParse(txtApotema.Text, out float apotema) &&
         int.TryParse(txtnumeroL.Text, out int numeroLados) &&
         lado > 0 && apotema > 0 && numeroLados >= 3)
            {
                poligono.Lado = lado;
                poligono.Apotema = apotema;
                poligono.numeroLado = numeroLados;

                lblArea.Text = $"Área: {poligono.CalcularArea():F2}";
                lblPerimetro.Text = $"Perímetro: {poligono.CalcularPerimetro():F2}";
            }
            else
            {
                MessageBox.Show("Ingrese valores válidos. Lados >= 3, lado y apotema > 0.");
            }
        }
    }
}
