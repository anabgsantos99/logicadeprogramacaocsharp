using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaração e inicialização de uma matriz 3x3
            int[,] matriz2D = new int[3, 3]
            {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
            };

            foreach (var valor in matriz2D)
            {
                Console.Write(valor + " ");
            }

            //só para pular uma linha
            Console.WriteLine();


            //se fosse com laço for
            for (int i = 0; i < matriz2D.GetLength(0); i++)
            {
                for (int j = 0; j < matriz2D.GetLength(1); j++)
                {
                    Console.Write(matriz2D[i, j] + " ");
                }

            }

            // Declaração e inicialização de uma matriz 1D
            int[] matriz1D = new int[5] { 10, 20, 30, 40, 50 };

            // Exibindo os valores da matriz 1D
            for (int i = 0; i < matriz1D.Length; i++)
            {
                Console.WriteLine(matriz1D[i]);
            }

        }
    }
}
