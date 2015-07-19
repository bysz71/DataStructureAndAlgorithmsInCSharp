Radix Sort
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
