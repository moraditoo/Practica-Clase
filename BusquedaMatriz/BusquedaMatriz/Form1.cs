using System;
using System.Windows.Forms;

namespace BusquedaMatriz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LlenarMatriz();
        }

        int[,] matriz = new int[10, 10];


        private void LlenarMatriz()
        {
            dgvMatriz.AllowUserToAddRows = false;
            dgvMatriz.ColumnCount = 10;
            dgvMatriz.RowCount = 10;

            for (int col = 0; col < 10; col++)
            {
                dgvMatriz.Columns[col].Width = 60;
                dgvMatriz.Columns[col].Name = col.ToString();
            }

            
            Random rnd = new Random();

            for (int f = 0; f < 10; f++)
            {
                for (int c = 0; c < 10; c++)
                {
                    matriz[f, c] = rnd.Next(1, 100);
                    dgvMatriz.Rows[f].Cells[c].Value = matriz[f, c];
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbNumeroMatriz.Text, out int objetivo)) return;

            string posiciones = "";
            bool encontrado = false;


            for (int f = 0; f < 10; f++)
            {
                for (int c = 0; c < 10; c++)
                {
                    if (matriz[f, c] == objetivo)
                    {
                        posiciones += $"[{f},{c}] ";
                        encontrado = true;

                    }
                }
            }

            if (encontrado)
                MessageBox.Show($"El número {objetivo} está en: {posiciones}");
            else
                MessageBox.Show("El número no está en la matriz.");
        }
    }
}