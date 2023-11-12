using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using EjemploGeneracionHTMLClassLibrary;
using EjemploGeneracionHTMLClassLibrary.Models;

namespace WebBrowser
{
    public partial class FormPrincipal : Form
    {
        List<Persona> listado = new List<Persona>();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            GenListado genListado = new GenListado();
            listado = genListado.ListarPersonas();
        }

        private void btnGenerarListado_Click(object sender, EventArgs e)
        {
            dgvPersonas.ColumnCount = 2;
            dgvPersonas.RowHeadersVisible = false;
            dgvPersonas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgvPersonas.Columns[0].HeaderCell.Value = "DNI";
            dgvPersonas.Columns[1].HeaderCell.Value = "Nombres y Apellido";
                       
            dgvPersonas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvPersonas.Rows.Clear();
            foreach (Persona renglon in listado)
            {
                dgvPersonas.Rows.Add(renglon.ToArray());
            }
        }
        private void btnVerHTML_Click(object sender, EventArgs e)
        {
            string pathRootWeb = Application.StartupPath + @"\..\..\web";

            GenHTML gen = new GenHTML();
            string pathListado = gen.GenerarListadoHTML(pathRootWeb, listado);

            FormInformeWeb fInformeWeb = new FormInformeWeb();
            fInformeWeb.webBrowser1.Navigate(pathListado);
            fInformeWeb.ShowDialog();
        }
    }
}
