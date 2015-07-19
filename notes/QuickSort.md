Quicksort
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
