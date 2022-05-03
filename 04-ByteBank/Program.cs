using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            Console.WriteLine(conta.saldo);
            bool result = conta.Sacar(100);

            Console.WriteLine(result);
            Console.WriteLine(conta.saldo);

            conta.Depositar(100);

            Console.WriteLine(conta.saldo);

            ContaCorrente conta2 = new ContaCorrente();

            conta.Transferir(100, conta2);

            Console.WriteLine(conta.saldo);
            Console.WriteLine(conta2.saldo);

            Console.ReadLine();
        }
    }
}
