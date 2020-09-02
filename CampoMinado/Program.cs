using System;
using System.Numerics;
using System.Collections.Generic;
using System.Windows.Vector;

namespace CampoMinado
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(1);
            Vector vectorResult = Vector.Parse("1,3");
            int valorAleatorio;
            var vetores = new List<int> {1};

            for (int tabuleiro = 1; tabuleiro <= 30; tabuleiro++)
            {
                valorAleatorio = rnd.Next();
                if (valorAleatorio%2 == 0)
                {
                    valorAleatorio = 1;
                }else{
                    valorAleatorio = 0;
                }

                Console.Write($"|{valorAleatorio}");
                vetores.Add(valorAleatorio);

                    if(tabuleiro % 5 == 0)
                {
                    Console.Write("|\n");
                }
            }
           /* int contador = 1;
            do
            {
                Console.Write($"{contador}º - {vetores[contador]}   ");
                if(contador%5 == 0)
                {
                    Console.Write("\n");
                }
                contador++;
            } while (contador <= 30);
            Console.ReadLine();
        } */
        for(int contador =1; contador<=30; contador++)
            {
                if(vetores[contador] == 1)
                {
                    statusCasa[contador] = "Bomba";
                }else if (vetores[contador] == 0){
                    for(int x = -6; x<=6; x++) {
                        if (statusCasa[contador + x] == "Bomba")
                        {
                            statusCasa[contador]++;
                        }
                    }
                    
                }
            }

    }
}
