using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4__ConversaoDeTiposNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 4 - Conversão de tipos numericos.");

            double salario = 1200.50;

            int salarioEmInteiro;//32bits

            //salarioEmInteiro = salario; - Não é possivel converter
            salarioEmInteiro = (int) salario; // Casting 

            Console.WriteLine(salarioEmInteiro);

            long idade; //64bits
            idade = 13000000000000000;

            short qtdprod;// 16bits

            qtdprod = 16000;

            float altura;
            altura = 1.80f;

            Console.WriteLine("...");

            Console.ReadLine();

        }
    }
}
