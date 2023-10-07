using System;
using System.Collections.Generic;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Tarefas = new List<string>();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("\n Bem vindo ao To Do List !\n");
            Console.WriteLine("---------------------------------");
            int opcaoUsuario = 1;
            while (opcaoUsuario != 0)
            {
                Console.WriteLine("\n" +
                    "Qual operação deseja realizar: \n" +
                    "\n1 - Ver a lista de tarefas\n" +
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
                        while (true)
                        {   
                            Console.WriteLine("\nQual tarefa deseja adicionar ?\n");
                             string tarefaUsuarioAdicionar = Console.ReadLine();
                            int numero = Tarefas.Count + 1;
                            string item = numero + " - " + tarefaUsuarioAdicionar;
                            Tarefas.Add(item);
                            Console.WriteLine("\nSe deseja adicionar mais uma tarefa aperte s, caso contrário qualquer tecla");
                            string opcaoSaida = Console.ReadLine().ToLower();
                            if(opcaoSaida != "s")
                            {
                                break;
                            }
                        }
                   
                        
                        break;
                    case 3:
                        Console.WriteLine("\nDigite o nome da tarefa que deseja modificar: \n");
                        string tarefaParaModificar = Console.ReadLine();
                        int indice = Tarefas.IndexOf(tarefaParaModificar);
                           
                        if (indice != -1)
                        {
                            Console.WriteLine("\nDigite o novo nome desta tarefa: \n");
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
                        Console.WriteLine("\n------------------------");
                        foreach (string tarefa in Tarefas)
                        {
                            Console.WriteLine(tarefa);
                        }
                        Console.WriteLine("------------------------");
                        Console.WriteLine("A lista está acima, digite o número tarefa que deseja remover: \n");
                        string tarefaUsuario = Console.ReadLine();
                        if (int.TryParse(tarefaUsuario, out int indiceParaExcluir) && indiceParaExcluir >= 0 && indiceParaExcluir < Tarefas.Count)
                        {
                            Tarefas.RemoveAt(indiceParaExcluir - 1);
                            Console.WriteLine("\nElemento excluido, lista atualizada !\n");
                        }
                        else
                        {
                            Console.WriteLine("Indice não encontrado, digite um índice válido !");
                        }
                        break;
                     default:
                        Console.WriteLine("\nNão reconheço esta opção, tente novamente: ");
                        break;

                }
            }

        }
    }
}
