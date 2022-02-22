using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando Condicionais");

            int idade = 20;

            int quantidadePessoas = 3;

            if (idade >= 18)
            {
                Console.WriteLine("Liberado");
                Console.WriteLine("Bien Vindo");
            }


            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("Está acompanhado com maior de idade , pode entrar ");
                }
                else
                {
                    Console.WriteLine("Negado");
                }
                
            }


            Console.ReadLine();
        }
    }
}
