using BusquedaObjetos_Lineal_vs_Binaria_.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BusquedaObjetos_Lineal_vs_Binaria_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarEstudiantes();
        }


        List<Estudiante> estudiantes = new List<Estudiante>();
       
        private void btnBuscarCIF_Click(object sender, EventArgs e)
        {
            int idObj = int.Parse(tbBuscar.Text);
            foreach (var est in estudiantes)
            {
                if (est.CIF == idObj)
                {
                    MessageBox.Show($"Encontrado: {est.Nombre} (CIF: {est.CIF})");
                    return;
                }
            }
            MessageBox.Show("Estudiante no encontrado por CIF.");
        }

        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            estudiantes.Sort((x, y) => string.Compare(x.Nombre, y.Nombre));

            string nombreObj = tbBuscar.Text;
            int inicio = 0, fin = estudiantes.Count - 1;
            bool found = false;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;

                int comparacion = string.Compare(estudiantes[medio].Nombre, nombreObj, StringComparison.OrdinalIgnoreCase);

                if (comparacion == 0)
                {
                    MessageBox.Show($"Encontrado: {estudiantes[medio].Nombre} tiene CIF {estudiantes[medio].CIF}");
                    found = true;
                    break;
                }
                else if (comparacion < 0) inicio = medio + 1;
                else fin = medio - 1;
            }

            if (!found) MessageBox.Show("No existe estudiante con ese nombre.");
        }

        private void CargarEstudiantes()
        {
            estudiantes = new List<Estudiante> {
        new Estudiante { CIF = 25010573, Nombre = "Dylan" },
        new Estudiante { CIF = 25010344, Nombre = "Ana" },
        new Estudiante { CIF = 25012323, Nombre = "Zacarias" },
        new Estudiante { CIF = 25018903, Nombre = "BOBYOKJUAN" },
        new Estudiante { CIF = 25017611, Nombre = "Maria" },

    };
        }
    }
}
