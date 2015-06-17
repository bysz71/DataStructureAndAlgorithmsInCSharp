Common Data Structure And Algorithms Implementation Using C#
============================================================
Description:
------------
<p>This project is about using c# to implement common data structures and algorithms. C# is a very engineering type language, it is very efficiency at developing and cooperating.
Most common data structures and algorithms are already perfectly built in, usually people do not use c# to study structure and algorithms.</p>
<p>Using c# to implement data structure and algorithms is my very personal choice. Currently my goals include get through common data structures and algorithms, 
and be more familiar with c# language. Although c# is not a common choice, it is perfectly capable. And implementing data structure and algorithms could also help me to understand the memory model and value/reference type of C#. </p>

So Far List
-----------
<ul>
<li><b>Data Structures & Algorithms</b><br/>
	<ul>
	<li>LinkedList</li>
	<li>Stack</li>
	<li>Queue</li>
	<li>BinaryTree 
		<ul>
		<li>InOrder, PreOrder, PostOrder traversals DepthFirstSearch(recursive and stack)</li>
		<li>BreadthFirstSearch (queue)</li>
		</ul>
	</li>
	<li>BinarySearchTree 
		<ul>
		<li>Search, Insert, Delete ...</li>
		</ul>
	</li>
	<li>Heap (priority queue)
		<ul>
		<li>Search, Insert, Delete ...</li>
		</ul>
	</li>
	<li>Graph
		<ul>
		<li>Dijkstra's Algorithm</li>
		</ul>
	</li>
	<li>Sort
		<ul>
		<li>Selection Sort</li>
		<li>Insertion Sort</li>
		<li>Bubble Sort</li>
		</ul>
	</li>
	</ul>
</li>
<li><b>Some practices</b><br/>
	<ul>
	<li>BigNumberAddition (LinkedList)</li>
	<li>MatrixOperation (LinkedList)</li>
	<li>RPNEvaluation (Stack)</li>
	<li>RPNTree (BinaryTree)</li>
	</ul>
</li>
</ul>

Sort
----
<ul>
<li><b>Selection Sort</b>
	<ul>
	<li><p><b>Summary</b><br/>
		swap current item with currently smallest item, and move 1 item forward.</p></li>
	<li><p><b>Time complexity O(N^2)</b><br/>
		for{for{}}.</p></li>
	</ul>
<li><b>Insertion Sort</b>
	<ul>
	<li><p><b>Summary</b><br/>
		iterate to out-of-order item, insert it to its right position by shift other items from that position, and go on.</p></li>
	<li><p><b>Time complexity O(N^2)</b><br/>
		for{for{}}.</p></li>
	</ul>
<li><b>Bubble Sort</b>
	<ul>
	<li><p><b>Summary</b><br/>
		treat 2 items as a bubble, swap if needed, and move on unitil reach the end. Do this again and again until no swapping happens.</p></li>
	<li><p><b>Time complexity O(N^2)</b></br>
		while{for{}}.</p></li>
	</ul>
</ul>

AdvancedSort
------------
<ul>
<li><b>Merge Sort</b>
	<ul>
	<li><b>Summary</b><br/>
		Based on Merge(). Merge method merges 2 sorted array into one sorted array. Merge Sort breaks array into smallest chunks and recursively implement Merge.</li>
	<li><b>Logic</b><br/>
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
	<li><b>Remark</b><br/>Merge() function is based on the assumption that the 2 sub-arrays are sorted, so we recursively break the array into smallest chunks (so that sub-arrays must be sorted), and Merge() them back to original array</li>
	<li><b>Time complexity O(NlogN)</b></br>Because Merge is O(N) and its breaking(like a binary tree) is O(logN).</li>
	</ul>
<li><b>Quicksort</b><br/>
	<ul>
	<li>
		<b>Summary</b><br/>
		Pick a pivot value, put smaller items to its left, put larger items to its right. Do the same way to the left part and to the right part recursively until the chunk size is 2.
	</li>
	<li>
		<b>Logic</b><br/>
		Pick the first item as the pivot<br/>
		Put all items smaller than pivot to the left and put all items larger to the right by swapping<br/>
		Swap pivot with the smallest right item to place pivot in between<br/>
		Do this again to the left part and right part recursively until chunk size is 2<br/>
	</li>
	</ul>
</li>
</ul>