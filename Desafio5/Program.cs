using System;

namespace Desafio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string contUm = "))";
            string contDois = "((";
            string contTres = ")";
            string contQuatro = "))";
            string contCinco = "((";

            string[] exer = new string []
            {
                contUm,
                contDois,
                contTres,
                contQuatro,
                contCinco
            };
            
            //string[] lista = new string[]{};
            
            
            for (int i = 0; i < exer.Length; i++)
            {
                // string novoitem = exer[i];
                // List<string> list = new List<string>(exer.ToList());
                // var check = Array.Exists(list, x=>x==novoitem);
                // if (check == false)
                // {
                //     list.Add(exer[i]);
                    
                // }

                
                
                
                // string value = exer[i];
                // var check = Array.FindIndex(lista, x=>x==value );
                // if (check == -1)
                // {
                //     lista.Append(exer[i]);
                //     System.Console.WriteLine(lista[i]);
                // }
                // else
                // {
                // System.Console.WriteLine("Nada adicionado");
                // } 
            }
             

            // foreach (var y in lista)
            // {
            //     System.Console.WriteLine(y);
            // }

           // System.Console.WriteLine(exer[0]);

            // foreach (var j in exer)
            // {
            //     System.Console.WriteLine(j);                
            // }
            

        }
    }
}
