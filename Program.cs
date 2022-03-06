using System;

namespace NETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            
            conta.titular = "Fulano";
            conta.numero = 54321;
            conta.agencia = 321;
            conta.saldo = 12300000.98;

            Console.WriteLine("Titular da conta: " + conta.titular);
            Console.WriteLine("Número da conta: " + conta.numero);
            Console.WriteLine("Agência da conta: " + conta.agencia);
            Console.WriteLine("Saldo da conta: " + conta.saldo);
        }
    }
}
