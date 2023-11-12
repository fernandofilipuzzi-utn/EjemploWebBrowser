using EjemploGeneracionHTMLClassLibrary;
using EjemploGeneracionHTMLClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploAyuda
{
    public partial class FormPrincipal : Form
    {
        List<Persona> listado = new List<Persona>();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void comoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVerAyuda formAyuda = new FormVerAyuda();
            formAyuda.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            GenListado genListado = new GenListado();
            listado = genListado.ListarPersonas();
            PintarDataGrid();
        }

        private void PintarDataGrid()
        {
            dgvPersonas.Rows.Clear();

            foreach (Persona persona in listado)
            {
                object[] row = persona.ToArray();

                #region normaliza la imagen a un tamaño fijo
                Bitmap bitmap = new Bitmap(persona.Imagen, 50, 50);
                if (persona.Imagen != null)
                {
                    bitmap = new Bitmap(persona.Imagen, 50, 50);
                }
                #endregion
                row[2] = bitmap;

                dgvPersonas.Rows.Add(row);
            }

            dgvPersonas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnMostrarRegistro_Click(object sender, EventArgs e)
        {
            if (dgvPersonas.SelectedRows.Count == 1)
            {
                int dniSelected = Convert.ToInt32(dgvPersonas.SelectedRows[0].Cells[0].Value);

                listado.Sort();
                int idx = listado.BinarySearch(new Persona { Dni=dniSelected});
                if (idx != -1)
                {
                    Persona selected = listado[idx];

                    FormVerRegistro fVerRegistro = new FormVerRegistro();

                    fVerRegistro.textBox1.Text = selected.Nombre;
                    fVerRegistro.textBox1.Enabled = false;

                    fVerRegistro.Foto=selected.Imagen;

                    fVerRegistro.Show();
                }
            }
        }

        private void btnImportarCSV_Click(object sender, EventArgs e)
        {
            //implementar
        }
    }
}
