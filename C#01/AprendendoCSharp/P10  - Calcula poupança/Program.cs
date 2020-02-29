using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10____Calcula_poupança
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes = 1;
            double valorInvestido = 1000;
            //0.36% = 0.0036
            
 

            while(mes < 13)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Apos " + mes + " mes o valor sera: " + valorInvestido);
                mes++;

            }

            Console.ReadLine();

        }
    }
}
