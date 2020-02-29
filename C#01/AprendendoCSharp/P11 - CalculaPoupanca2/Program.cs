using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11___CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorInvestido = 1000;

            for(int mes = 1;mes <= 12; mes++)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Apos " + mes + " mes o valor sera: " + valorInvestido);
            }


            Console.ReadLine();
        }
    }
}
