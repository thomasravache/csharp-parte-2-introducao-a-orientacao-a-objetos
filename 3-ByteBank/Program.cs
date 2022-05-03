using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.titular = "Teste";
            conta.agencia = 863;
            conta.numero = 863452;

            ContaCorrente conta2 = new ContaCorrente();
            conta2.titular = "Teste";
            conta2.agencia = 863;
            conta2.numero = 863452;

            int idade = 1;
            int idade2 = 1;

            // Para uma classe só há um apontamento de referência e não de valor
            Console.WriteLine(conta == conta2); // false pois conta um e conta2 são tipos de referência ou seja, a ref. da conta é diferente da conta2
            Console.WriteLine(idade == idade2); // true pois valor 1 é igual ao valor 1
        }
    }
}
