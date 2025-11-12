using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_ABM_Alumnos_2
{
    internal class Alumnos
    {
        public Alumnos(int dni = 0, string nombre = "", string apellido = "", DateTime? fechaNac = null, string direccion = "", int tel = 0, Alumnos siguiente = null)
        {
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
            FechaNac = fechaNac;
            Direccion = direccion;
            Tel = tel;
            Siguiente = siguiente;
        }

        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime? FechaNac { get; set; }
        public string Direccion { get; set; }
        public int Tel { get; set; }
        public Alumnos Siguiente { get; set; }
    }
}
