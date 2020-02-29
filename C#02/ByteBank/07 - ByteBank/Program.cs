using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(856, 86712540);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            ContaCorrente conta2 = new ContaCorrente(332, 4214214);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);


            Console.ReadLine();

        }
    }
}
