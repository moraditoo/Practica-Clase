using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinimoMaximo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcMinMax_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            List<int> numeros = new List<int>();
            

            for (int k = 0; k < 50; k++) numeros.Add(rnd.Next(-100, 100));

            if (numeros.Count == 0) return;

            
            int min = numeros[0];
            int max = numeros[0];
            int iteraciones = 0;

            
            for (int i = 1; i < numeros.Count; i++)
            {
                iteraciones++;
                if (numeros[i] > max)
                    max = numeros[i];

                if (numeros[i] < min)
                    min = numeros[i];
            }

            lblResultados.Text = $"Máximo: {max}\nMínimo: {min}\nIteraciones: {iteraciones}";
        }
    }
}
