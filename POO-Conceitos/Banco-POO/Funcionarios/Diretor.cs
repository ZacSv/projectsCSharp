using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_POO.Funcionarios
{
    internal class Diretor : Funcionario
    {
        public override double GetBonificacao()
        {
            return this.Salario; //Retorna salario completo pois a bonificação é de 100%
        }
    }
}
