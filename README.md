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
	<li>
		<b>Example</b><br/>
		(bold is pivot, inc and dec is underline, but github does not support underline)<br/>
		<b>7</b> <u>3</u> 8 2 5 6 0 1 9 <u>4</u><br/>
		//initial case, pivot == 7, data[inc] == 3, data[dec] == 4<br/>
		<b>7</b> 3 <u>8</u> 2 5 6 0 1 9 <u>4</u><br/>
		//data[inc] == 8, coz 8 > pivot 7, data[dec] == 4, coz 4 < pivot 7<br/>
		<b>7</b> 3 4 2 5 6 0 <u>1</u> <u>9</u> 8<br/>
		//swap 8 and 4; data[inc] == 9, data[dec] == 1, since dec < inc, loop ends<br/>
		1 3 4 2 5 6 0 <b>7</b> 9 8<br/>
		//now look at pivot, pivot 7 > data[dec] 1, swap 1 and 7, so now at left of 7 are all smaller than 7, right of 7 all greater<br/>
		[1 3 4 2 5 6 0] 7 [9 8]<br/>
		//now treat left of 7 as a sub-array, and right of 7 as a sub-array, look at left sub-array first, implement same method<br/>
		[<b>1</b> <u>3</u> 4 2 5 6 <u>0</u>] 7 [9 8]<br/>
		//initially pivot = 1, inc = 3, dec = 0<br/>
		[<b>1</b> <u>0</u> <u>4</u> 2 5 6 3] 7 [9 8] <br/>
		//since 3 > 1, 0 < 1, swap 3 and 0; data[inc] == 4, data[dec] == 0, dec < inc, loop ends<br/>
		[0 <b>1</b> 4 2 5 6 3] 7 [9 8]<br/>
		//pivot 1 > data[dec] 0, swap 0 and 1<br/>
		[0 1 [<b>4</b> <u>2</u> 5 6 <u>3</u>]] 7 [9 8]<br/>
		//left of pivot 1 is only 0, no sorting needed; right of 1 are treated as a sub-array now<br/>
		//initially pivot == 4, data[inc] == 2, data[dec] == 3<br/>
		[0 1 [<b>4</b> 2 <u>5</u> 6 <u>3</u>]] 7 [9 8]<br/>
		//data[inc] == 5, data[dec] == 3, swap 5 and 3<br/>
		[0 1 [<b>4</b> 2 <u>3</u> <u>5</u> 6]] 7 [9 8]<br/>
		//5 and 3 swapped, data[inc] == 5, data[dec] == 3, dec < inc, loops ends<br/>
		[0 1 [3 2 4 5 6]] 7 [9 8]<br/>
		//pivot 4 > data[dec] 3, swap 4 and 3;<br/>
		[0 1 [[3 2] 4 [5 6]]] 7 [9 8]<br/>
		//[3 2] is left sub-array and [5 6] is right sub-array<br/>
		//since only 2 items in a sub-array, inc and dec never moves, loop skip, jump to pivot comparing<br/>
		[0 1 [[2 3] 4 [5 6]]] 7 [9 8]<br/>
		//pivot 3 > data[dec] 2, swap 3 and 2nd<br/>
		//now to right sub-array, [5 6] are good, back to upper tier; upper tier is good, back to upper tier of upper tier right sub-array [9 8]<br/>
		[0 1 [[2 3] 4 [5 6]]] 7 [8 9]<br/>
		//swap 9 and 8, no upper tier exists, sorting finished<br/>
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
	</li>
	<li><b>Logic</b><br/>
	declare a queue array, array length is 10 (0-9).<br/>
	1st tier loop, loop from smallest digit to largest digit;<br/>
	2nd tier 1st loop, iterate through all items in input data array. Enqueue the item into the queue that the queue's index is this item's current processing digit number.<br/>
	(this step enqueue all items to the queue array in a sorted order based on the digit we are curretly looking at).<br/>
	2nd tier 2nd loop, iterate through the queue array. For each queue in the queue array that has items, dequeue them back to the data array.<br/>
	(thus now the data array are some kind of sorted that their current digit are in a sorted order. And the queue array is empty now).<br/>
	10 times the factor so we move 1 digit to the left. back to tier 1 loop and do again.<br/>
	</li>
	<li><b>Example</b><br/>
	<b>data array {5, 37, 1, 61, 11, 59, 48, 19}</b><br/>
	//initially we have this data array, we wanna sort it.<br/>
	<table>
	<tr><td>0</td><td>1</td><td>2</td><td>3</td><td>4</td><td>5</td><td>6</td><td>7</td><td>8</td><td>9</td></tr>
	<tr><td></td><td>1</td><td></td><td></td><td></td><td>5</td><td></td><td>37</td><td>48</td><td>59</td></tr>
	<tr><td></td><td>61</td><td></td><td></td><td></td><td></td><td></td><td></td><td></td><td>19</td></tr>
	<tr><td></td><td>11</td><td></td><td></td><td></td><td></td><td></td><td></td><td></td><td></td></tr>
	</table>
	//first time we look at LSB, digit 1. Enqueue to the queue list.<br/>
	<b>data array {1, 61, 11, 5, 37, 48, 59, 19}</b><br/>
	//iterate through the queue list and dequeue them back to the data array.<br/>
	<table>
	<tr><td>0</td><td>1</td><td>2</td><td>3</td><td>4</td><td>5</td><td>6</td><td>7</td><td>8</td><td>9</td></tr>
	<tr><td>1</td><td>11</td><td></td><td>37</td><td>48</td><td>59</td><td>61</td><td></td><td></td><td></td></tr>
	<tr><td>5</td><td>19</td><td></td><td></td><td></td><td></td><td></td><td></td><td></td><td></td></tr>
	</table>
	//now we look at 2nd digit, enqueue items from data array to the queue array<br/>
	<b>data array {1, 5, 11, 19, 37, 48, 59, 61}</b><br/>
	//iterate through the queue list and dequeue them back to the data array.(now the array is pretty much sorted, but theoretically we need one more step)<br/>
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
	//same old same old, 3rd digit<br/>
	<b>data array {1, 5, 11, 19, 37, 48, 59, 61}</b><br/>
	//same as 1 step before, but now we can officially close the case.<br/>
	</li>
	<li>
	<b>Time Complexity</b><br/>
	O(KN), for K digits we have K contant loops. For each loop, we iterate through whole data array, so N. Thus K*N.<br/>
	O(KN) is very fast, but need extra space, and queue oprations are not counted in the performance analysis. The actually performance very much depend on how you implement<br/>
	</li>
	</ul>
</li>
<li><b>Heap Sort</b><br/>
	<ul>
	<li><b>Summary</b><br/>
	Use the "root always largest" feature of heap to sort.<br/>
	</li>
	<li><b>Logic</b><br/>
	Insert all items to the heap.<br/>
	Delete(return) the root value back to the array.<br/>
	Sorted.<br/>
	</li>
	<li><b>Time complexity</b><br/>
	O(NlogN). Every Delete() of heap costs logN, thus N items cost NlogN.<br/>
	</li>
	</ul>
</li>
</ul>