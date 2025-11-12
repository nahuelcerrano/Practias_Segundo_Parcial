using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_ABM_Pacientes
{
    internal class Paciente
    {
        public Paciente (int codigo = 0, string nombre = "", string apellido = "", string direccion = "", int tel = 0, Paciente siguiente = null)
        {
            Siguiente = siguiente;
            Codigo = codigo;
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Tel = tel;
        }

        public Paciente Siguiente { get; set; }
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public int Tel { get; set; }
    }
}
