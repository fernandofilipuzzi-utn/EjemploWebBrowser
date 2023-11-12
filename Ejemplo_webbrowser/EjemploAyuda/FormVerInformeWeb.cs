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
    public partial class FormVerInformeWeb : Form
    {
        #region codigo auxiliar
        Image foto;
        public Image Foto 
        {
            get
            {
                return foto;
            }
            set
            {
                foto = value;

                #region normaliza la imagen a un tamaño fijo
                Bitmap bitmap = new Bitmap(foto, 200, 200);
                if (foto != null)
                {
                    bitmap = new Bitmap(foto, 200, 200);
                }
                #endregion
                pbFoto.Image = bitmap;
            }
        }
        #endregion

        public FormVerInformeWeb()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }
    }
}
