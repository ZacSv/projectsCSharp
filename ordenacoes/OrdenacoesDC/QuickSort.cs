using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenacoesDC
{
    internal class QuickSort
    {
        public static void quickSort(int[] lista, int start, int end)
        {
            int[] listaTeste = new int[5] { 1, 2, 6, 80, 12 };
            int pivot = listaTeste[start];//Definindo que o pivô será o último elemento

            int esquerda = start;//Definindo os elementos menores em relação ao pivô

            int direita = end;//Definindo os elementos maiores em relação ao pivô
            while(esquerda <= direita)
            {
                while (listaTeste[esquerda] < pivot)
                {
                    esquerda ++;
                }
                while (listaTeste[direita] >= pivot)
                {
                    direita --;
                }
                if(esquerda <= direita)
                {
                    (listaTeste[esquerda], listaTeste[direita]) = (listaTeste[direita], listaTeste[esquerda]);
                    esquerda++;
                    direita--;
                }

            }

        }

    };

};
   