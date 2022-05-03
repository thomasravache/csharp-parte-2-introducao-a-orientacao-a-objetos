using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_primeira_classe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente(); // Uma nova instancia de conta corrente

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.saldo = 2000;
            contaDaGabriela.numero = 123;

            Console.WriteLine(contaDaGabriela.titular);

            Console.ReadLine();
        }
    }
}
