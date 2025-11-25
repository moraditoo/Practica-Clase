namespace MinimoMaximo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblResultados = new System.Windows.Forms.Label();
            this.btnCalcMinMax = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResultados
            // 
            this.lblResultados.Location = new System.Drawing.Point(63, 178);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(690, 263);
            this.lblResultados.TabIndex = 0;
            // 
            // btnCalcMinMax
            // 
            this.btnCalcMinMax.Location = new System.Drawing.Point(256, 61);
            this.btnCalcMinMax.Name = "btnCalcMinMax";
            this.btnCalcMinMax.Size = new System.Drawing.Size(271, 85);
            this.btnCalcMinMax.TabIndex = 1;
            this.btnCalcMinMax.Text = "Calcular Min y Max";
            this.btnCalcMinMax.UseVisualStyleBackColor = true;
            this.btnCalcMinMax.Click += new System.EventHandler(this.btnCalcMinMax_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcMinMax);
            this.Controls.Add(this.lblResultados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.Button btnCalcMinMax;
    }
}

