#Heap Sort
* **Summary**  
Use the "root always largest" feature of heap to sort.<br/>
* **Logic**  
  + Insert all items to the heap
  + Delete(return) the root value back to the array.
* **Time complexity**  
	O(NlogN). Every Delete() of heap costs logN, thus N items cost NlogN.
