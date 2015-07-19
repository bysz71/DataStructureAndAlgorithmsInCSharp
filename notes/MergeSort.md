#Merge Sort
* **Summary**  
Based on Merge(). Merge method merges 2 sorted array into one sorted array. Merge Sort breaks array into smallest chunks and recursively implement Merge.</li>
* **Logic**  
  + Merge()  
  Break array into 2 sub arrays evenly
		- 1st loop: put smaller value of either left or right sub array into the temporary array, until one array runs out  
		(after the 1st loop ends, there must be at least 1 sub array runs out)
		- 2nd loop: in case left sub array does not run out (which right sub array does), add its items to temporary array
		- 3rd loop: in case right sub array has items and left runs out, add its items to temporary array
  + MergeSort()  
		- Break array from "first" to "last" into 2 sub array
		- MergeSort left sub-array
		- MergeSort right sub-array
		- Merge() the array back together again
* **Remark**  
Merge() function is based on the assumption that the 2 sub-arrays are sorted, so we recursively break the array into smallest chunks (so that sub-arrays must be sorted), and Merge() them back to original array</li>
* **Time complexity O(NlogN)**  
Because Merge is O(N) and its breaking(like a binary tree) is O(logN).
