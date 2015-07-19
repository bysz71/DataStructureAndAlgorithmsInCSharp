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


