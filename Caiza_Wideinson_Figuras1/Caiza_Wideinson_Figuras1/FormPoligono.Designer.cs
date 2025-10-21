namespace Caiza_Wideinson_Figuras1
{
    partial class FormPoligono
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtLado = new System.Windows.Forms.TextBox();
            this.txtApotema = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblLado = new System.Windows.Forms.Label();
            this.lblApotema = new System.Windows.Forms.Label();
            this.txtnumeroL = new System.Windows.Forms.TextBox();
            this.lblnumeroL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLado
            // 
            this.txtLado.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLado.Location = new System.Drawing.Point(236, 15);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(100, 20);
            this.txtLado.TabIndex = 10;
            // 
            // txtApotema
            // 
            this.txtApotema.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApotema.Location = new System.Drawing.Point(236, 45);
            this.txtApotema.Name = "txtApotema";
            this.txtApotema.Size = new System.Drawing.Size(100, 20);
            this.txtApotema.TabIndex = 11;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(78, 131);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblArea
            // 
            this.lblArea.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(133, 172);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(300, 20);
            this.lblArea.TabIndex = 15;
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimetro.Location = new System.Drawing.Point(133, 192);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(300, 20);
            this.lblPerimetro.TabIndex = 16;
            // 
            // lblLado
            // 
            this.lblLado.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado.Location = new System.Drawing.Point(126, 15);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(100, 23);
            this.lblLado.TabIndex = 18;
            this.lblLado.Text = "Lado:";
            // 
            // lblApotema
            // 
            this.lblApotema.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApotema.Location = new System.Drawing.Point(126, 45);
            this.lblApotema.Name = "lblApotema";
            this.lblApotema.Size = new System.Drawing.Size(100, 23);
            this.lblApotema.TabIndex = 19;
            this.lblApotema.Text = "Apotema:";
            // 
            // txtnumeroL
            // 
            this.txtnumeroL.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumeroL.Location = new System.Drawing.Point(236, 82);
            this.txtnumeroL.Name = "txtnumeroL";
            this.txtnumeroL.Size = new System.Drawing.Size(100, 20);
            this.txtnumeroL.TabIndex = 20;
            // 
            // lblnumeroL
            // 
            this.lblnumeroL.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumeroL.Location = new System.Drawing.Point(126, 82);
            this.lblnumeroL.Name = "lblnumeroL";
            this.lblnumeroL.Size = new System.Drawing.Size(100, 23);
            this.lblnumeroL.TabIndex = 21;
            this.lblnumeroL.Text = "#lados";
            // 
            // FormPoligono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtnumeroL);
            this.Controls.Add(this.lblnumeroL);
            this.Controls.Add(this.txtLado);
            this.Controls.Add(this.txtApotema);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblLado);
            this.Controls.Add(this.lblApotema);
            this.Name = "FormPoligono";
            this.Text = "FormPoligono";
            this.Load += new System.EventHandler(this.FormPoligono_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.TextBox txtApotema;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.Label lblApotema;
        private System.Windows.Forms.TextBox txtnumeroL;
        private System.Windows.Forms.Label lblnumeroL;
    }
}