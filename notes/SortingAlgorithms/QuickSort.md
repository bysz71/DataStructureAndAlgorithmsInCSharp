#Quick Sort
##Source code
[https://github.com/scottszb1987/DataStructureAndAlgorithmsInCSharp/blob/master/SortingAlgorithms/SortingAlgorithms/BinarySort.cs](https://github.com/scottszb1987/DataStructureAndAlgorithmsInCSharp/blob/master/SortingAlgorithms/SortingAlgorithms/BinarySort.cs)
##Summary
Quick sort algorithm using Lomuto partition scheme.
##Detail
+ Assuming that we have an unsorted integer array ```nums``` with items ```{ 3, 9, 2, 5, 6, 4, 11, 7, 12 }``` . We want to sort it in an ascending order.
+ Here is the general code for quick sort:
```c#
public static void QuickSort(int[] nums, int low, int high)
{
    if (low < high)
    {
        int pivot = Partition(nums, low, high);
        QuickSort(nums, low, pivot - 1);
        QuickSort(nums, pivot + 1, high);
    }
}
```  
  - ```public static void QuickSort(int[] nums, int low, int high){}```  
  This method contains 3 argument. ```int[] nums``` is the input integer array to be sorted, ```int low``` represents the start index of current sub-array, ```int high``` represents the end index of current sub-array.
  - ```if (low < high){}```  
  At the some stages of the recursion, low may equal to high, that's where the recursion branch ends. Only if there are at least 2 items in the sub-array, the recursion may go deeper.
  - ```int pivot = Partition(nums, low, high);```  
  This ```Partition``` method is the core of quick sort.
... to be continued...
  
