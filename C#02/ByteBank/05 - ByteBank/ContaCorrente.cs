using System;

namespace _05___ByteBank
{
    public class ContaCorrente
    {

        public Cliente titular;
        public int agencia;
        public int numero;
        public double saldo = 100;

        public void SetSaldo(double saldo)
        {
            if(saldo < 0)
            {
                return;
            }

            this.saldo = saldo;
        }
        public double GetSaldo()
        {
            return saldo;
        }

        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                return false;
            }
            
            
                saldo -= valor;
                Console.WriteLine("saldo: " + this.saldo);
                return true;
            
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Trasnferir(double valor, ContaCorrente conta)
        {
            if (saldo < valor)
            {
                return false;
            }

            this.Sacar(valor);
            conta.Depositar(valor);
            return true;

        }
    }
}
