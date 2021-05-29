# DrillDrillDrill
Interview training

### Two Sum solution: O(n) time O(n) space
iterate through array, solve for Y. Use index intiger and subrtract it from the target sum to find the misssing value. if the missing value shows up in the array, we have solved the problem with a o(1) lookup in the hashset.

### Validate Subsequence
The two parameters on this question were Lists, so for loops were not used. instead I used a foreach loop (while loop also viable) to compare each value to the index of the subsequence. if the pointer doesnt make it to the end of the subsequence before the foreach loop ends, it is not a subsequence.

### Sorted Squared Array
O(n log n) sort
O(n) space
The solution copies the length of the given array to an output array, and squared each index, and inserts them into the output array. This solution works well with arrays the are given sorted with positive numbers but negative numbers would be sorted differently. A more optimal solution would require the output array to be filled in from right to left, desccending, in order to avoid the extra time complexity of the Array.Sort method

### Tournament winner
O(n) time
O(k) space where k is the number of characters in each team name 
was a task that involved a 2D array and the use of a Dictionary for O(1) lookup and efficient space. Teams were awarded points based on winnings, and the team with the largest amount of points won. Made good use of Ternary operators and the Dictionary.

### NonConstructibleChange
Space: O(1)
Time: O(nlogn) The solution requires a sorted array.
This problem reuired me to return the smallest amount of change possible from a data set of change. The solution was not clear to me at first but sorting the array and noticing that prior to the number being returned, the amount was never more than the running sum of change + 1, which allowed me to leverage for a solution knowing that if the value being compared was larger than the running sum, the solution was then the current running sum + 1.
