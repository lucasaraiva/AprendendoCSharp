﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7");

            int idadeJoao = 16;

            int quantidadePessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("Joao possui mais de 18 anos de idade");

            }
            else
            {
                if(quantidadePessoas >= 2)
                {
                    Console.WriteLine("Joao está acompanhado, pode entrar");
                }
                else
                {
                    Console.WriteLine("Joao nao pode entrar");
                }

                
            }

            Console.ReadLine();
        }
    }
}
