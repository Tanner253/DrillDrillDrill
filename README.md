# DrillDrillDrill
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
