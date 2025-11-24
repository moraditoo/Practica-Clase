namespace BusquedaBinaria
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
            this.btnGOB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbItem = new System.Windows.Forms.TextBox();
            this.lbPasos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGOB
            // 
            this.btnGOB.Location = new System.Drawing.Point(525, 34);
            this.btnGOB.Name = "btnGOB";
            this.btnGOB.Size = new System.Drawing.Size(247, 131);
            this.btnGOB.TabIndex = 0;
            this.btnGOB.Text = "Generar, Ordenar, Buscar";
            this.btnGOB.UseVisualStyleBackColor = true;
            this.btnGOB.Click += new System.EventHandler(this.btnGOB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item a buscar:";
            // 
            // tbItem
            // 
            this.tbItem.Location = new System.Drawing.Point(183, 107);
            this.tbItem.Name = "tbItem";
            this.tbItem.Size = new System.Drawing.Size(322, 31);
            this.tbItem.TabIndex = 2;
            // 
            // lbPasos
            // 
            this.lbPasos.FormattingEnabled = true;
            this.lbPasos.ItemHeight = 25;
            this.lbPasos.Location = new System.Drawing.Point(34, 186);
            this.lbPasos.Name = "lbPasos";
            this.lbPasos.Size = new System.Drawing.Size(1482, 504);
            this.lbPasos.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1530, 778);
            this.Controls.Add(this.lbPasos);
            this.Controls.Add(this.tbItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGOB);
            this.Name = "Form1";
            this.Text = "BusquedaBinaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGOB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbItem;
        private System.Windows.Forms.ListBox lbPasos;
    }
}

