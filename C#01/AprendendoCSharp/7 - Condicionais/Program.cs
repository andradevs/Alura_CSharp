using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7___Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            int idadeJoão = 16;
            int qtdPessoas = 2;

            if (idadeJoão >= 18)
            {
                Console.WriteLine("Jão passou");
            }
            else
            {
                if (qtdPessoas >= 2)
                {
                    Console.WriteLine("Agora pode cABAÇO");
                }
                else
                {
                    Console.WriteLine("Se fodeu Jão");


                }
            }

            Console.ReadLine();
        }
    }
}
