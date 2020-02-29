using System;

namespace _06___ByteBank
{
    public class ContaCorrente
    {

        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                    return;
                _saldo = value;
            }
        }
        


        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            
            
                _saldo -= valor;
                return true;
            
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Trasnferir(double valor, ContaCorrente conta)
        {
            if (_saldo < valor)
            {
                return false;
            }

            this.Sacar(valor);
            conta.Depositar(valor);
            return true;

        }
    }
}
