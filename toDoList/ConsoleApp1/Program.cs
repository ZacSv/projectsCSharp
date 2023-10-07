using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nDigite a primeira tarefa para iniciarmos a lista: ");
            string tarefaUsuario = Console.ReadLine();
            List<string> Tarefas = new List<string>(); 
            Tarefas.Add(tarefaUsuario);

            int opcaoUsuario = 1;
            while (opcaoUsuario != 0)
            {
                Console.WriteLine("" +
                    "Qual operação deseja realizar: \n" +
                    "1 - Ver a pilha de tarefas\n" +
                    "2 - Adicionar um novo item a lista\n" +
                    "3 - Modificar uma tarefa da fila\n" +
                    "4 - Remover item da lista\n" +
                    "0 - Finalizar programa ");
                opcaoUsuario = int.Parse(Console.ReadLine());

                switch (opcaoUsuario)
                {
                    case 1:
                        Console.WriteLine("------------------------");
                        foreach(string tarefa in Tarefas)
                        {
                            Console.WriteLine(tarefa);
                        }
                        Console.WriteLine("------------------------");
                        break;
                    case 2:
                        Console.WriteLine("\nQual tarefa deseja adicionar ?\n");
                        tarefaUsuario = Console.ReadLine();
                        Tarefas.Add (tarefaUsuario);
                        break;
                    case 3:
                        Console.WriteLine("\nDigite o nome da tarefa que deseja modificar: \n");
                        string tarefaParaModificar = Console.ReadLine();
                        int indice = Tarefas.IndexOf(tarefaParaModificar);

                        if (indice != -1)
                        {
                            Console.WriteLine("Digite o novo nome desta tarefa: ");
                            string tarefaAtualizada = Console.ReadLine();
                            Tarefas[indice] = tarefaAtualizada;
                            Console.WriteLine($"\nOk, tarefa atualizada com sucesso para {tarefaAtualizada}\n");
                        }
                        else
                        {
                            Console.WriteLine($"'{tarefaParaModificar}' não foi encontrado na lista.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("\nDigite a tarefa que deseja remover: \n");
                        tarefaUsuario = Console.ReadLine();
                        Tarefas.Remove(tarefaUsuario);
                        Console.WriteLine($"\nOk, tarefa {tarefaUsuario} removida com sucesso !");
                        break;
                     default:
                        Console.WriteLine("\nNão reconheço esta opção, tente novamente: ");
                        break;

                }
            }

        }
    }
}
