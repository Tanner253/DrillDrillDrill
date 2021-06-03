# DrillDrillDrill

All solutions are found in the Program.cs files of each folder.


please excuse typos i will clean it up eventually.

Interview training
#### what is a logorithm?
What is O(log(n))? This is a representation of the behavior of an algorithm or function when the input size is changed. when we have 2 items in an array if you were to cut the array in half you would have done 1 operation. if you double in the input, to 4. your number of operations increases by one. do it again, log(n) of 8 is 3. this is an important concept to understand as having an algorithm run in O(log(n)) time is extremely good and sought after when making coding algoithms when possible. a great example is if you are working on a balance binary search tree your algorithms will almost always be O(log(n)) time when traversing the tree for a specific output.

### Two Sum solution: O(n) time O(n) space
Write a function that takes in a non-empty array of distinct intigers and an integer representing a target sum. if any two numbers in the input array sum up to the target sum the function should return them in an array.
iterate through array, solve for Y. Use index intiger and subrtract it from the target sum to find the misssing value. if the missing value shows up in the array, we have solved the problem with a o(1) lookup in the hashset.

### Validate Subsequence
given an array of values and a subsequence of values determine if the subsequence is present in the array of values.
The two parameters on this question were Lists, so for loops were not used. instead I used a foreach loop (while loop also viable) to compare each value to the index of the subsequence. if the pointer doesnt make it to the end of the subsequence before the foreach loop ends, it is not a subsequence.

### Sorted Squared Array
write a function that takes in a non-empty array of integers that are sorted in ascending order and returns a new array of the same length with the squares of the original integers also sorted in ascending order
O(n log n) sort
O(n) space
The solution copies the length of the given array to an output array, and squared each index, and inserts them into the output array. This solution works well with arrays the are given sorted with positive numbers but negative numbers would be sorted differently. A more optimal solution would require the output array to be filled in from right to left, desccending, in order to avoid the extra time complexity of the Array.Sort method

### Tournament winner
given an array of pairs represeinting the teams that have competed against each other and an array containing the results of each competittion, write a function that returns the winner of the tournament.
O(n) time
O(k) space where k is the number of characters in each team name 
was a task that involved a 2D array and the use of a Dictionary for O(1) lookup and efficient space. Teams were awarded points based on winnings, and the team with the largest amount of points won. Made good use of Ternary operators and the Dictionary.

### NonConstructibleChange
Given an array of positive intigers representing the value of coins in your possession. write a function that returns the amount of change (Min sum) that you *CANNOT* create
Space: O(1)
Time: O(nlogn) The solution requires a sorted array.
This problem reuired me to return the smallest amount of change possible from a data set of change. The solution was not clear to me at first but sorting the array and noticing that prior to the number being returned, the amount was never more than the running sum of change + 1, which allowed me to leverage for a solution knowing that if the value being compared was larger than the running sum, the solution was then the current running sum + 1.

### Find Closest Value in BST
Time: O(log(n))
space: O(1)
Write a function that takes in a binary search tree and returns the value closest to the target given.
This problem was a great refresher on the implimentation of basic BST tasks like inserting, deleting, or searching for a specific node in a BST taking advatage of the properties  of it making the time complexity O(log(n)) time but if there was only one branch to the BST then the worst case for time would be O(n) as we would need to traverse through n nodes to find the closest to target node.

### Return the sums of all the branches of a BST from left to right
Time: O(n) 
Space: O(n) where n is the number of nodes in the given tree
This was a good refresher on recursive formulas as well as a depth first traversal.

### Node Depths
Space: O(h) where h is the height of the tree
Time: O(n) where n is the number of nodes in the tree
Write a function that takes in a binary tree and returns the sum of its nodes' depths.

### Depth first traversal of graph / BT
O(v + e) time
O(v) space
impliment a depth first traversal of a tree from left to right and store sall the names in an input array and returns it 

### Minimum waiting time
given a non empty array of positive intigers representing the amounts of time that a specific queries take to execute. only one query can be executed at a time but the queries can be executd in any order. find the minimum query wait time.

### Class Photos
space: O(1) not introducing anything just comparing values
time: O(nlog(n)) + n -> 2log(n) -> O(log(n))
given two input arrays and a set of rules determine weather a class picture can be taken. This problem was fun and a great refresher on how to index and manipulate a list. I was also reminded how to use the llamda expression to leverage the Sort extension method to not just sort it quickly, but also manipulate the data in a fashion that is desireable, like descending order.

### Tandem Bicycle
time: O(nlog(n)) 
space: O(1)
Given two equal arrays of positive intigers, determine the fasted possible speed or slowest possible speed based on a given boolean. This problem was tricky at first but i didnt even think to take advantage of the Array.Sort extensions. i origionally started a pointed at the end of one array (Length -1) but i could have just reversed one array so that they were opposite of eachother, and then use the same index (i) to access both values. instead of doing this my brute force solution included a second index of j to work in reverse order of the second array if needed. I included my brute force solution as well.


