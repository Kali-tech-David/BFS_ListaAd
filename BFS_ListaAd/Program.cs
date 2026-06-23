using System;
namespace BFS_ListaAd
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ListaEnlazadaDoble lista = new ListaEnlazadaDoble();


            GrafoBFS g = new GrafoBFS(4);
            g.AgregarArista(0, 1);
            g.AgregarArista(0, 2);
            g.AgregarArista(1, 2);
            g.AgregarArista(2, 0);
            g.AgregarArista(2, 3);
            g.AgregarArista(3, 3);

            g.BFS(2);
        }
    }
}