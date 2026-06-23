using BSF_ListaAd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS_ListaAd
{
    internal class GrafoBFS
    {
        private int v;
        private ListaEnlazadaDoble[] adj;

        public GrafoBFS(int v)
        {
            this.v = v;
            adj = new ListaEnlazadaDoble[v];
            for(int i = 0; i< adj.Length; i++)
            {
                adj[i] = new ListaEnlazadaDoble();
            }
        }

        public void AgregarArista(int v, int w)
        {
            adj[v].AgregaFin(w);
        }


        public void BFS(int inicio)
        {
            bool[] visitado = new bool[v];

            Cola cola = new Cola();

            visitado[inicio] = true;
            cola.Encolar(inicio);

            while (!cola.EstaVacia())
            {
                int actual = cola.Desencolar();

                Console.Write(actual + " ");

                ListaEnlazadaDoble vecinos = adj[actual];

                for (int i = 0; i < vecinos.Length(); i++)
                {
                    int vecino = vecinos.Get(i);

                    if (!visitado[vecino])
                    {
                        visitado[vecino] = true;
                        cola.Encolar(vecino);
                    }
                }
            }
        }
    }   
}
