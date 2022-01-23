# Linked List

* **Def**: Linear data structure; Stored in Non-continuous manner; 
![Linkedlist](./img/Linkedlist.png)

## Why LinkedList? 
* Limitation of **Arrays**: 
    1. **fixed size** : Upper Limit of elements to store must be known
    2. **inserting new element is expensive**: All existing elements needs to be shifted
    3. **deleting is expensive**  
* Advantage over **Arrays**: 
    1. **dynamic size** 
    2. **easy insertion/deletion** 
* Drawbacks of **Linked List**
    1. **random access not allowed** 
    2. **extra space required for pointers** 
    3. **not cache friendly**: In arrays there is locality of references 

## LinkedList vs Array
**Arrays** store in continuous memory location, leading to **calculable address**; faster access to **specific index**
1. **size**: In **arrays** size cannot be altered at runtime; In **linked list** size can change dynamically(expand or shrink) at runtime. 
2. **memory allocation**: Arrays -> Compile time; LinkedList -> Run time;
3. **Memory Efficiency**: LinkedList use more memory but size flexibility makes it use less memory overall. 
4. **Execution time**: In Arrays -> direct access; In LinkedList -> traverse all elements before that element to be access; **modification** is faster in arrays; **inserting/updating** is faster in linkedlist. 
