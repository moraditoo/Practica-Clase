using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusquedaLineal
{
    public partial class Form1 : Form
    {
        private int[] arreglo= new int[20];
        private Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void tbArreglo_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnGenerarArreglo_Click(object sender, EventArgs e)
        {
            lbArreglo.Items.Clear();
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = rnd.Next(1, 101);
                lbArreglo.Items.Add($"Pos {i}: {arreglo[i]}");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbArreglo.Text, out int objetivo))
            {
                MessageBox.Show("Por favor ingrese un número válido.");
                return;
            }

            bool encontrado = false;

            
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == objetivo)
                {
                    MessageBox.Show($"Número {objetivo} encontrado en la posición: {i}");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("El número no existe en el arreglo.");
            }
        }
    }
}
