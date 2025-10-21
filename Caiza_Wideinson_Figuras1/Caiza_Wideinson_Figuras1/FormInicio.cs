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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
           
        }
      
      

        private void button7_Click(object sender, EventArgs e)
        {
            FormPoligono otroFormulario = new FormPoligono();

            // Mostrar el formulario
            otroFormulario.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCuadrado otroFormulario = new FormCuadrado();

            // Mostrar el formulario
            otroFormulario.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 otroFormulario = new Form2();

            // Mostrar el formulario
            otroFormulario.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormRomboide otroFormulario = new FormRomboide();

            // Mostrar el formulario
            otroFormulario.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormTrapecio otroFormulario = new FormTrapecio();

            // Mostrar el formulario
            otroFormulario.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //circulo
            FormCirculo otroFormulario = new FormCirculo();

            // Mostrar el formulario
            otroFormulario.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //rectangulo
            FrRectangulo otroFormulario = new FrRectangulo();

            // Mostrar el formulario
            otroFormulario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Triangulo
            FormTriangulo triangulo = new FormTriangulo();
            triangulo.Show();

        }
    }
}
