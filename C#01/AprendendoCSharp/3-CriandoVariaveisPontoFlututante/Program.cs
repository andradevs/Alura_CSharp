using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlututante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 3 - Criando Variaveis Ponto Flutuante.");

            double salario = 1200.70;

            double idade = 15 / 2;

            Console.WriteLine(idade); // não vai ter a casa decimal.

            idade = 15.0 / 2;

            Console.WriteLine(idade); // com casa decimal.



            Console.WriteLine(salario);

            Console.WriteLine("Prejeto excecutado ...");

            Console.ReadLine();


        }
    }
}
