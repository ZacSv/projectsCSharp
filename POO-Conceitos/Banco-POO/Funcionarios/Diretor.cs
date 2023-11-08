using Banco_POO.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_POO.Funcionarios
{
    public class Diretor : Autenticavel
    {
        public Diretor(string cpf, double salarioBase) : base(cpf, salarioBase)
        {
            
        }
        public override double GetBonificacao()
        {
            return this.Salario; //Retorna salario completo pois a bonificação é de 100%
        }

        public override void AumentaSalario()
        {
            Salario *= 1.15;
        }
    }
}
