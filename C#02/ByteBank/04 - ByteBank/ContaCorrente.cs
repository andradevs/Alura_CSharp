using System;
public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo = 100;

    public bool Sacar(double valor)
    {
        if (this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
            Console.WriteLine("saldo: " + this.saldo);
            return true;
        }
    }

    public void Depositar(double valor)
    {
        this.saldo += valor;
    }

    public bool Trasnferir(double valor, ContaCorrente conta)
    {
        if (this.saldo < valor)
        {
            return false;
        }

        this.Sacar(valor);
        conta.Depositar(valor);
        return true;

    }
}