using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestaCondicional2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 Escopo");

            int idadeJoao = 16;
            int quantidadePessoas = 3;
            bool acompanhado = quantidadePessoas >= 2;
           

           


            if (idadeJoao >= 18 && acompanhado == true)
            {
                Console.WriteLine("Liberado");
                

            }

            else
            {
                Console.WriteLine("Joao nao pode entrar");
            }



            Console.ReadLine();
        }
    }
}