### removing duplicates from a linked list
time: O(n)
space O(1) where n is the number of nodes in a linked list to check through
the solution to this problem is pretty straight forward. there is plenty of ways to impliment it but my favorite is simply setting the current node to next.next in order to completely skip the next node (which weve checked the value for and have found it is a duplicated) effectivly removing the node that was skipped from the linked list as no pointers are referecned to it anymore. my one question is, is the skipped node still in memory? can we just not access this node anymore beause it is a singly linked list? do we not care? if it was a doubly linked list obviously we would need to replace both pointers for the duplicated nodes, to make sure they are garbage collected, but does this occur naturally with a singly linked list or is there going to be extra data/space being taken up that we cant see on the front.

### Fibonacci
Time: O(2^n)
space: O(n)
given integer n return the nth fibonacci number

### Product sum of special arrays
time: O(n) where n is the amount of elements in array
space: O(d) where d is the depth of the special array
given a special array return the product sum of the array. This algorithm was a tricky one but a great one for recursion. in fact when the recursive solution clicks it is beautiful :)

### Binary Search Array
Time: O(log(n))
space: O(log(n)) time and space complexity is log of n becuase each time we run an operation on the array, we are cutting off half of the data to work with making the data set smaller. this would mean if we doubled our dataset the amount of operations would only increase  by one.

### Find the three largest numbers
space:O(1)
Time: O(n) where n is the amount of numbers int he input array
write a function that takes in an array of at least three intigers and without sorting the input array returns a sorted array of the three largest integers in the input array
this was a good reminder that array manipulation is a little trickier than it looks.

### Bubble sort implimentation
Best: O(n) time O(1) space
AVG/WORST: O(n^2) time and O(1) space
Bubble sort is not the most efficient of the sorting algorithms by any means however it is a good segway to understanding sorts and how they work. This sorting algorithm is great for practicing and understanding the array data structure and manupulating them in place.

### Insertion Sort
Best: O(n) time O(1) space
AVG/Worst: O*(n^2) time O(1) space
Another great sorting algorithm, this one seemed to be really intuitive as well, makes me excited to see the more complicated sorting algorithms. I need to study these more! 

### Selection Sort
Best: O(n^2) time O(1) space
This sorting algorithm made a lot more sense to me than the previous two, in terms of how quickly i was able to impliment them. Selection sort seems like a great sorting algorithm but is still running in O(n^2) and this can be optimized further my merge sort or heap sort or quick sort. all in all good excercise.

### Is Palindrome?
O(n^2) time O(n) where n is the number of characters in the input string
Given a string return a boolean of true or false if the string is a palindrome or not. intitially i imagined using a stack, pushing each index of the given input into a stack then poping each element off the stack and comparing it to the string again. this would not be efficient but was my initial thinking. Luckily C# gives multiple ways to reach a solution WITHOUT intorducing another datastructure, using the Equal extension method on the string class allowed me to validate a palindrome or not with one single line. cool stuff. this was a fun little short algorith.

### Run-Length Encoding"
O(n) time O(n) space where n is the size of the input string.
given a non empty string return the run length encoding for each character
this is a no loss encoding or a loss less encoding which means given the output we can decode it to again reach the input. and vice versa. the loss less encoding saves space efficiently without losing any data. Once this problem clicks for you and you understand the full complexity of it, it will make you smile as it is a really neat algorithm.

### Generate Document
O(c * (n + m)) time O(c) space where n is the number of characters, m is the length of the document, and c is the number of unique characters in the document
Write a function that determins weather or not a document can be created with a given set of characters, each of which can only be used one time.
it didn't occur to me immediatly but while looking for the amount of times unique values occures hashsets are great for. while hashmaps return on collisions, hashsets are great for incrimenting a key value, when the key is reached. then you just look up the hashset at a given value to see if there are available characters to be used in the creation of the document. if there is ever a need for a specific character to be used in the document but the hashset says there are none left, it will return false. if the function runs without this being the case then we can indeed create the document with the given characters.

### Detecting first non duplicate
O(n) time where n is the amount of letters in given string
O(1) space where at most the dictionary takes up 26 characters.
Initially i had thought of using a hashmap to detect collisions and detect where the first one happened but i would lose track of the amount of occurrences, so a Dictionary seemed to work well wjhere the key of the dictionry would be each character and the value would be the frequency of the letter, iterate through, populating the dictionary first, then iterate through again, checking the values of the dictionary in order of the string, and returning the first letter to only occur once. if this does not happen return -1.

### Three number sum
O(n^2) time
O(n) space where n is the number of elements in the input array
At first given the fact we have to compare each index with 2 of all the other elements to reach a target sum screamed nested forloop but that would have been o n cubed time, There has to be a better way. Turns out using pointers and the basic rules of a sorted array, we can easily sum all of the possible combinations with one pass through the array, it is squared because we have to do operations inside of another while loop till we find a correct sum on a given index, then we move the index and check the other elements for another match. This was a great refresher on basic array manipulation, and a reminder sorted arrays are mroe often than not easier to work with.

### The smallest difference
O(nlog(n) + mlog(m) time O(1) space
This problem was a little trickier than i inticipated but thanks to algo expert got to a solution. 2 pointers is the trick~
