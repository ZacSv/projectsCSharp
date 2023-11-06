using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_POO.Funcionarios
{
    public class Funcionario
    {

        public ECargos _Cargo;
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        public double GetBonificacao()
        {
            switch (this._Cargo)
            {
                case ECargos.Diretoria: return this.Salario * 1;
                case ECargos.Gerencia: return this.Salario * 0.5;
                case ECargos.Monitoria: return this.Salario * 0.2;
                case ECargos.Operacao: return this.Salario * 0.1;
                default: return 0;
            }
        }

        public Funcionario(ECargos cargo)
        {
            _Cargo = cargo;
        }

    }

    public enum ECargos
    {
        Operacao = 1,
        Monitoria = 2,
        Gerencia = 3,
        Diretoria = 4

    }
}
