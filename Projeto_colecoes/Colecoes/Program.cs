using System;
using Colecoes.Ajuda;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacoesLista op = new OperacoesLista();
            int[] lista = new int[5] {10, 8, 21, 5, 9};
            int[] listaCopia = new int[10];

            System.Console.WriteLine("Lista Original");
            op.ImprimirLista(lista);

            //op.UsarBubleSort(ref lista);

            //op.Ordenar(ref lista);

            //System.Console.WriteLine("Lista Ordenada");
            //op.ImprimirLista(lista);

            System.Console.WriteLine("Lista antes da cópia");
            op.ImprimirLista(listaCopia);
            op.Copiar(ref lista, ref listaCopia);
            System.Console.WriteLine("Array apos copia");
            op.ImprimirLista(listaCopia);
            

            // int[,] matriz = new int[4, 2]
            // {
            //         {10, 20},
            //         {25, 35},
            //         {40, 50}, 
            //         {1, 2}
            // };

            // for (int i = 0; i < matriz.GetLength(0); i++)            
            // {
            //     for (int x = 0; x < matriz.GetLength(1); x++)
            //     {
            //         System.Console.WriteLine(matriz[i, x]);
            //     }
            // }
            
            //  int[] listaInteiros = new int[5];

            //  listaInteiros[0] = 10;
            //  listaInteiros[1] = 20;
            //  listaInteiros[2] = 30;
            
            
            //  System.Console.WriteLine("usando o for");
            //  for (int i = 0; i < listaInteiros.Length; i++)
            // {
            //      System.Console.WriteLine(listaInteiros[i]);
            //  }
            //  System.Console.WriteLine("usando o foreach");
            //  foreach (int item in listaInteiros)
            //  {
            //      System.Console.WriteLine(item);
            //  }
            
        }
    }
}
