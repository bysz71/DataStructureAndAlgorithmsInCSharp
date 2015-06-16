using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yu.DataStructure.NonGeneric
{
    public class AdvancedSort
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
        public static void MergeSortRec(int[] data, int[] temp, int first, int last)
        {
            int mid = (first + last) / 2;
            if (first < last)
            {
                MergeSortRec(data, temp, first, mid);
                MergeSortRec(data, temp, mid + 1, last);
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
            int maxLow = (first + last)/2;
            int low = first;
            int high = maxLow + 1;
            int i = first;

            while(low <= maxLow && high <= last){
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


    }
}
