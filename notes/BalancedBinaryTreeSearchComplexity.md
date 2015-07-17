#Search time complexity for a balanced binary tre
(this note is not rigorous, just to give a general idea)
* Firstly, refer to Big O Notation. See [A beginner's guide to Big O notation(Rob Bell)](https://rob-bell.net/2009/06/a-beginners-guide-to-big-o-notation)
* for a balanced binary tree, generally its search time complexity of the worst case should be equal to the max-height of the tree.
* counting from the root, the number of nodes at each level should be {1,2,4,8,...,2^h}, which "h" is the max-height.

|nodes at each lvl    |total nodes at each lvl|height  |
|--------------------:|----------------------:|-------:|
|1                    |1                      |0       |
|2                    |3                      |1       |
|4                    |7                      |2       |
|8                    |15                     |3       |
|...                  |...                    |...     |
|2^h                  |2^(h+1)-1              |h       |  

Let's say total nodes is "n", time complexity is "h"  
```
2^(h+1) - 1 = n-1  
2^(h+1) = n-1  
2^(h+1) = n   //1 here is a low order constant, ignore it  
log 2 (2^(h+1)) = log 2 n  
h+1 = log(n)  //ignore 1 on the left  
h = log(n)
```

Thus we say the time complexity would be O(log(n))  
Again this is not rigorous, refer to CLRS, generally people use mathematical induction to prove time complexity, although I could
 not do it for now :(  
Please comment if you think you can correct or improve this.
