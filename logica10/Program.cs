using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Definindo um array de inteiros 

            int[] numeros = { 5, 12, 3, 8, 7, 10, 15 };

            //Valor que queremos encontrar
            int valorProcurado = 8;

            // Chamada para a função de pesquisa sequencial 
            int resultado = PesquisaSequencial(numeros, valorProcurado);

            // Exibe o resultado
            if (resultado != -1)
            {
                Console.WriteLine($"Valor {valorProcurado} encontrado no índice {resultado}");
            }
            else
            {
                Console.WriteLine($"Valor {valorProcurado} não encontrado");
            }
            
        }

        //Função para realizar a pesquisa sequencial
        static int PesquisaSequencial(int[] array, int valor)
        {
            // Percorrendo o array
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == valor)
                {
                    return i; // Retorna o indice onde o valor foi encontrado
                }
            }

            return -1; // Retorna -1 se o valor não for encontrado
        }
    }
}
