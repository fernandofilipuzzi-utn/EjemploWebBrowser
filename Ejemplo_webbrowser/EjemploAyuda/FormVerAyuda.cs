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
    public partial class FormVerAyuda : Form
    {
        public FormVerAyuda()
        {
            InitializeComponent();
        }

        private void FormVerAyuda_Load(object sender, EventArgs e)
        {
            string path = Path.Combine(Application.StartupPath,"..",
                "..","ayuda", "index.html");
            webBrowser1.Navigate(path);
        }
    }
}
