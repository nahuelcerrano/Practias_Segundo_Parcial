using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_ABM_Pacientes
{
    internal class ListaPaciente
    {
        public Paciente inicio;

        public void AgregarPrincipio(Paciente paciente)
        {
            if(inicio == null)
            {
                inicio = paciente;
            }
            else
            {
               Paciente aux = inicio;
               inicio = paciente;
               inicio.Siguiente = aux;
            }
        }

        public Paciente EliminarPrincipio()
        {
            Paciente eliminado = null;
            if(inicio != null)
            {
                eliminado = inicio;
                inicio = inicio.Siguiente;
                eliminado.Siguiente = null;
            }

            return eliminado;
        }

        public Paciente BuscarPorCodigo(int codigo)
        {
            return BuscarPaciente(inicio, codigo);
        }

        public Paciente BuscarPaciente(Paciente actual, int codigo)
        {
            Paciente encontrado = null;

            if(actual == null || actual.Codigo == codigo)
            {
                encontrado = actual;
            }
            else
            {
                encontrado = BuscarPaciente(actual.Siguiente, codigo);
            }

            return encontrado;
        }

        public Paciente EliminadoPorCodigo(int codigo)
        {
            Paciente eliminado = null;

            if(inicio != null)
            {
                if(inicio.Codigo == codigo)
                {
                    eliminado = EliminarPrincipio();
                }
                else
                {
                    eliminado = EliminarPorCodigoRecursiva(inicio, codigo);
                }

            }
            
            return eliminado;
        }

        public Paciente EliminarPorCodigoRecursiva(Paciente actual, int codigo)
        {
            Paciente eliminado = null;

            if(actual != null && actual.Siguiente != null)
            {
                if(actual.Siguiente.Codigo == codigo)
                {
                    eliminado = actual.Siguiente;
                    actual.Siguiente = actual.Siguiente.Siguiente;
                    eliminado.Siguiente = null;
                }
                else
                {
                    eliminado = EliminarPorCodigoRecursiva(actual.Siguiente, codigo);
                }
            }

            return eliminado;
        }

        public Paciente AgregarDespues(Paciente nuevo, int codigo)
        {
            Paciente agregado = null;

            if(inicio.Siguiente != null)
            {
                if(inicio.Codigo == codigo)
                {
                    nuevo.Siguiente = inicio.Siguiente;
                    inicio.Siguiente = nuevo;
                    agregado = nuevo;
                }
                else
                {
                    agregado = AgregarDespuesRecursiva(inicio, nuevo, codigo);
                }
            }

            return agregado;
        }

        public Paciente AgregarDespuesRecursiva(Paciente actual, Paciente nuevo, int codigo)
        {
            Paciente agregado = null;

            if(actual != null && actual.Siguiente != null)
            {
                if(actual.Siguiente.Codigo == codigo)
                {
                    nuevo.Siguiente = actual.Siguiente.Siguiente;
                    actual.Siguiente.Siguiente = nuevo;
                    agregado = nuevo;
                }
                else
                {
                    agregado = AgregarDespuesRecursiva(actual.Siguiente, nuevo, codigo);
                }
            }

            return agregado;
        }
    }
}
