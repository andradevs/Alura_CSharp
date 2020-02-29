using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando 5 - Caracteres e textos");

            char primeiraLetra = 'a'; // Não permite "" 

            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;

            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1); //Casting

            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Curso em TECNOLOGIA " + 2020;

            string cursoProgramacao = " - .NET" +
                " - Java" +
                " - Javascript";

            Console.WriteLine(cursoProgramacao);

            Console.WriteLine(titulo);




            Console.ReadLine();
        }
    }
}
