using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploGeneracionHTMLClassLibrary.Models
{
    public class Persona: IComparable
    {
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public Image Imagen { get; set; }

        public int CompareTo(object obj)
        {
            Persona otra = obj as Persona;
            int valor=-1;
            if(otra!=null)
                valor= Dni.CompareTo(otra.Dni);
            return valor;
        }

        public object[] ToArray()
        {
            return new object[] { Dni, Nombre, Imagen};
        }
    }
}
