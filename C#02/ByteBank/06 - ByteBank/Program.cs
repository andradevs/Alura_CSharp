using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente gustavo = new Cliente();

            gustavo.Nome = "Gustavo";
            gustavo.CPF = "125.613.507-40";
            gustavo.Profissao = "Progamador c#";

            conta.Saldo = -10;

            conta.Titular = gustavo;

            Console.WriteLine(conta.Titular.Nome);

            Console.WriteLine(conta.Saldo);

            Console.ReadLine();
        }
    }
}
