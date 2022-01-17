# Fibonacci Search 
* it is **comparison based** technique that uses Fibonacci number to search an element in sorted array. 
* It works on sorted array, divide and conquer and has log(N) complexity

## Differences with Binary Search
* It divides the array into **un-equal parts**
* Binary search uses a **division operator to divide range** 
* Fibonacci search examines relatively closer elements in subsequent steps. So when the input array is big that cannot fit in CPU cache or even in RAM. 

## Algorithms 
1. Firstly, we need to find F(k) which is kth fibonacci number which is greater than or equal to the size of array (n).
2. If F(k) = 0, then we need to stop here and print the message as element not found.
3. Set variable offset = -1.
4. We need to set i = min( offset + F(k-2), n-1)
5. We will check:
    > If search element (s) == Array[i] then, return i and stop the search.
    If search element (s) > Array[i] then, k = k-1, offset = I and we need to repeat steps 4,5.
    If search element (s) < Array[i] then, k = k-2 repeat steps 4,5.