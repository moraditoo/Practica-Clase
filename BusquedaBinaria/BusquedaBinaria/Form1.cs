using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BusquedaBinaria
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGOB_Click(object sender, EventArgs e)
        {

            List<int> lista = new List<int>();
            for (int i = 0; i < 30; i++) lista.Add(rnd.Next(1, 200));

            lista.Sort(); // requerido para busqueda binaria

            lbPasos.Items.Clear();
            lbPasos.Items.Add("Lista Ordenada: " + string.Join(", ", lista));

            if (!int.TryParse(tbItem.Text, out int objetivo)) return;

            
            int inicio = 0;
            int fin = lista.Count - 1;
            bool encontrado = false;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;
                int valorMedio = lista[medio];

                
                lbPasos.Items.Add($"Rango [{inicio}-{fin}] | Medio: pos {medio} (val {valorMedio})");

                if (valorMedio == objetivo)
                {
                    MessageBox.Show($"Encontrado en la posición {medio}");
                    encontrado = true;
                    break;
                }
                else if (valorMedio < objetivo)
                {
                    inicio = medio + 1; // Buscar en la mitad derecha
                    lbPasos.Items.Add("-> Buscando a la derecha...");
                }
                else
                {
                    fin = medio - 1; // Buscar en la mitad izquierda
                    lbPasos.Items.Add("<- Buscando a la izquierda...");
                }
            }

            if (!encontrado) MessageBox.Show("No encontrado.");
        }
    }
}
