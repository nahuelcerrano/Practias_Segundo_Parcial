using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_ABM_Alumnos_2
{
    internal class ListaAlumnos
    {
        public Alumnos inicio;

        public void AgregarInicio(Alumnos alumno)
        {
            if (inicio == null)
            {
                inicio = alumno;
            }
            else
            {
                Alumnos aux = inicio;
                inicio = alumno;
                inicio.Siguiente = aux;
            }
        }
        public Alumnos EliminarInicio()
        {
            Alumnos eliminado = null;

            if(inicio != null)
            {
                eliminado = inicio;
                inicio = inicio.Siguiente;
                eliminado.Siguiente = null;
            }

            return eliminado;
        }
        public Alumnos BuscarPorDni(int dni)
        {
            return BuscarPorDniRecursiva(inicio, dni);
        }
        public Alumnos BuscarPorDniRecursiva(Alumnos actual, int dni)
        {
            Alumnos encontrado = null;

            if(actual == null || actual.Dni == dni)
            {
                encontrado = actual;
            }
            else
            {
                encontrado = BuscarPorDniRecursiva(actual.Siguiente, dni);
            }

            return encontrado;
        }
        public Alumnos EliminarPorDni(int dni)
        {
            Alumnos eliminado = null;

            if(inicio != null)
            {
                if(inicio.Dni == dni)
                {
                    eliminado = EliminarInicio();
                }
                else
                {
                    eliminado = EliminarPorDniRecursiva(inicio, dni);
                }
            }

            return eliminado;
        }
        public Alumnos EliminarPorDniRecursiva(Alumnos actual, int dni)
        {
            Alumnos eliminado = null;
            if(actual != null && actual.Siguiente != null)
            {
                if(actual.Siguiente.Dni == dni)
                {
                    eliminado = actual.Siguiente;
                    actual.Siguiente = actual.Siguiente.Siguiente;
                    eliminado.Siguiente = null;
                }
                else
                {
                    eliminado = EliminarPorDniRecursiva(actual.Siguiente, dni);
                }
            }

            return eliminado;
        }
        public Alumnos AgregarDespues(Alumnos nuevo, int dni)
        {
            Alumnos agregado = null;

            if(inicio != null)
            {
                if (inicio.Dni == dni)
                {
                    nuevo.Siguiente = inicio.Siguiente;
                    inicio.Siguiente = nuevo;
                    agregado = nuevo;
                }
                else
                {
                    agregado = AgregarDespuesRecursiva(inicio, nuevo, dni);
                }
            }

            return agregado;
        }
        public Alumnos AgregarDespuesRecursiva(Alumnos actual, Alumnos nuevo, int dni)
        {
            Alumnos agregado = null;

            if(actual != null && actual.Siguiente != null)
            {
                if(actual.Dni == dni)
                {
                    nuevo.Siguiente = actual.Siguiente.Siguiente;
                    actual.Siguiente.Siguiente = nuevo;
                    agregado = nuevo;
                }
                else
                {
                    agregado = AgregarDespuesRecursiva(actual.Siguiente, nuevo, dni);
                }
            }

            return agregado;
        }
        
    }
}
