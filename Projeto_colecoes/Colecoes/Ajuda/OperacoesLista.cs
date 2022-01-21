using System;

namespace Colecoes.Ajuda
{
    public class OperacoesLista
    {
        public void UsarBubleSort(ref int[] lista)
        {
            int temp = 0;

            for (int i = 0; i < lista.Length; i++)
            {
                for (int j = 0; j < lista.Length - 1; j++)
                {
                    if (lista[j] > lista[j + 1])
                    {
                        temp = lista[j + 1];
                        lista[j +1] = lista[j];
                        lista[j] = temp;
                    }                    
                }
            }
        }
        public void ImprimirLista(int[] lista)
        {
            var linha = string.Join(", ", lista);
            System.Console.WriteLine(linha);                
            
        }

        public void Ordenar(ref int[] lista)
        {
            Array.Sort(lista);
        }

        public void Copiar(ref int[] lista , ref int[] listaDestino)
        {
            Array.Copy(lista, listaDestino, lista.Length);
        }
    }
}