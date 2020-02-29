using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9___Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            int idadeJoão = 16;
            int qtdPessoas = 2;
            string menssageAd;


            bool acompanhado = qtdPessoas >= 2;

            if (acompanhado)
	        {
                menssageAd = "Jão ta colcado";
	        }else{
                menssageAd = "N~~ao jão";
            }


            //if (idadeJoão >= 18 || qtdPessoas >= 2)
            if (idadeJoão >= 18 && acompanhado)
            {
                Console.WriteLine("Jão passou");
                Console.WriteLine(menssageAd);
            }
            else
            {
                Console.WriteLine("Se fodeu Jão");
            }

            Console.ReadLine();
        }
    }
}
