Common Data Structure And Algorithms Implementation Using C#
============================================================
Description:
------------
<p>This project is about using c# to implement common data structures and algorithms. C# is a very engineering type language, it is very efficiency at developing and cooperating.
Most common data structures and algorithms are already perfectly built in, usually people do not use c# to study structure and algorithms.</p>
<p>Using c# to implement data structure and algorithms are my very personal choice. Currently my goals include get through common data structures and algorithms, 
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
swap current item with currently smallest item, and move 1 item forward<br/>
time complexity O(N^2), for{for{}}<br/>
- Insertion Sort
iterate to out-of-order item, insert it to its right position by shift other items from that position, and go on<br/>
time complexity O(N^2), for{for{}}<br/>
- Bubble Sort
treat 2 items as a bubble, swap if needed, and move on unitil reach the end. Do this again and again until no swapping happens.
time complexity O(N^2), while{for{}}<br/>

AdvanceSort:
------------
- Merge Sort
<p>Based on Merge method. Merge method merges 2 sorted array into one sorted array. Merge Sort breaks array into smallest chunks and recursively implmemt Merge.</p>
<p>time complexity O(NlogN), because Merge is O(N) and its tree structure is O(logN)<p>

