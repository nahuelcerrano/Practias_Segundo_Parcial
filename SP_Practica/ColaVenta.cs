using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_Practica
{
    internal class ColaVenta
    {
        private NodoVenta cp;
        public ColaVenta() { cp = new NodoVenta(); }

        public void Encolar(NodoVenta venta)
        {
            if (cp.Siguiente == null)
            {
                cp.Siguiente = venta;
            }
            else
            {
                BuscarUltimo().Siguiente = venta;
            }
        }

        public NodoVenta Desencolar()
        {
            NodoVenta eliminado = null;

            if(cp.Siguiente != null)
            {
                eliminado = cp.Siguiente;
                cp.Siguiente = eliminado.Siguiente;
                eliminado.Siguiente = null;
            }

            return eliminado;
        }

        public NodoVenta Ver()
        {
            NodoVenta actual = null;

            if(cp.Siguiente != null )
            {
                actual = cp.Siguiente;
            }

            return actual;
        }

        public NodoVenta BuscarUltimo()
        {
            return BuscarUltimoRecursiva(cp.Siguiente);
        }

        public NodoVenta BuscarUltimoRecursiva(NodoVenta actual)
        {
            NodoVenta ultimo = actual;

            if(ultimo.Siguiente != null)
            {
                ultimo = BuscarUltimoRecursiva(ultimo.Siguiente);
            }

            return ultimo;
        }
    }
}
