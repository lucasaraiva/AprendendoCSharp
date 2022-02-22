using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 Escopo");

            int idadeJoao = 16;
            bool acompanhado = true;
            string mensagemAdicional;

            if (acompanhado == true)
            {
                mensagemAdicional = "Joao esta acompanhado";
            }
            else
            {
                mensagemAdicional = "Joao nao esta acompanhado";
            }
        

            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("Liberado");
                Console.WriteLine(mensagemAdicional);

            }

            else
            {
                Console.WriteLine("Joao nao pode entrar");
            }



            Console.ReadLine();
        }
    }
}
