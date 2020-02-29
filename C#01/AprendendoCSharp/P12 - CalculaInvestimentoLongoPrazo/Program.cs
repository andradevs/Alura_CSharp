using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12___CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            double fatorRendimento = 1.0036;
            double valorInvestido = 1000;
            for (int ano = 1; ano <= 5; ano++)
            {
                for(int mes = 1; mes<=12; mes++)
                {
                    valorInvestido *= fatorRendimento;
                    Console.WriteLine(valorInvestido);
                }
                fatorRendimento += 0.0010;
            }
            Console.WriteLine("TOTAL: " + valorInvestido);

            Console.ReadLine();
            
        }
    }
}
