using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVaraiveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando Variaveis");

            int idade;

            // int idade = 32;

            idade = 32;

            Console.WriteLine(idade);

            idade += 3;

            Console.WriteLine(idade); // WriteLine pula linha.

            Console.WriteLine("SUA IDADE É:" + idade +"!");

            Console.Write(idade); //Write não pula linha.



            Console.WriteLine("Execução Finalizada, Tecla ENTER para sair ....");

            Console.ReadLine();
        }
    }
}
