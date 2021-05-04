using System;

namespace testbank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente();
            conta1.titularDaConta = "Fulano";
            conta1.numeroDaConta = 111111;
            conta1.numeroDaAgencia = 123;
            conta1.saldoDaConta = 10.00;

            ContaCorrente conta2 = new ContaCorrente();
            conta2.titularDaConta = "Ciclano";
            conta2.numeroDaConta = 111112;
            conta2.numeroDaAgencia = 123;
            conta2.saldoDaConta = 20.00;

            Console.WriteLine("O nome do tilular é: " + conta1.titularDaConta);
            Console.WriteLine("O nome do tilular é: " + conta2.titularDaConta);
            Console.ReadLine();

        }
    }
}

