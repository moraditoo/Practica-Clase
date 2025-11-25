namespace BusquedaObjetos_Lineal_vs_Binaria_
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
            this.btnBuscarCIF = new System.Windows.Forms.Button();
            this.btnBuscarNombre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBuscarCIF
            // 
            this.btnBuscarCIF.Location = new System.Drawing.Point(563, 25);
            this.btnBuscarCIF.Name = "btnBuscarCIF";
            this.btnBuscarCIF.Size = new System.Drawing.Size(199, 85);
            this.btnBuscarCIF.TabIndex = 0;
            this.btnBuscarCIF.Text = "BuscarCIF";
            this.btnBuscarCIF.UseVisualStyleBackColor = true;
            this.btnBuscarCIF.Click += new System.EventHandler(this.btnBuscarCIF_Click);
            // 
            // btnBuscarNombre
            // 
            this.btnBuscarNombre.Location = new System.Drawing.Point(563, 129);
            this.btnBuscarNombre.Name = "btnBuscarNombre";
            this.btnBuscarNombre.Size = new System.Drawing.Size(199, 85);
            this.btnBuscarNombre.TabIndex = 1;
            this.btnBuscarNombre.Text = "BuscarNombre";
            this.btnBuscarNombre.UseVisualStyleBackColor = true;
            this.btnBuscarNombre.Click += new System.EventHandler(this.btnBuscarNombre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "ITEM A BUSCAR:";
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(99, 94);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(396, 31);
            this.tbBuscar.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 246);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscarNombre);
            this.Controls.Add(this.btnBuscarCIF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarCIF;
        private System.Windows.Forms.Button btnBuscarNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBuscar;
    }
}

