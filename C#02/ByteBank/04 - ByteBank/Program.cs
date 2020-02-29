using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            ContaCorrente contaDaGabriela = new ContaCorrente();



            conta.titular = "Bruno";

            Console.WriteLine(conta.saldo);

            conta.Sacar(50);

            Console.WriteLine(conta.saldo);

            conta.Depositar(600);

            Console.WriteLine(conta.saldo);

            Console.WriteLine(contaDaGabriela.saldo);


            conta.Trasnferir(200, contaDaGabriela);

            Console.WriteLine(conta.saldo);
            Console.WriteLine(contaDaGabriela.saldo);






            Console.ReadLine();
        }
    }
}
