using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.Titular = new Cliente();

            conta.Titular.Nome = "teste";

            conta.Saldo = 10;

            Console.WriteLine(conta.Titular.Nome);

            Console.ReadLine();
        }
    }
}
