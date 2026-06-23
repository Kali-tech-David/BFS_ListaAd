using BFS_ListaAd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSF_ListaAd
{
    internal class Cola
    {
        private Nodo primero;
        private Nodo ultimo;

        public Cola()
        {
            primero = null;
            ultimo = null;
        }

        public bool EstaVacia()
        {
            return primero == null;
        }

        public void Encolar(int valor)
        {
            Nodo nuevo = new Nodo(valor);

            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Anterior = ultimo;
                ultimo = nuevo;
            }
        }

        public int Desencolar()
        {
            if (EstaVacia())
                return int.MinValue;

            int valor = primero.Dato;

            if (primero == ultimo)
            {
                primero = null;
                ultimo = null;
            }
            else
            {
                primero = primero.Siguiente;
                primero.Anterior = null;
            }

            return valor;
        }

        public int Frente()
        {
            if (EstaVacia())
                return int.MinValue;

            return primero.Dato;
        }
    }
}
