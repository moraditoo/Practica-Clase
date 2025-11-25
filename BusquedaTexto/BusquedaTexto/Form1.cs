using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusquedaTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string texto = rtbParrafo.Text.ToLower();
            string palabra = tbItem.Text.ToLower();
            int contador = 0;

            if (string.IsNullOrEmpty(palabra) || palabra.Length > texto.Length) return;

            
            for (int i = 0; i <= texto.Length - palabra.Length; i++)
            {
                bool coincide = true;

                
                for (int j = 0; j < palabra.Length; j++)
                {
                    if (texto[i + j] != palabra[j])
                    {
                        coincide = false;
                        break;
                    }
                }

                if (coincide)
                {
                    contador++;
                    
                }
            }

            MessageBox.Show($"La palabra '{palabra}' aparece {contador} veces.");
        }
    }
}
