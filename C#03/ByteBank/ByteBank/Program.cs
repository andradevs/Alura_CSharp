﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            //CalcularBonificacao();

            UsarSistema();
            Console.ReadLine();

        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";
            camila.Senha = "123";

            ParceiroComercial julio = new ParceiroComercial();
            julio.Senha = "12345";
           

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "123");
            sistemaInterno.Logar(julio, "12345");



        }

        public static void CalcularBonificacao()
        {
            GerenciadoBonificacao gerenciadoBonificacao = new GerenciadoBonificacao();

            Funcionario pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Funcionario roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";

            Funcionario igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            Funcionario camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";

            gerenciadoBonificacao.Registrar(pedro);
            gerenciadoBonificacao.Registrar(roberta);
            gerenciadoBonificacao.Registrar(igor);
            gerenciadoBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificações do mês " +
                gerenciadoBonificacao.GetTotalBonificacao());
        }
    }
}
