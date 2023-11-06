using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_POO.Funcionarios
{
    internal class Gerente : Funcionario
    {
        public Gerente(string cpf, double salarioBase) : base(cpf, salarioBase)
        {

        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.5;
        }
    }
}
