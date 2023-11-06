using Banco_POO.Funcionarios;
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
            Funcionario Isac = new Diretor();
            Funcionario Karyne = new Funcionario();

            Isac.Salario = 5000;
            Karyne.Salario = 5000;

            Console.WriteLine(Isac.GetBonificacao());
            Console.WriteLine(Karyne.GetBonificacao());
            Console.ReadKey();
        }
    }
}
