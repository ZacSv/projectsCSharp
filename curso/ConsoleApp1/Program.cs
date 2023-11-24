using System;
using System.Collections.Generic;

class Program
{
    // Função que encontra os índices dos dois números cuja soma é igual ao alvo
    static int[] DoisSum(int[] nums, int target)
    {
        // Cria um dicionário para armazenar os números já vistos
        Dictionary<int, int> mapa = new Dictionary<int, int>();

        // Loop através dos números na matriz
        for (int i = 0; i < nums.Length; i++)
        {
            // Calcula o complemento necessário para atingir o alvo
            int complemento = target - nums[i];

            // Verifica se o complemento está no dicionário
            if (mapa.ContainsKey(complemento))
            {
                // Retorna os índices dos dois números
                return new int[] { mapa[complemento], i };
            }

            // Adiciona o número atual ao dicionário, juntamente com seu índice
            mapa[nums[i]] = i;
        }

        // Caso não encontre uma solução, retorna um array vazio
        return new int[0];
    }

    // Função principal
    static void Main()
    {
        // Exemplo de entrada: uma matriz e um alvo
        int[] nums = { 2, 7, 11, 15 };
        int target = 26;

        // Chama a função DoisSum para obter os índices
        int[] indices = DoisSum(nums, target);

        // Exibe os resultados
        if (indices.Length == 2)
        {
            Console.WriteLine($"Os índices dos dois números são: {indices[0]} e {indices[1]}");
        }
        else
        {
            Console.WriteLine("Não foi encontrada uma solução.");
        }
    }
}