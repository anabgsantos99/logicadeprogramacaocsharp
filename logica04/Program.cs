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

            //if-----------------------------------------------------------------

            if (nome == "Ana")
            {
                Console.WriteLine("Olá, Ana!");
            }

            string texto = "";

            if (string.IsNullOrEmpty(texto))
            {
                Console.WriteLine("A string está vazia.");
            }

            //else---------------------------------------------------------------

            int idade = 16;

            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade.");
            }

            else
            {
                Console.WriteLine("Você é menor de idade.");
            }

            //else if------------------------------------------------------------

            double nota = 6.5;

            if (nota >= 9.0)
            {
                Console.WriteLine("Você obteve uma excelente nota! Aprovado(a) com distinção.");
            }
            else if (nota >= 7.0)
            {
                Console.WriteLine("Você está aprovado(a).");
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
                Console.WriteLine("Você foi reprovado(a).");
            }


            //switch-------------------------------------------------------------

            double pontuacao = 8.5;

            //arredondar a nota para o inteiro mais próximo----------------------
            int faixaNota = (int)Math.Round(pontuacao);

            switch (faixaNota)
            {
                case 10:
                    Console.WriteLine("Você obteve uma excelente nota! Aprovado(a) com distinção.");
                    break;

                case 9:
                case 8:
                    Console.WriteLine("Você está aprovado(a).");
                    break;

                case 7:
                case 6:
                    Console.WriteLine("Você está em recuperação.");
                    break;

                case 5:
                case 4:
                case 3:
                    Console.WriteLine("Você está com risco de reprovação.");
                    break;

                default:
                    Console.WriteLine("Você foi reprovado(a).");
                    break;
            }


        }
    }
}