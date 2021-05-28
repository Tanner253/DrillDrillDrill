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
