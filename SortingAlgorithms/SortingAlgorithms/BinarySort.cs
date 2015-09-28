using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class BinarySort
    {
        /// <summary>
        /// Quick sort using Lomuto partition schemme
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        public static void QuickSort(int[] nums, int low, int high)
        {
            if (low < high)
            {
                int pivot = Partition(nums, low, high);
                QuickSort(nums, low, pivot - 1);
                QuickSort(nums, pivot + 1, high);
            }
        }

        //Lomuto partition scheme
        private static int Partition(int[] nums, int low, int high)
        {
            int pivot = nums[high];
            int i = low;
            for (int j = low; j < high; j++)
                if (nums[j] <= pivot)
                    Swap(ref nums[i++], ref nums[j]);
            Swap(ref nums[i], ref nums[high]);
            return i;
        }

        //swap the value of 2 ints
        private static void Swap(ref int left, ref int right)
        {
            int buff = left;
            left = right;
            right = buff;
        }
    }
}
