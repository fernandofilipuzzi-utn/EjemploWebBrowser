using EjemploGeneracionHTMLClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploGeneracionHTMLClassLibrary
{
    public class GenHTML
    {
        public string GenerarListadoHTML(string pathRootWeb, List<Persona> listado)
        {
            if (File.Exists(pathRootWeb) == false)
                Directory.CreateDirectory(pathRootWeb);

            //clear directorio
            object[] files = Directory.GetFiles(pathRootWeb);

            foreach (string file in files)
            {
                //para filtrar if (file != "index.html")
                File.Delete(file);
            }

            //creando la página web dinámicamente.
            string pathListado = pathRootWeb + "\\listado.html";

            FileStream fs = null;
            StreamWriter sr = null;
            try
            {
                fs = new FileStream(pathListado, FileMode.OpenOrCreate, FileAccess.Write);
                sr = new StreamWriter(fs);

                sr.WriteLine("<html>");

                #region encabezado del documento html
                sr.WriteLine("<head>");

                //arregla los problemas de acentos.
                //https://www.w3schools.com/charsets/
                sr.WriteLine("<meta http-equiv=\"Content-Type\" content=\"text/html;charset=UTF-8\">");

                sr.WriteLine("<title>Ejemplo de listado de personas</title>");

                sr.WriteLine("<style>");
                sr.WriteLine("body {background-color: linen;}");
                sr.WriteLine("table, th, td { border: 1px solid black; padding: 15px;}");
                sr.WriteLine("</style>");

                sr.WriteLine("</head>");
                #endregion

                #region cuerpo del documento html
                sr.WriteLine("<body>");

                sr.WriteLine("<h2>Ejemplo de Listado de personas.</h2>");

                sr.WriteLine("<table style=\"width:100%\">");
                sr.WriteLine("<tr><td>DNI</td><td>Nombres y Apellido</td><td>Imagen</td></tr>");
                int imgNro = 0;
                foreach (Persona persona in listado)
                {
                    #region crea la imagen temporal
                    string imagenPath = "img" + (imgNro++).ToString("000") + ".jpg";
                    Bitmap bmp = new Bitmap(persona.Imagen, 100, 100);
                    bmp.Save(pathRootWeb + "\\" + imagenPath, System.Drawing.Imaging.ImageFormat.Jpeg);
                    #endregion

                    //genera la linea del html
                    string linea = $"<tr><td>{persona.Dni}</td><td>{persona.Nombre}</td></td></td><td><img src=\"./{imagenPath}\"/></td></tr>";

                    sr.WriteLine(linea);
                }
                sr.WriteLine("</table>");

                sr.WriteLine("</body>");

                #endregion

                sr.WriteLine("</html>");
            } 
            catch (Exception ex)
            {
                //completar!
            }
            finally
            {
                if (fs != null)
                {
                    if (sr != null) sr.Close();
                    fs.Close();
                }
            }

            return pathListado;
        }

    }
}
