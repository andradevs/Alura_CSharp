using System;

namespace _07___ByteBank
{
    public class ContaCorrente
    {
        
        public Cliente Titular { get; set; }
        private int _agencia;
        public int Agencia { get 
            {
                return _agencia;
            }
            set 
            {
                if (value < 0)
                    return;
                _agencia = value;
            } 
        }

        private int _numero;
        public int Numero { get 
            {
                return _numero;
            }
            set
            {
                if (value < 0)
                    return;
                _numero = value;
            }
        }
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

        public static int TotalDeContasCriadas { get; private set; }
        

        public ContaCorrente( int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
            TotalDeContasCriadas++;
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
