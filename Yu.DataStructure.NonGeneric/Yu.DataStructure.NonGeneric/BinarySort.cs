using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yu.DataStructure.NonGeneric
{
    public class BinarySort
    {
        /// <summary>
        /// Merge Sort Recursively
        /// Break array into smallest chunks
        /// And merge back
        /// </summary>
        /// <param name="data"></param>
        /// <param name="temp"></param>
        /// <param name="first"></param>
        /// <param name="last"></param>
        public static void MergeSort(int[] data, int[] temp, int first, int last)
        {
            int mid = (first + last) / 2;
            if (first < last)
            {
                MergeSort(data, temp, first, mid);
                MergeSort(data, temp, mid + 1, last);
                Merge(data, temp, first, last);
            }
        }

        /// <summary>
        /// Merge 2 arrays
        /// by order of from smaller to larger
        /// A private method serves MergeSortRec()
        /// </summary>
        /// <param name="data"></param>
        /// <param name="temp"></param>
        /// <param name="first"></param>
        /// <param name="last"></param>
        private static void Merge(int[] data, int[] temp, int first, int last)
        {
            int maxLow = (first + last) / 2;
            int low = first;
            int high = maxLow + 1;
            int i = first;

            while (low <= maxLow && high <= last)
            {
                if (data[low] < data[high])
                    temp[i++] = data[low++];
                else
                    temp[i++] = data[high++];
            }

            while (low <= maxLow)
                temp[i++] = data[low++];

            while (high <= last)
                temp[i++] = data[high++];

            for (int j = first; j <= last; j++)
                data[j] = temp[j];
        }

        /// <summary>
        /// Quicksort
        /// Time Complexity O(NlogN)
        /// Pick a value, place smaller value to left and bigger to right, place this value between them
        /// do left part the same way and right part the same way
        /// again and again recursively untill chunk smaller than 2
        /// </summary>
        /// <param name="data"></param>
        /// <param name="first"></param>
        /// <param name="last"></param>
        public static void QuickSort(int[] data, int first, int last)
        {
            int pivot = data[first];
            int inc = first + 1;
            int dec = last;

            while (inc < dec)
            {
                while (data[inc] < pivot && inc < last)
                    inc++;
                while (data[dec] > pivot)
                    dec--;
                if (inc < dec) Swap(data, inc, dec);
            }


            if (pivot > data[dec]) Swap(data, first, dec);

            if (dec - 1 > first)
            {
                QuickSort(data, first, dec - 1);
            }

            if (dec + 1 < last)
            {
                QuickSort(data, dec + 1, last);
            }
        }

        /// <summary>
        /// Swap values of 2 items in an array
        /// </summary>
        /// <param name="data"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        public static void Swap(int[] data, int left, int right)
        {
            int buff = data[left];
            data[left] = data[right];
            data[right] = buff;
        }

        public static void PrintArray(int[] data)
        {
            foreach (int i in data)
            {
                Console.Write(i + " ");
            }
            Console.Write("\n");
        }

        /// <summary>
        /// RadixSort
        /// Time complexity O(KN)
        /// </summary>
        /// <param name="data"></param>
        public static void RadixSort(int[] data)
        {
            int maxDigits = 3;
            int factor = 1;
            int n = 0;
            Queue<int>[] Q = new Queue<int>[10];
            for (int i = 0; i < 10; i++ )
            {
                Q[i] = new Queue<int>();
            }
            for (int digit = 1; digit <= maxDigits; digit++)
            {
                foreach (int entry in data)
                {
                    Q[entry / factor % 10].Enqueue(entry);
                    Console.WriteLine("Q[" + entry / factor % 10 + "] joined " + entry);
                }

                n = 0;
                foreach (Queue<int> entry in Q)
                {
                    while (entry.Count() != 0)
                    {
                        Console.WriteLine("n="+n);
                        data[n++] = entry.Dequeue();
                    }
                }
                factor *= 10;
            }
        }

        /// <summary>
        /// use heap to sort
        /// Similar to merge and quick sort
        /// Time complexity O(NlogN)
        /// </summary>
        /// <param name="data"></param>
        public static void HeapSort(int[] data)
        {
            var heap = new Heap();
            foreach (int i in data)
            {
                heap.Insert(i);
            }

            for (int j = 0; heap.Count() > 0; j++)
            {
                data[j] = heap.DeleteRoot();
            }
        }
    }
}
