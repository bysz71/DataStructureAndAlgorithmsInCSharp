using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yu.DataStructure.NonGeneric
{
    public class Sort
    {
        /// <summary>
        /// SelectionSorting
        /// Time complexity O(N^2)
        /// Usually for{for{}} causes O(N^2) time complexity
        /// Swap current item with currently smallest item
        /// </summary>
        /// <param name="data"></param>
        public static void SelectionSort(int[] data)
        {
            int min = 0;
            int buffer = 0;
            for (int front = 0; front < data.Length; front++)
            {
                min = front;
                for (int i = front; i < data.Length; i++)
                {
                    if (data[i] < data[min]) min = i;
                }
                buffer = data[min];
                data[min] = data[front];
                data[front] = buffer;
            }
        }

        /// <summary>
        /// Insertion Sorting
        /// Time complexity O(N^2)
        /// Shift array until reach the right order
        /// </summary>
        /// <param name="data"></param>
        public static void InsertionSort(int[] data)
        {
            int buff;
            int shift;
            for (int i = 1; i < data.Length; i++)
            {
                buff = data[i];
                for (shift = i; shift>0 && data[shift-1]>buff; shift--)
                {
                    data[shift] = data[shift - 1];
                }
                data[shift] = buff;
            }
        }

        /// <summary>
        /// Bubble Sort
        /// Time complexity O(N^2)
        /// Treat 2 neighbours as a window(bubble)
        /// swap if wrong order, and move on
        /// if nothing needs to swap in a whole turn, break
        /// </summary>
        /// <param name="data"></param>
        public static void BubbleSort(int[] data)
        {
            int buff;
            bool swap = false;
            while (true)
            {
                swap = false;
                for (int i = 0; i < data.Length - 1; i++)
                {
                    if (data[i] > data[i + 1])
                    {
                        buff = data[i];
                        data[i] = data[i + 1];
                        data[i + 1] = buff;
                        swap = true;
                    }
                }
                if(swap == false) break;
            }
        }
    }
}
