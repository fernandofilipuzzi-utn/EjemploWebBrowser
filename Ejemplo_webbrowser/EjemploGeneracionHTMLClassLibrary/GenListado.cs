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
        public List<Persona> ListarPersonas()
        {
            List<Persona> listado = new List<Persona>();

            #region genero un listado de prueba
            listado.Clear();
            listado.Add(new Persona { Dni=34030100,  Nombre="Juan de La Cruz", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona { Dni = 34030100,  Nombre="Josefina Marcela Ham", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona { Dni = 35030100,  Nombre="Ana María Jeferson", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona { Dni = 25030100,  Nombre="Ricardo Milanesio", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona { Dni = 25030130,  Nombre="Marcelo Sincinatti", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona { Dni = 31030100,  Nombre="Micaela Neuman", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona { Dni = 31030200,  Nombre="Jorgelina Lumila Lopez", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona { Dni = 31030112,  Nombre="Ernesto Roberson", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona { Dni=10031116,  Nombre="Liliana", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona { Dni=11031113,  Nombre="Carlos M.", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=11031111,  Nombre="Alberto Reinaldo Rey", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=41031111,  Nombre="Juan Telermann", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=41031111,  Nombre="Mirco Telermann", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=41031111,  Nombre="Mirco Telermann", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=34030100,  Nombre="Juan de La Cruz", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=34030100,  Nombre="Josefina Marcela Ham", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=35030100,  Nombre="Ana María Jeferson", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=25030100,  Nombre="Ricardo Milanesio", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=25030130,  Nombre="Marcelo Sincinatti", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=31030100,  Nombre="Micaela Neuman", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=31030200,  Nombre="Jorgelina Lumila Lopez", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=31030112,  Nombre="Ernesto Roberson", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=10031116,  Nombre="Liliana", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=11031113,  Nombre="Carlos M.", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=11031111,  Nombre="Alberto Reinaldo Rey", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=41031111,  Nombre="Juan Telermann", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=41031111,  Nombre="Mirco Telermann", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=41031111,  Nombre="Mirco Telermann", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=34030100,  Nombre="Juan de La Cruz", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=34030100,  Nombre="Josefina Marcela Ham", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=35030100,  Nombre="Ana María Jeferson", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=25030100,  Nombre="Ricardo Milanesio", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=25030130,  Nombre="Marcelo Sincinatti", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=31030100,  Nombre="Micaela Neuman", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=31030200,  Nombre="Jorgelina Lumila Lopez", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=31030112,  Nombre="Ernesto Roberson", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=10031116,  Nombre="Liliana", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=11031113,  Nombre="Carlos M.", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=11031111,  Nombre="Alberto Reinaldo Rey", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=41031111,  Nombre="Juan Telermann", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=41031111,  Nombre="Mirco Telermann", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=41031111,  Nombre="Melina Telermann", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=34030100,  Nombre="Juan de La Cruz", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=34030100,  Nombre="Josefina Marcela Ham", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=35030100,  Nombre="Ana María Jeferson", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=25030100,  Nombre="Ricardo Milanesio", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=25030130,  Nombre="Marcelo Sincinatti", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=31030100,  Nombre="Micaela Neuman", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=31030200,  Nombre="Jorgelina Lumila Lopez", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=31030112,  Nombre="Ernesto Roberson", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=10031116,  Nombre="Liliana", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=11031113,  Nombre="Carlos M.", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=11031111,  Nombre="Alberto Reinaldo Rey", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=41331111,  Nombre="Juan Telermann", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=41031111,  Nombre="Mirco Telermann", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=41031111,  Nombre="Mirco Telermann", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=34030100,  Nombre="Juan de La Cruz", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=34040100,  Nombre="Leonor Ham", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=35030100,  Nombre="Ana María Jeferson", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=25050100,  Nombre="Ricardo Milanesio", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=25030130,  Nombre="Marcelo Sincinatti", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=31050100,  Nombre="Luciana Neuman", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=31030200,  Nombre="Jorgelina Lumila Lopez", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=31330112,  Nombre="Ernesto Roberson", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=22031116,  Nombre="Liliana", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=11031113,  Nombre="Carlos M.", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=11021411,  Nombre="Alberto Reinaldo Rey", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=41031101,  Nombre="Juan Telermann", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=21036710,  Nombre="Mirco Telermann", Imagen=Properties.Resources.Persona });
            listado.Add(new Persona{ Dni=31031171,  Nombre="Miriam Neuman", Imagen=Properties.Resources.Persona });
            #endregion

            return listado;
        }
    }
}
