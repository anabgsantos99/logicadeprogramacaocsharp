using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //for - Para --------------------------------------------------

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            /* for (;;)
            {
                Console.WriteLine("Este é um loop infinito!");
            } */

            //while - Enquanto --------------------------------------------
            
            int contador = 1;

            while (contador <= 5)
            {
                Console.WriteLine(contador);
                contador++; // Incrementa o contador
            }

            //Do while -  Faça enquanto------------------------------------

            int novocontador = 2;

            do
            {
                Console.WriteLine(novocontador);
                novocontador++; // Incrementa o contador
            }
            while (novocontador <= 5);

            //Laço Foreach
            //Uma lista de strings - array

            List<string> nomes = new List<string> { "Ana", "Carlos", "João", "Maria"};

            // Usando o foreach para percorrer a lista
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome); // Imprime cada nome 
            }

            // Um vetor de números inteiros 
            int[] numeros = { 1, 2, 3, 4, 5 };

            // Usando o foreach para percorrer a lista
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero); // Imprime cada número 
            }


        }
    }
}
