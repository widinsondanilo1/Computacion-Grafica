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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(900, 600);
            MaximizeBox = false;
        }
        private void AbrirFormulario(Form form)
        {
            foreach (Form hijo in MdiChildren)
            {
                hijo.Close();
            }

            form.MdiParent = this;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.Size = new Size(600, 500);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void figurasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void romboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Form2());
        }

        private void romboideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormRomboide());
        }

        private void trapecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormTrapecio());
        }

        private void pentagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormPoligono());
        }

        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormCuadrado());
        }

        private void rectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
