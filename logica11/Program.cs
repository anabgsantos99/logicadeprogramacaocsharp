using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica11
{
    //Definição da classe Pessoa
    internal class Pessoa
    {
       //Propriedades da classe
        public string Nome { get; set; }
        public int Idade { get; set; }

        //Método para exibir as informações da pessoa
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e eu tenho {Idade} anos.");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criando um objeto da classe Pessoa
            Pessoa pessoa1 = new Pessoa();

            //Solicitando informações do usuário
            Console.Write("Digite seu nome: ");
            pessoa1.Nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            pessoa1.Idade = int.Parse( Console.ReadLine() );

            //Chamando o método para apresentar as informações 
            pessoa1.Apresentar();

        }
    }
}
