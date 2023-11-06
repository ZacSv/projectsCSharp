﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_POO.Funcionarios
{
    public class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        public virtual double GetBonificacao()
        {
            return this.Salario * 0.1;
        }

        public Funcionario(string cpf, double salarioBase)
        {
            this.Salario = salarioBase;
            this.CPF = cpf;
            TotalDeFuncionarios += TotalDeFuncionarios;
        }

        public virtual void AumentaSalario()
        {
             Salario = Salario * 1.1;
        }

    }
}
