using Banco_POO.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_POO.Sistemas
{
    public abstract class Autenticavel : Funcionario
    {
        public string Senha { get; set; }

        public Autenticavel(string cpf, double salarioBase) : base(cpf, salarioBase)
        {

        }
        public bool Autenticar(string senha)
        {
            return senha == Senha;
        }
    }
}
