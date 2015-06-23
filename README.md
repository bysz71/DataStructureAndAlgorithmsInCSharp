Common Data Structure And Algorithms Implementation Using C#
============================================================
Description:
------------
<p>This project is about using c# to implement common data structures and algorithms. C# is a very engineering type language, it is very efficiency at developing and cooperating.
Most common data structures and algorithms are already perfectly built in, usually people do not use c# to study structure and algorithms.</p>
<p>Using c# to implement data structure and algorithms is my very personal choice. Currently my goals include to get through common data structures and algorithms, 
and to be more familiar with c# language. Although c# is not a common choice, it is perfectly capable. And implementing data structure and algorithms could also help me to understand the memory model and value/reference type of C#. </p>

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
	<li>Linear Sort
		<ul>
		<li>Selection Sort</li>
		<li>Insertion Sort</li>
		<li>Bubble Sort</li>
		</ul>
	</li>
	<li>Binary Sort
		<ul>
		<li>Merge Sort</li>
		<li>Quicksort</li>
		<li>Radix Sort</li>
		<li>Heap Sort</li>
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
Heap
----
[[code](https://github.com/scottszb1987/DataStructureAndAlgorithms/blob/master/Yu.DataStructure.NonGeneric/Yu.DataStructure.NonGeneric/Heap.cs)]
<ul>
<li>
	<b>Summary</b>
	<p>Heap is a self balanced binary tree. Its largest leaf height difference is at most 1.
	It has the feature that at any level, a node is always larger(or smaller, depend on your decision) than its children.
	No matter what order you use to push items in heap, its root value is always the largest(or smallest) in the tree.
	Thus every time you pop the root, it will be the largest(or smallest) value, and heap will re-balance so that new root will become the new largest value.
	That is why Heap is also called priority queue.</p>
	
	<p>A heap is only a logical tree, we do not have to implement it using a real tree.
	In this circumstance, a List (vector) is more suitable that its random access feature makes operations much faster.
	To implement the re-balance feature, both Insert() method and DeleteRoot() method need to involve re-balance function.</p>	
</li>
<li>
	<b>Logic</b>
	<ul>
	<li>
		<b>Using List</b><br/>
		Heap tree example:<br/>
		![alt text](https://raw.githubusercontent.com/scottszb1987/DataStructureAndAlgorithms/master/HeapTree.PNG "Heap Tree")
	</li>
	</ul>
</li>
</ul>

Graph and Dijkstra's Algorithm
----------------------------
[[Graph code](https://github.com/scottszb1987/DataStructureAndAlgorithms/blob/master/Yu.DataStructure.NonGeneric/Yu.DataStructure.NonGeneric/Graph.cs)]
[[Dijkstra's Algorithm code](https://github.com/scottszb1987/DataStructureAndAlgorithms/blob/master/Yu.DataStructure.NonGeneric/Yu.DataStructure.NonGeneric/DijkstrasAlgorithm.cs)]
<ul>
<li>
<b>Summary</b>
	<ul>
	<li>
	<b>Graph</b><br/>
	<p>Graph is a set of Nodes that each Node could point to or be pointed by any other Nodes. 
	The connection between each Nodes are called Edges, Edge has a cost property. The cost of each edge may vary. 
	Edges also has direction, from A to B and from B to A are different. 
	In those cases that edges do not have directions, it should be treated like A to B and B to A are all existed and their cost are the same.</p>
	<p>In my code the Graph class is based on List of LinkedList. Each LinkedList in the List represents a node in the graph.
	Each Element in the LinkedList possesses 2 properties, a node mark (a letter) and a cost, means the destination and the Edge cost.
	The first element of the LinkedList represent the Node itself, and its cost is 0.</p>
	</li>
	<li>
	<b>Dijkstra's Algorithm</b><br/>
	<p>Dijkstra's algorithm calculate the shortest routes of one start Node to all other Nodes.</p>
	</li>
	</ul>
</li>
<li>
<b>Dijkstra's logic</b>
	<ol>
	<li>
	Declare a dictionary d to store the current shortest distance of each destination node.<br/>
	Declare a dictionary s to store the status of each node that if its shortest distance is final decision.<br/>
	</li>
	<li>
	Set start node's distance to 0 , status to true (is final) ; Set all other node's distance to infinity (practically a very big number) , status to false (not final).
	</li>
	<li>
	Initially "current" starts from the start node (as in the input parameter). 
	Take the current node as a temporary start node, update all the node's current distances (in d) by picking the smaller value from its old value and the (current start node's distance(in d) plus destiny node's edge cost).
	</li>
	<li>
	In all the node's that status are not final yet (in s), find the one with smallest distance (in d). Set it as next turn current node, and set its status to final (true).
	</li>
	<li>
	Repeat 2 steps above, until all nodes' status (in s) are final (true).
	</li>
	</ol>
</li>
<li>
<b>Example</b><br/>
(Under construction).

</li>
</ul>



Linear Sort 
-----------
[[code](https://github.com/scottszb1987/DataStructureAndAlgorithms/blob/master/Yu.DataStructure.NonGeneric/Yu.DataStructure.NonGeneric/Sort.cs)]
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

Binary Sort
-----------
[[code](https://github.com/scottszb1987/DataStructureAndAlgorithms/blob/master/Yu.DataStructure.NonGeneric/Yu.DataStructure.NonGeneric/AdvancedSort.cs)]
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
	<li>
		<b>Example</b><br/>
		<b>P for pivot, I for inc(index increment), D for dec(index decrement)</b><br/>
		<table>
		<tr><td>7</td><td>3</td><td>8</td><td>2</td><td>5</td><td>6</td><td>0</td><td>1</td><td>9</td><td>4</td></tr>
		<tr><td>P</td><td>I</td><td> </td><td> </td><td> </td><td> </td><td> </td><td> </td><td> </td><td>D</td></tr>
		</table>
		Initial case, pivot -> 7, inc -> 3, dec -> 4<br/>
		<b>7</b> 3 <u>8</u> 2 5 6 0 1 9 <u>4</u><br/>
		<table>
		<tr><td>7</td><td>3</td><td>8</td><td>2</td><td>5</td><td>6</td><td>0</td><td>1</td><td>9</td><td>4</td></tr>
		<tr><td>P</td><td> </td><td>I</td><td> </td><td> </td><td> </td><td> </td><td> </td><td> </td><td>D</td></tr>
		</table>
		Inc -> 8 (8 > pivot); dec -> 4 (4 < pivot)<br/>
		<table>
		<tr><td>7</td><td>3</td><td>4</td><td>2</td><td>5</td><td>6</td><td>0</td><td>1</td><td>9</td><td>8</td></tr>
		<tr><td>P</td><td> </td><td> </td><td> </td><td> </td><td> </td><td> </td><td>D</td><td>I</td><td> </td></tr>
		</table>
		Swap 8 and 4 ; inc -> 9, dex -> 1 ; inc > dec (not the value they point, but their index), loop ends.<br/>
		<table>
		<tr><td>1</td><td>3</td><td>4</td><td>2</td><td>5</td><td>6</td><td>0</td><td>7</td><td>9</td><td>8</td></tr>
		<tr><td> </td><td> </td><td> </td><td> </td><td> </td><td> </td><td> </td><td>P</td><td> </td><td> </td></tr>
		</table>
		Now loop at pivot, coz pivot 7 > dec 1, swap 7 and 1 (Now we can see that left of 7 are all smaller than 7, right of 7 are all larger)<br/>
		<table>
		<tr><td>1</td><td>3</td><td>4</td><td>2</td><td>5</td><td>6</td><td>0</td><td> </td><td>7</td><td> </td><td>9</td><td>8</td></tr>
		<tr><td>P</td><td>I</td><td> </td><td> </td><td> </td><td> </td><td>D</td><td> </td><td> </td><td> </td><td> </td><td> </td></tr>
		</table>
		Now treat left of 7 as a sub-array, and right of 7 as another sub-array, look at left sub-array first, implement same method<br/>
		Pivot -> 1 , inc -> 3, dec -> 0<br/>
		<table>
		<tr><td>1</td><td>3</td><td>4</td><td>2</td><td>5</td><td>6</td><td>0</td><td> </td><td>7</td><td> </td><td>9</td><td>8</td></tr>
		<tr><td>P</td><td>I</td><td> </td><td> </td><td> </td><td> </td><td>D</td><td> </td><td> </td><td> </td><td> </td><td> </td></tr>
		</table>
		Inc still at 3 (3 > pivot), dec still at 0 (0 < pivot)<br/>
		<table>
		<tr><td>1</td><td>0</td><td>4</td><td>2</td><td>5</td><td>6</td><td>3</td><td> </td><td>7</td><td> </td><td>9</td><td>8</td></tr>
		<tr><td>P</td><td>D</td><td>I</td><td> </td><td> </td><td> </td><td>D</td><td> </td><td> </td><td> </td><td> </td><td> </td></tr>
		</table>
		Swap 3 and 0 ; inc -> 4, dec -> 0 ; inc > dec , loop ends.<br/>
		<table>
		<tr><td>0</td><td>1</td><td>4</td><td>2</td><td>5</td><td>6</td><td>3</td><td> </td><td>7</td><td> </td><td>9</td><td>8</td></tr>
		<tr><td> </td><td>P</td><td> </td><td> </td><td> </td><td> </td><td> </td><td> </td><td> </td><td> </td><td> </td><td> </td></tr>
		</table>
		Pivot 1 > dec 0, swap 1 and 0<br/>
		<table>
		<tr><td>0</td><td> </td><td>1</td><td> </td><td>4</td><td>2</td><td>5</td><td>6</td><td>3</td><td> </td><td>7</td><td> </td><td>9</td><td>8</td></tr>
		<tr><td> </td><td> </td><td> </td><td> </td><td>P</td><td>I</td><td> </td><td> </td><td>D</td><td> </td><td> </td><td> </td><td> </td><td> </td></tr>
		</table>
		Left of pivot 1 is only 0, no sorting needed ; look at right sub-array 4 to 3<br/>
		Pivot -> 4, inc -> 2, dec -> 3<br/>
		<table>
		<tr><td>0</td><td> </td><td>1</td><td> </td><td>4</td><td>2</td><td>5</td><td>6</td><td>3</td><td> </td><td>7</td><td> </td><td>9</td><td>8</td></tr>
		<tr><td> </td><td> </td><td> </td><td> </td><td>P</td><td> </td><td>I</td><td> </td><td>D</td><td> </td><td> </td><td> </td><td> </td><td> </td></tr>
		</table>
		Inc -> 5 , dec -> 3<br/>
		<table>
		<tr><td>0</td><td> </td><td>1</td><td> </td><td>4</td><td>2</td><td>3</td><td>6</td><td>5</td><td> </td><td>7</td><td> </td><td>9</td><td>8</td></tr>
		<tr><td> </td><td> </td><td> </td><td> </td><td>P</td><td> </td><td>D</td><td>I</td><td> </td><td> </td><td> </td><td> </td><td> </td><td> </td></tr>
		</table>
		Swap 5 and 3 ; inc -> 6 , dec -> 3 ; inc > dec , loop ends.<br/>
		<table>
		<tr><td>0</td><td> </td><td>1</td><td> </td><td>3</td><td>2</td><td>4</td><td>6</td><td>5</td><td> </td><td>7</td><td> </td><td>9</td><td>8</td></tr>
		<tr><td> </td><td> </td><td> </td><td> </td><td> </td><td> </td><td>P</td><td> </td><td> </td><td> </td><td> </td><td> </td><td> </td><td> </td></tr>
		</table>		
		Pivot 4 > dec 3 , swap 4 and 3<br/>
		<table>
		<tr><td>0</td><td> </td><td>1</td><td> </td><td>3</td><td>2</td><td> </td><td>4</td><td> </td><td>6</td><td>5</td><td> </td><td>7</td><td> </td><td>9</td><td>8</td></tr>
		<tr><td> </td><td> </td><td> </td><td> </td><td>P</td><td>ID</td><td> </td><td> </td><td> </td><td> </td><td> </td><td> </td><td> </td><td> </td><td> </td><td> </td></tr>
		</table>
		3 and 2 is left sub-array, 6 and 5 is right sub-array. Look at left sub-array first.<br/>
		Only 2 items, inc and dec are same and not movable. Pivot -> 3 , Inc = Dec ->2.<br/>
		<table>
		<tr><td>0</td><td> </td><td>1</td><td> </td><td>2</td><td> </td><td>3</td><td> </td><td>4</td><td> </td><td>5</td><td> </td><td>6</td><td> </td><td>7</td><td> </td><td>9</td><td>8</td></tr>
		<tr><td> </td><td> </td><td> </td><td> </td><td> </td><td> </td><td> </td><td> </td><td> </td><td> </td><td> </td><td> </td><td> </td><td> </td><td> </td><td> </td><td>P</td><td>ID</td></tr>
		</table>
		Pivot 3 > dec 2, Swap 3 and 2.<br/>
		Look at right sub-array 6 and 5, same situation, swap 6 and 5<br/>
		Back to earliest right sub-array [9  8]<br/>
		<table>
		<tr><td>0</td><td> </td><td>1</td><td> </td><td>2</td><td> </td><td>3</td><td> </td><td>4</td><td> </td><td>5</td><td> </td><td>6</td><td> </td><td>7</td><td> </td><td>8</td><td> </td><td>9</td></tr>
		</table>
		Same situation, swap 9 and 8. Array sorted.<br/>
	</li>
	<li>
		<b>Time Complexity</b><br/>
		O(NlogN) Pretty much like other recursive method, or like a tree, in my opinion<br/>
	</li>
	</ul>
</li>
<li><b>Radix Sort</b><br/>
	<ul>
	<li><b>Summary</b><br/>
	A sorting method without comparison. Sort from smallest digit to largest digit.
	This is <b>NOT</b> a binary sort! Place in here temporarily.
	</li>
	<li><b>Logic</b><br/>
		<ol>
		<li>declare a queue array, array length is 10 (0-9).</li>
		<li>1st tier loop, loop from smallest digit to largest digit, this loop contains 2 2nd tier loops below</li>
		<li>2nd tier 1st loop, iterate through all items in input data array. Repeatedly enqueue the item into the queue that the queue's index is the current processing digit.
		(At this step all items are stored in the queue array based on current processing digit)</li>
		<li>2nd tier 2nd loop, iterate through the queue array. For each queue in the queue array that has items, dequeue them back to the data array.
		(Now the data array is restored in an order of sorting by current processing digit, and the queue array is empty)</li>
		<li>Back to 1st tier loop, 10 times the factor so we move 1 digit to the left. Carry on to next turn.</li>
		</ol>
	</li>
	<li><b>Example</b><br/>
	<b>data array {5, 37, 1, 61, 11, 59, 48, 19}</b><br/>
	Initially we have this data array, we wanna sort it.
	<table>
	<tr><td>0</td><td>1</td><td>2</td><td>3</td><td>4</td><td>5</td><td>6</td><td>7</td><td>8</td><td>9</td></tr>
	<tr><td></td><td>1</td><td></td><td></td><td></td><td>5</td><td></td><td>37</td><td>48</td><td>59</td></tr>
	<tr><td></td><td>61</td><td></td><td></td><td></td><td></td><td></td><td></td><td></td><td>19</td></tr>
	<tr><td></td><td>11</td><td></td><td></td><td></td><td></td><td></td><td></td><td></td><td></td></tr>
	</table>
	Firstly we look at least significant bit, digit 1. Enqueue the data array to the queue array based on digit 1.<br/>
	<b>data array {1, 61, 11, 5, 37, 48, 59, 19}</b><br/>
	After the queue array is restored, dequeue them back to the data array, now digit 1 is sorted.<br/>
	<table>
	<tr><td>0</td><td>1</td><td>2</td><td>3</td><td>4</td><td>5</td><td>6</td><td>7</td><td>8</td><td>9</td></tr>
	<tr><td>1</td><td>11</td><td></td><td>37</td><td>48</td><td>59</td><td>61</td><td></td><td></td><td></td></tr>
	<tr><td>5</td><td>19</td><td></td><td></td><td></td><td></td><td></td><td></td><td></td><td></td></tr>
	</table>
	Now move to digit 2, enqueue data array into queue array based on digit 2.<br/>
	<b>data array {1, 5, 11, 19, 37, 48, 59, 61}</b><br/>
	After the queue array is restored, dequeue them back to the data array, now digit 2 is sorted.<br/>
	(the data array is pretty much sorted, but we still need to continue in case that digit 3 is existed)<br/>
	<table>
	<tr><td>0</td><td>1</td><td>2</td><td>3</td><td>4</td><td>5</td><td>6</td><td>7</td><td>8</td><td>9</td></tr>
	<tr><td>1</td><td></td><td></td><td></td><td></td><td></td><td></td><td></td><td></td><td></td></tr>
	<tr><td>5</td><td></td><td></td><td></td><td></td><td></td><td></td><td></td><td></td><td></td></tr>
	<tr><td>11</td><td></td><td></td><td></td><td></td><td></td><td></td><td></td><td></td><td></td></tr>
	<tr><td>19</td><td></td><td></td><td></td><td></td><td></td><td></td><td></td><td></td><td></td></tr>
	<tr><td>37</td><td></td><td></td><td></td><td></td><td></td><td></td><td></td><td></td><td></td></tr>
	<tr><td>48</td><td></td><td></td><td></td><td></td><td></td><td></td><td></td><td></td><td></td></tr>
	<tr><td>59</td><td></td><td></td><td></td><td></td><td></td><td></td><td></td><td></td><td></td></tr>
	<tr><td>61</td><td></td><td></td><td></td><td></td><td></td><td></td><td></td><td></td><td></td></tr>
	</table>
	Same old, 3rd digit. Now only '0' in digit 3 has items.<br/>
	<b>data array {1, 5, 11, 19, 37, 48, 59, 61}</b><br/>
	Dequeue them back to data array, data array is sorted.<br/>
	</li>
	<li>
	<b>Time Complexity</b><br/>
	O(KN), for K digits we have K constant loops. For each loop, we iterate through whole data array, so N. Thus K*N.<br/>
	O(KN) is very fast, but need extra space, and queue operations are not counted in the performance analysis. The actually performance very much depend on how you implement<br/>
	</li>
	</ul>
</li>
<li><b>Heap Sort</b><br/>
	<ul>
	<li><b>Summary</b><br/>
	Use the "root always largest" feature of heap to sort.<br/>
	</li>
	<li><b>Logic</b><br/>
		<ol>
		<li>Insert all items to the heap.</li>
		<li>Delete(return) the root value back to the array.</li>
		</ol>
	</li>
	<li><b>Time complexity</b><br/>
	O(NlogN). Every Delete() of heap costs logN, thus N items cost NlogN.<br/>
	</li>
	</ul>
</li>
</ul>