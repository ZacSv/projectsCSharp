using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
   
        static bool verificaValor(int arg)
        {
           if(arg < 0){

                return false;
            }
            return true;
        }
        static void somaValores(int arg1, int arg2)
        {
           int valorTotal = arg1 + arg2;
            bool resultado = verificaValor(valorTotal);
            if(resultado == false)
            {
                Console.WriteLine("O resultado da operação retornou um negativo, tente novamente...");
                
            }
            else
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("O valor da soma é: " + valorTotal);
                Console.WriteLine("--------------------------------------");
            }
            
        }
        static void subtraiValores(int arg1, int arg2)
        {
            int valorTotal = arg1 - arg2;
            bool resultado = verificaValor(valorTotal);
            if (resultado == false)
            {
                Console.WriteLine("O resultado da operação retornou um negativo, tente novamente...");

            }
            else
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("O valor da subtração é: " + valorTotal);
                Console.WriteLine("--------------------------------------");
            }
        }
        static void multiplicaValores(int arg1, int arg2)
        {
            int valorTotal = arg1 * arg2;
            bool resultado = verificaValor(valorTotal);
            if (resultado == false)
            {
                Console.WriteLine("O resultado da operação retornou um negativo, tente novamente...");

            }
            else
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("O valor da multiplicação é: " + valorTotal);
                Console.WriteLine("--------------------------------------");
            }
        }
        static void divideValores(int arg1, int arg2)
        {
            int valorTotal = arg1 / arg2;
            bool resultado = verificaValor(valorTotal);
            if (resultado == false)
            {
                Console.WriteLine("O resultado da operação retornou um negativo, tente novamente...");

            }
            else
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("O valor da divisão é: " + valorTotal);
                Console.WriteLine("--------------------------------------");
            }
        }



        static void Main(string[] args)
        {

            Console.WriteLine("Digite o primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());
            

            Console.WriteLine("Digite o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            int opcaoUsuario;
            do
            {
                Console.WriteLine(
                    "\nSelecione a opção que deseja realizar utilizando os números do menu:\n" +
                    "1 - Soma\n" +
                    "2 - Subtração\n" +
                    "3 - Multiplicação\n" +
                    "4 - Divisão\n" +
                    "0 - Sair");
                opcaoUsuario = int.Parse(Console.ReadLine());

                switch (opcaoUsuario)
                {
                    case 1:
                        somaValores(numero1, numero2);
                        break;
                    case 2:
                        subtraiValores(numero1, numero2);
                        break;
                    case 3:
                        multiplicaValores(numero1, numero2);
                        break;
                    case 4:
                        divideValores(numero1, numero2);
                        break;
                    case 0:
                        Console.WriteLine("Saindo do programa...");
                        break;
                    default:
                        Console.WriteLine("Desculpe, não reconheci sua operação, tente novamente");
                        break;
                };

            } while (opcaoUsuario != 0);


            Console.WriteLine("Press any key to close the window...");
            Console.ReadKey();
        }
    }
}
