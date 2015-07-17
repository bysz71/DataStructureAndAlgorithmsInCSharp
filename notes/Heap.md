#Heap
[[Full code]](https://github.com/scottszb1987/DataStructureAndAlgorithms/blob/master/Yu.DataStructure.NonGeneric/Yu.DataStructure.NonGeneric/Heap.cs)

#Summary
Priority Queue is a data structure that when you pop you get either the maximum or minimum depending.  
  
Heap is an implementation of priority queue which provides good time complexity "O(logn)" while pushing and poping. 
* Heap is a self balanced binary tree, which means the differences of heights between any two leaves would be less or equal to 1.
* Heap has a feature that at any level, a node is always larger(or smaller depending) than its children.
* In a heap, no matter what order you use to push items into heap, the heap will re-construct to make sure it meets the 2 
requirements above.
	
#Logic and code snippet
* **Implementing using generic.List**  
A heap is just a logical tree, we do not have to implement it using a real tree. In this circumstance, a List (vector) is 
more suitable that its random access feature makes operations much faster.  
```c#  
public class Heap
    {
        private List<int> _list;

        public Heap()
        {
            _list = new List<int>();
        }
```  
* **Example Heap tree**  
![heap_tree](https://github.com/scottszb1987/DataStructureAndAlgorithms/blob/master/Images/HeapTree.PNG?raw=true)  
* **Example Heap using List**  
![heap_list](https://github.com/scottszb1987/DataStructureAndAlgorithms/blob/master/Images/HeapList.PNG?raw=true)  
  
* **Indexing**  
	From the heap list image above we can see that
	+ leftChildIndex = parentIndex * 2 + 1
	+ rightChildIndex = parentIndex * 2 + 2  
	Or we can say:  
	+ parentIndex = (childIndex - 1) / 2  
	(Works for both children, because in Integer Division, 4/2 and 5/2 gave the same result)

* **Insert() method**  
	Push, Insert an item to heap. Key point is to make sure the heap meets heap's requirements.
	1. Add an item to the end of the list.
  2. If its value is larger than its parent's value, swap them.
	3. Repeat step 2 above, until this value's parent value no longer smaller than itself.
```c#
        public void Insert(int item)
        {
            //duplicate entry verification
            if (_list.Contains(item))
            {
                Console.WriteLine("Error: Duplicate item");
                return;
            }
            
            _list.Add(item);
            
            //no further operation needed if only 1 item in the heap after insertion
            if (_list.Count() == 1) return;
            
            //--common cases, heap wasn't empty before insertion, needs reconstruction--
            int motherIndex = 0;
            int childIndex = _list.Count() - 1;
            int buff = 0;

            while (true)
            {
                motherIndex = (childIndex - 1) / 2;
                if (_list[childIndex] > _list[motherIndex])
                {
                    buff = _list[childIndex];
                    _list[childIndex] = _list[motherIndex];
                    _list[motherIndex] = buff;
                    childIndex = motherIndex;
                }
                else break;
            }
            //--reconstruction done--
        }
```  	    
* **DeleteRoot() method**  
  Pop, returns the root value, and delete the root node. It also needs to make sure the heap still meets heap's requirements.
	1. Swap root value with the last node's value, remove the last node.
	2. Swap the new root value with its larger child.
	3. Repeat step 2 above, until it reaches leaf or got no children that larger than itself.
```c#  
        public int DeleteRoot()
        {
            int result;
            
            //if heap is empty, return null
            if (_list.Count() == 0)
            {
                Console.WriteLine("Error: Empty heap");
                return null;
            }
            
            //if heap has 1 item, just return it
            if (_list.Count() == 1)
            {
                result = _list[0];
                _list.RemoveAt(0);
                return result;
            }

            //--common cases that items are more than 1, need reconstruction--
            //swap root with tail
            result = _list[0];
            _list[0] = _list[_list.Count() - 1];
            _list.RemoveAt(_list.Count() - 1);

            int motherIndex = 0;
            int childIndex = 1;
            int buff = 0;
            while (true)
            {
                //if not reaching leaf, both children indices are within range
                if (childIndex < _list.Count() - 1)
                {
                    //if mother smaller than any of the children, swap. Otherwise, break loop.
                    if (_list[motherIndex] < Math.Max(_list[childIndex], _list[childIndex + 1]))
                    {

                        buff = _list[motherIndex];
                        childIndex = MaxIndex(childIndex);
                        _list[motherIndex] = _list[childIndex];
                        _list[childIndex] = buff;

                        motherIndex = childIndex;
                        childIndex = motherIndex * 2 + 1;
                    }
                    else break;
                }
                //if only left child index is within range, just swap it with mother if needed
                else if (childIndex == _list.Count() - 1)
                {
                    if (_list[motherIndex] < _list[childIndex])
                    {
                        buff = _list[motherIndex];
                        _list[motherIndex] = _list[childIndex];
                        _list[childIndex] = buff;
                    }
                    break;
                }
                //if itself reaches leaf, just break the loop
                else break;
            }
            //--reconstuction done--
            return result;
        }
  ```  
#Time complexity
Push and Pop are both O(log(n))  
See [balanced binary tree's search time complexity](https://github.com/scottszb1987/DataStructureAndAlgorithms/blob/master/notes/BalancedBinaryTreeSearchComplexity.md)
