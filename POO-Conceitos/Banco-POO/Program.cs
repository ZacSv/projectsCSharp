using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoToninho = new ContaCorrente();
            Cliente Toninho = new Cliente();
            contaDoToninho.Titular = Toninho;
            contaDoToninho.Deposita(1000);
            Console.Write(contaDoToninho.Saldo);  
            Console.ReadKey();
        }
    }
}
