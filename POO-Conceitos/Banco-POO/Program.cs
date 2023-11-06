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
            Funcionario Isac = new Funcionario(ECargos.Diretoria);
            Funcionario Fabiana = new Funcionario(ECargos.Gerencia);
            Funcionario Juscelino = new Funcionario(ECargos.Monitoria);
            Funcionario Jaqueline = new Funcionario(ECargos.Operacao);

            Isac.Salario = 5000;
            Fabiana.Salario = 5000;
            Juscelino.Salario = 5000;
            Jaqueline.Salario = 5000;

            Console.WriteLine(Isac.GetBonificacao());
            Console.WriteLine(Fabiana.GetBonificacao());
            Console.WriteLine(Juscelino.GetBonificacao());
            Console.WriteLine(Jaqueline.GetBonificacao());

            Console.ReadKey();
        }
    }
}
