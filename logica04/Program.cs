using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Ana";

            if (nome == "Ana")
            {
                Console.WriteLine("Olá, Ana!");
            }

            string texto = "";

            if (string.IsNullOrEmpty(texto))
            {
                Console.WriteLine("A string está vazia.");
            }

            int idade = 16;

            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade.");
            }

            else
            {
                Console.WriteLine("Você é menor de idade.");
            }

            //else if
            double nota = 6.5;

            if (nota >= 9.0)
            {
                Console.WriteLine("Você obteve uma excelente nota! Aprovado com distinção.");
            }
            else if (nota >= 7.0)
            {
                Console.WriteLine("Você está aprovado.");
            }
            else if (nota >= 5.0)
            {
                Console.WriteLine("Você está em recuperação.");
            }
            else if (nota >= 3.0)
            {
                Console.WriteLine("Você está com risco de reprovação.");
            }
            else
            {
                Console.WriteLine("Você foi reprovado.");
            }
        }
    }
}