# Singly Linked List 

[Basic Operation](https://www.alphacodingskills.com/cs/ds/cs-reverse-the-linked-list.php)

## Complexities
| Operation | Time | Space | 
| :---: | :---: | :---: | 
| Access i-th element | O(N)| O(1) |
| Traverse all elements | O(N)| O(1) |
| Insert element E at current point |  O(1) |O(1) |
| Delete Current Element | O(1) |O(1) |
| Insert element E at front | O(1) | O(1) |
| Insert element E at end | O(N)|O(1) |
* **Linked List Class** 
```
public class LinkedList<T> {
        public Node<T> head;
    }

    public class Node<T> {
        T data;
        public Node<T> next;

        public Node(T value) {
            this.data = value;
            next = null;
        }
    }
```

* **creating linked list** 
```
public static void Main(string[] args) {
    LinkedList<int> linkedList = new LinkedList<int>();
    linkedList.head = new Node<int>(1);
    Node<int> second = new Node<int>(2);
    Node<int> third = new Node<int>(3);
    linkedList.head.next = second;
    second.next = third;
 }
```

## Inserting

* **Insert at start**
```
public void InsertAtStart(T data) {
    var newElem = new Node<T>(data);
    newElem.Next = Head;
    Head = newElem;
        }
```
* **Insert after**
```
public void InsertAfter(Node<T> prevNode, T data)
{
    if (prevNode == null)
        throw new InvalidOperationException("Provided Node is null");

    var newElem = new Node<T>(data);
    newElem.Next = prevNode.Next;
    prevNode.Next = newElem;
}
```
* **insert at end**
```
public void InsertAtEnd(T data)
{
    if(Head == null)
        Head = new Node<T>(data);
    var current = Head;
    while(current.Next != null)
        current = current.Next;
    current.Next = new Node<T>(data);
}
```