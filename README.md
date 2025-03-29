The collection must be sorted first.

The binary algorithm search is defined as:

Divide the search space into two halves by finding the middle index.
Compare the middle element of the search space with the key.
If the key is found at middle element, the process is terminated.
If the key is not found at middle element, choose which half will be used as the next search space:
If the key is smaller than the middle element, then the left side is used for next search.
if the key is larger than the middle element, then the right side is used for next search.
This process is continued until the key is found or the total search space is exhausted.


Using Two Pointers Technique to count pairs with given sum.

The idea is to sort the input array and use two-pointer technique. Maintain two pointers, say left and right
and initialize them to the first and last element of the array respectively. According to the sum of the left and right pointers,

we can have three cases:
arr[left] + arr[right] < target: Increase the pair sum by moving the left pointer towards right.

arr[left] + arr[right] > target: Decrease the pair sum by moving the right pointer towards left.

arr[left] + arr[right] = target: We have found a pair whose sum is equal to target. We can find the product of the count
of both the elements and add them to the result.

These definitions is provided by: https://www.geeksforgeeks.org
