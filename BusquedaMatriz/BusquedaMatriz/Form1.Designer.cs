namespace BusquedaMatriz
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
            this.dgvMatriz = new System.Windows.Forms.DataGridView();
            this.btnBuscarMatriz = new System.Windows.Forms.Button();
            this.tbNumeroMatriz = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMatriz
            // 
            this.dgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz.Location = new System.Drawing.Point(12, 223);
            this.dgvMatriz.Name = "dgvMatriz";
            this.dgvMatriz.RowHeadersWidth = 82;
            this.dgvMatriz.RowTemplate.Height = 33;
            this.dgvMatriz.Size = new System.Drawing.Size(1200, 574);
            this.dgvMatriz.TabIndex = 0;
            // 
            // btnBuscarMatriz
            // 
            this.btnBuscarMatriz.Location = new System.Drawing.Point(135, 99);
            this.btnBuscarMatriz.Name = "btnBuscarMatriz";
            this.btnBuscarMatriz.Size = new System.Drawing.Size(157, 95);
            this.btnBuscarMatriz.TabIndex = 1;
            this.btnBuscarMatriz.Text = "BuscarMatriz";
            this.btnBuscarMatriz.UseVisualStyleBackColor = true;
            this.btnBuscarMatriz.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbNumeroMatriz
            // 
            this.tbNumeroMatriz.Location = new System.Drawing.Point(347, 125);
            this.tbNumeroMatriz.Name = "tbNumeroMatriz";
            this.tbNumeroMatriz.Size = new System.Drawing.Size(680, 31);
            this.tbNumeroMatriz.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 830);
            this.Controls.Add(this.tbNumeroMatriz);
            this.Controls.Add(this.btnBuscarMatriz);
            this.Controls.Add(this.dgvMatriz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMatriz;
        private System.Windows.Forms.Button btnBuscarMatriz;
        private System.Windows.Forms.TextBox tbNumeroMatriz;
    }
}

