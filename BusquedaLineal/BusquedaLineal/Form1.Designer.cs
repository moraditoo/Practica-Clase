namespace BusquedaLineal
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
            this.btnGenerarArreglo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbArreglo = new System.Windows.Forms.ListBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbArreglo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGenerarArreglo
            // 
            this.btnGenerarArreglo.Location = new System.Drawing.Point(524, 23);
            this.btnGenerarArreglo.Name = "btnGenerarArreglo";
            this.btnGenerarArreglo.Size = new System.Drawing.Size(227, 53);
            this.btnGenerarArreglo.TabIndex = 0;
            this.btnGenerarArreglo.Text = "Generar Arreglo";
            this.btnGenerarArreglo.UseVisualStyleBackColor = true;
            this.btnGenerarArreglo.Click += new System.EventHandler(this.btnGenerarArreglo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item a buscar:";
            // 
            // lbArreglo
            // 
            this.lbArreglo.FormattingEnabled = true;
            this.lbArreglo.ItemHeight = 25;
            this.lbArreglo.Location = new System.Drawing.Point(144, 225);
            this.lbArreglo.Name = "lbArreglo";
            this.lbArreglo.Size = new System.Drawing.Size(472, 379);
            this.lbArreglo.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(524, 92);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(224, 53);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbArreglo
            // 
            this.tbArreglo.Location = new System.Drawing.Point(181, 51);
            this.tbArreglo.Name = "tbArreglo";
            this.tbArreglo.Size = new System.Drawing.Size(304, 31);
            this.tbArreglo.TabIndex = 4;
            this.tbArreglo.TextChanged += new System.EventHandler(this.tbArreglo_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 732);
            this.Controls.Add(this.tbArreglo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lbArreglo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerarArreglo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarArreglo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbArreglo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbArreglo;
    }
}

