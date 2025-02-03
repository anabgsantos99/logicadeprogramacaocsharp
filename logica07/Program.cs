using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array
            string[] marcadecarro = { "Volvo", "BMW", "Ford", "BYD" };

            foreach (string carro in marcadecarro)
            {
                Console.WriteLine(carro);
            }

            for (int i = 0; i < marcadecarro.Length; i++)
            {
                Console.WriteLine(marcadecarro[i]);
            }

            Console.WriteLine(string.Join(", ", marcadecarro));

            //Mostrar apenas o valor de um índice
            Console.WriteLine(marcadecarro[2]);

            //Exibindo o comprimento do array
            Console.WriteLine(marcadecarro.Length);

            //Ordenação de forma crescente string de A - Z
            Array.Sort(marcadecarro);
            foreach (string ordenado in marcadecarro)
            {
                Console.WriteLine(ordenado);
            }

            //Ordenação de forma descrescente string de Z - A
            Array.Reverse(marcadecarro);
            foreach (string ordenado in marcadecarro)
            {
                Console.WriteLine(ordenado);
            }

            //análise de array
            int[] numeros = { 5, 1, 8, 9 };
            Console.WriteLine(numeros.Max());  // maior valor
            Console.WriteLine(numeros.Min());  // menor valor
            Console.WriteLine(numeros.Sum());  // soma todos os números
        }
    }
}
