using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8___Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            int idadeJoão = 16;
            int qtdPessoas = 2;

            bool acompanhado = qtdPessoas >= 2;

            //if (idadeJoão >= 18 || qtdPessoas >= 2)
            if (idadeJoão >= 18 && acompanhado)
            {
                Console.WriteLine("Jão passou");
            }
            else
            {
                Console.WriteLine("Se fodeu Jão");
            }

            Console.ReadLine();
        }
    }
}

