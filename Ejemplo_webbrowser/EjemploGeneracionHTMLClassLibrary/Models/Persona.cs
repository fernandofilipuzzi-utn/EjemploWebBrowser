using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploGeneracionHTMLClassLibrary.Models
{
    public class Persona
    {
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public Image Imagen { get; set; }

        public object[] ToArray()
        {
            return new object[] { Dni, Nombre, Imagen};
        }
    }
}
