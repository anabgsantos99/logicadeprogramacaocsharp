using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Reutilização da função Somar
            int resultado1 = Somar(10, 20);
            Console.WriteLine($"A soma de 10 e 20 é: {resultado1}");

            //Solicitar ao usuário para inserir dois números 
            Console.Write("Digite o primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            // Chamar a função Somar e armazenar o resultado
            int resultado = Somar(numero1, numero2);

            //Exibir o resultado
            Console.WriteLine($"A soma dos dois números é: {resultado}");
        }

        // Função que soma dois números e retorna o resultado
        static int Somar(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
