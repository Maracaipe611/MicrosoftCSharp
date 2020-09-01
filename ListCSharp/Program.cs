using System;
using System.Collections.Generic;

namespace ListCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>{"Lucas", "Gabriel", "Milena"};
            Console.WriteLine($"A lista possui {names.Count} nomes. E o primeiro é {names[0]}");

            names.Add("Mario");
            names.Add("Cris");
            names.Remove("Lucas");

            Console.WriteLine($"Agora a lista possui {names.Count} nomes. E o primeiro é {names[0]}");

            var index = names.IndexOf("Milena");
            Console.WriteLine($"O nome da {names[index]}, é"/* Necessário adicionar + 1 à variável index pois a listagem
            inicia-se em 0. Pois se caso ignorado, teríamos o "Gabriel" na posição 0 */+ $" o {index + 1}º da lista");

            /* Caso eu indique um nome que não exista na lista, como no exemplo a seguir, o retorno será -1 (indexof) */
            index = names.IndexOf("Higor");
            if(index == -1){
                Console.WriteLine("Nome não encontrado");
            }else{/* Essa parte será ignorada pois é false */
                Console.WriteLine($"O nome da {names[index]}, é o {index + 1}º da lista");
            }
            
        }
    }
}
