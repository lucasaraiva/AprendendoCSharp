using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando Variaveis");

            int idade;
            idade = 26;

            Console.WriteLine(idade);

            idade = 12;

            Console.WriteLine(idade);

            idade = 10 + 12;

            Console.WriteLine(idade);

            idade = 7 + 2 * 3;

            Console.WriteLine(idade);

            idade = (5 + 7) * 4;

            Console.WriteLine("Sua idade " + idade + "!");


            Console.WriteLine("Tecle Enter para sair");

            Console.ReadLine();
        }
    }
}
