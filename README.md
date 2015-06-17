Common Data Structure And Algorithms Implementation Using C#
============================================================
Description:
------------
<p>This project is about using c# to implement common data structures and algorithms. C# is a very engineering type language, it is very efficiency at developing and cooperating.
Most common data structures and algorithms are already perfectly built in, usually people do not use c# to study structure and algorithms.</p>
<p>Using c# to implement data structure and algorithms is my very personal choice. Currently my goals include get through common data structures and algorithms, 
and be more familiar with c# language. Although c# is not a common choice, it is perfectly capable. And implementing data structure and algorithms could also help me to understand the memory model and value/reference type of C#. </p>

So Far List:
------------
<b>Data Structures & Algorithms</b><br/>
- LinkedList
- Stack
- Queue
- BinaryTree 
	+ InOrder, PreOrder, PostOrder traversals DepthFirstSearch(recursive and stack)
	+ BreadthFirstSearch (queue)<br/>
- BinarySearchTree 
	+ Search, Insert, Delete ...
- Heap (priority queue)
	+ Search, Insert, Delete ...
- Graph
	+ Dijkstra's Algorithm
- Sort
	+Selection Sort
	+Insertion Sort
	+Bubble Sort

<b>Some practices</b><br/>
- BigNumberAddition (LinkedList)
- MatrixOperation (LinkedList)
- RPNEvaluation (Stack)
- RPNTree (BinaryTree)

Sort:
-----
- Selection Sort
<p>swap current item with currently smallest item, and move 1 item forward.</p>
<p>tsime complexity O(N^2), for{for{}}.</p>
- Insertion Sort
<p>iterate to out-of-order item, insert it to its right position by shift other items from that position, and go on.</p>
<p>time complexity O(N^2), for{for{}}.</p>
- Bubble Sort
<p>treat 2 items as a bubble, swap if needed, and move on unitil reach the end. Do this again and again until no swapping happens.</p>
<p>time complexity O(N^2), while{for{}}.</p>

AdvancedSort:
------------
<ul>
<li><b>Merge Sort</b>
	<ul>
	<li><p>Based on Merge method. Merge method merges 2 sorted array into one sorted array. Merge Sort breaks array into smallest chunks and recursively implement Merge.</p></li>
	<li><p><b>Logic</b><br/>
		<ul>
		<li>
		Merge()<br/>
		Break array into 2 sub arrays evenly<br/>
		1st loop: put smaller value of either left or right sub array into the temporary array, until one array runs out<br/>
		(after the 1st loop ends, there must be at least 1 sub array runs out)<br/>
		2nd loop: in case left sub array does not run out (which right sub array does), add its items to temporary array<br/>
		3rd loop: in case right sub array has items and left runs out, add its items to temporary array<br/>
		</li>
		<li>
		MergeSort()<br/>
		Break array from "first" to "last" into 2 sub array<br/>
		MergeSort left sub-array<br/>
		MergeSort right sub-array<br/>
		Merge() the array back together again<br/>
		</li>
		</ul>
	</li>
	<li><p><b>Remark</b><br/>Merge() function is based on the assumption that the 2 sub-arrays are sorted, so we recursively break the array into smallest chunks (so that sub-arrays must be sorted), and Merge() them back to original array</p></li>
	<li><p><b>Time complexity O(NlogN)</b></br>Because Merge is O(N) and its breaking(like a binary tree) is O(logN).<p></li>
	</ul>

<li>Quicksort</li>
</ul>