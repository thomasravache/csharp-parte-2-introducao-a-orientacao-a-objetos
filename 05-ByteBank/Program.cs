using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {


            ContaCorrente conta = new ContaCorrente();

           // conta.titular = new Cliente();
            if (conta.titular == null)
            {
                Console.WriteLine("conta.titular é nula");
            }

            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 563527;

            Console.WriteLine(conta.titular.nome);

            Console.ReadLine();
        }
    }
}
