using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco_POO;

namespace Banco_POO
{
    internal class ContaCorrente
    {
        public Cliente Titular;
        public int NumeroAgencia;
        public int NumeroConta;
        private double _Saldo;

        public double Saldo
        {
            get
            {
                return _Saldo;
            }
            set 
            { 
             if(value < 0)
                {
                    return;
                }
                _Saldo = value;
            } 
        }
        public void SacaDinheiro(double Valor)
        {
               if(Valor <= this._Saldo)
               {
                this._Saldo -= Valor;
               
               }
            else
            {
                Console.WriteLine("O valor que deseja sacar é menor que o saldo de sua conta");
            }       
        }

        public void Deposita(double Valor)
        {
            if (Valor > 0)
            {
                this._Saldo += Valor;
                Console.WriteLine("Deposito efetuado");
            }
            else
            {
                Console.WriteLine("Você está tentando depositar um valor negativo");
            }
        }

        public void FazOPix(double valor, ContaCorrente contaDestino)
        {
            if(valor <= this._Saldo)
            {
                contaDestino._Saldo += valor;
                Console.WriteLine("Tranferência efetuada com sucesso");
            }
            else
            {
                Console.WriteLine("Você está tentando transferir um valor maior do que o possuido, seu saldo atual é: " + this._Saldo);
            }
        }

    }
}    