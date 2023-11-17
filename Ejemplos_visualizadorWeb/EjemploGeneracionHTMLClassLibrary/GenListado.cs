using EjemploGeneracionHTMLClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploGeneracionHTMLClassLibrary
{
    public class GenListado
    {
        static Random azar = new Random();
        int DNIGen
        {
            get
            {
                return azar.Next(5030100, 48030100);
            }
        }

        public List<Persona> ListarPersonas()
        {
            List<Persona> listado = new List<Persona>();


            #region genero un listado de prueba
            listado.Clear();
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Juan de La Cruz", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Josefina Marcela Ham", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Ana María Jeferson", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Ricardo Milanesio", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Marcelo Sincinatti", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Micaela Neuman", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Jorgelina Lumila Lopez", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Ernesto Roberson", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Liliana", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Carlos M.", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Alberto Reinaldo Rey", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Juan Telermann", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Mirco Telermann", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Mirco Telermann", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Juan de La Cruz", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Josefina Marcela Ham", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Ana María Jeferson", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Ricardo Milanesio", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Marcelo Sincinatti", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Micaela Neuman", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Jorgelina Lumila Lopez", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Ernesto Roberson", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Liliana Re", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Carlos M.", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Alberto Reinaldo Rey", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Juan Telermann", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Mirco Telermann", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "María Switch", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Juan de La Cruz", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Josefina Marcela Ham", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Ana María Jeferson", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Ricardo Milanesio", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Marcelo Sincinatti", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Micaela Neuman", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Jorgelina Lumila Lopez", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Ernesto Roberson", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Liliana", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Carlos M.", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Alberto Reinaldo Rey", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Juan Telermann", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Mirco Telermann", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Melina Telermann", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Juan de La Cruz", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Josefina Marcela Ham", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Ana María Jeferson", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Ricardo Milanesio", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Marcelo Sincinatti", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Micaela Neuman", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Jorgelina Lumila Lopez", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Ernesto Roberson", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Liliana", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Carlos M.", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Alberto Reinaldo Rey", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Juan Telermann", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Mirco Telermann", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Mirco Telermann", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Juan de La Cruz", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Leonor Ham", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Ana María Jeferson", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Ricardo Milanesio", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Marcelo Sincinatti", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Luciana Neuman", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Jorgelina Lumila Lopez", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Ernesto Roberson", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Liliana", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Carlos M.", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Alberto Reinaldo Rey", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Juan Telermann", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Mirco Telermann", Imagen = Properties.Resources.Persona });
            listado.Add(new Persona { Dni = DNIGen, Nombre = "Miriam Neuman", Imagen = Properties.Resources.Persona });
            #endregion

            return listado;
        }
    }
}
