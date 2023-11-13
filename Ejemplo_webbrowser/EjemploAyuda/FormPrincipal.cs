using EjemploGeneracionHTMLClassLibrary;
using EjemploGeneracionHTMLClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

                    fVerRegistro.tbApellidoNombre.Text = selected.Nombre;
                    fVerRegistro.tbApellidoNombre.Enabled = false;

                    fVerRegistro.Foto=selected.Imagen;

                    fVerRegistro.Show();
                }
            }
        }

        private void btnImportarCSV_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Importando los registros de personas";
            openFileDialog1.Filter = "CSV|*.csv";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;

                FileStream fs = null;
                StreamReader sr = null;
                try
                {
                    fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);

                    string pathDir = Path.GetDirectoryName(path);

                    listado.Sort();

                    //descarto la primera línea.
                    sr.ReadLine();

                    while (sr.EndOfStream == false)
                    {
                        string linea = sr.ReadLine();
                        string[] campos = linea.Split(';');
                        
                        #region dni
                        int dni = Convert.ToInt32(campos[0]);
                        #endregion

                        #region apellido y nombre
                        string apellidoNombre = campos[1];
                        #endregion

                        #region foto
                        string nombreFicheroImagen = campos[2].Trim();
                        //
                        string pathFoto = Path.Combine(pathDir, nombreFicheroImagen);
                        Image foto = Properties.Resources.Persona;
                        if (File.Exists(pathFoto))
                        {
                            foto = Image.FromFile(pathFoto);
                        }
                        #endregion

                        #region objeto importado
                        Persona importado = new Persona { Dni = dni, Nombre = apellidoNombre, Imagen=foto };
                        #endregion

                        #region lo busca a ver si existe!
                        int idx = listado.BinarySearch(importado);
                        #endregion

                        if (idx > -1)
                        {
                            //actualiza solo la foto en este caso
                            listado[idx].Imagen = importado.Imagen;
                        }
                        else
                        {
                            listado.Add(importado);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (fs != null)
                    {
                        if (sr != null) sr.Close();
                        fs.Close();
                    }
                }
            }

            PintarDataGrid();
        }
    }
}
