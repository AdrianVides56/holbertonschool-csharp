# 0x03. C# - Data Structures: HashSet, Stack, Queue, LinkedList

---

## Description :newspaper:
This project was created with learning purposes at Holberton School; on `Ubuntu 14.04` `.NET Core 2.1 LTS SDK`; and is about Sets, Stacks, Queues and LinkedLists in C#.

---

 <p align="center">
<img height="250" src="https://mymasterdesigner.com/wp-content/uploads/2021/04/C-For-Beginner-Tutorial-Loop-Part.jpeg">
</p>



### Learning Objectives

- [x] How to create and use arrays
- [x] What are Collections in C#?
- [x] How to create and use hashsets
- [x] How to create and use stacks
- [x] How to create and use queues
- [x] How to create and use linked lists
- [x] How to use foreach

---

### Resources :blue_book: :orange_book: :green_book:
Read or watch:
- [Collections (C#)](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/collections)

- [Stacks and Queues in C#](https://www.youtube.com/watch?v=tW75yz3X_M4)

- [C# LinkedList](https://www.dotnetperls.com/linkedlist)

- [HashSet<T> Class](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1?redirectedfrom=MSDN&view=netframework-4.7.2)

- [Stack<T> Class](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.stack-1?redirectedfrom=MSDN&view=netframework-4.7.2)

- [Queue<T> Class](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.queue-1?redirectedfrom=MSDN&view=netframework-4.7.2)
- [LinkedList<T> Class](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.linkedlist-1?redirectedfrom=MSDN&view=netframework-4.7.2)

- [C# Coding Conventions](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)

---

### Tasks :white_check_mark:

#### 0. C# Coding Conventions
Write a method that adds all unique integers in a list.
- Class Name: `List`
- Prototype: `public static int Sum(List<int> myList)`
- Returns the sum of unique integers in given list

<details>
<summary>Example:</summary>

```sh
carrie@ubuntu:~/0x03/0-unique_add$ ls
0-main.cs  0-unique_add.cs  0-unique_add.csproj  bin  obj
carrie@ubuntu:~/0x03/0-unique_add$ dotnet run
36
42
```
</details>

#### 1. Present in both
Write a method that returns a sorted list of common elements in two lists.
- Class Name: `List`
- Prototype: `public static List<int> CommonElements(List<int> list1, List<int> list2)`
- Returns a new sorted list of common elements in two given lists
- You cannot use `LINQ`
- You cannot use `SortedList`

<details>
<summary>Example:</summary>

```sh
carrie@ubuntu:~/0x03/1-common_elements$ ls
1-common_elements.cs  1-common_elements.csproj  1-main.cs  bin  obj
carrie@ubuntu:~/0x03/1-common_elements$ dotnet run
2
4
6
```
</details>

#### 2. Only differents
Write a method that returns a sorted list of all elements present in one or the other list but not both.
- Class Name: `List`
- Prototype: `public static List<int> DifferentElements(List<int> list1, List<int> list2)`
- Returns a new sorted list of all elements present in one or the other list but not both of the given lists
- You cannot use `LINQ`
- You cannot use `SortedList`

<details>
<summary>Example:</summary>

```sh
carrie@ubuntu:~/0x03/2-different_elements$ ls
2-different_elements.cs  2-different_elements.csproj  2-main.cs  bin  obj
carrie@ubuntu:~/0x03/2-different_elements$ dotnet run
0
1
3
5
7
8
```
</details>

#### 3. Full stack
Given a `Stack<string>`, write a method that does the following:

- Class: `MyStack`
- Prototype: `public static Stack<string> Info(Stack<string> aStack, string newItem, string search)`
- Print the number of items in `aStack`
	- Format: `Number of items: <number>`
- Print the item at the top of `aStack` without removing it
	- Format: `Top item: <item>`
	- If `aStack` is empty, print `Stack is empty`
- Print if `aStack` contains a given item `search`
	- Format: `Stack contains <search>: <True / False>`
- If `aStack` contains the given item `search`, remove all items up to and including `search`; otherwise, leave `aStack` as is
	- You can use `.Pop()` only once
- Add a new given item `newItem` to `aStack`
- Return `aStack`

<details>
<summary>Example:</summary>

```sh
carrie@ubuntu:~/0x03/3-stack_push_pop$ ls
3-main.cs  3-stack_push_pop.cs  3-stack_push_pop.csproj  bin  obj
carrie@ubuntu:~/0x03/3-stack_push_pop$ dotnet run
Ruby
React
Python
Javascript
HTML
C
------
Number of items: 6
Top item: Ruby
Stack contains "Javascript": True
------
C#
HTML
C
```
</details>

#### 4. Queue it up
Given a `Queue<string>`, write a method that does the following:
- Class: `MyQueue`
- Prototype: `public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)`
- Print the number of items in `aQueue`
	- Format: `Number of items: <number>`
- Print the item at the top of `aQueue` without removing it
	- Format: `First item: <item>`
	- If `aQueue` is empty, print `Queue is empty`
- Add a new given item `newItem` to `aQueue`
- Print if `aQueue` contains a given item `search`
	- Format: `Queue contains <search>: <True / False>`
- If `aQueue` contains the given item `search`, remove all items up to and including `search`; otherwise, leave `aQueue` as is
	- You can use `.Dequeue()` only once
- Return `aQueue`

<details>
<summary>Example:</summary>

```sh
carrie@ubuntu:~/0x03/4-queue_enqueue_dequeue$ ls
4-main.cs  4-queue_enqueue_dequeue.cs  4-queue_enqueue_dequeue.csproj  bin  obj
carrie@ubuntu:~/0x03/4-queue_enqueue_dequeue$ dotnet run
C
HTML
Javascript
Python
React
Ruby
------
Number of items: 6
First item: C
Queue contains "Javascript": True
------
Python
React
Ruby
C#
```
</details>

#### 5. Print a LinkedList
Write a method that creates and prints a LinkedList of integers of a given size.
- Class Name: `LList`
- Prototype: `public static LinkedList<int> CreatePrint(int size)`
- Returns the newly created list
- If `size` is negative, return an empty list

<details>
<summary>Example:</summary>

```sh
carrie@ubuntu:~/0x03/5-print_linkedlist$ ls
5-main.cs  5-print_linkedlist.cs  5-print_linkedlist.csproj  bin  obj
carrie@ubuntu:~/0x03/5-print_linkedlist$ dotnet run
0
1
2
3
4
5
6
7
-------------
Linked List Length: 8
```
</details>

#### 6. LinkedList length
Write a method that returns the number of elements in a LinkedList.
- Class Name: `LList`
- Prototype: `public static int Length(LinkedList<int> myLList)`
- Returns the number of elements in a given LinkedList
- You are not allowed to use `.Count()`

<details>
<summary>Example:</summary>

```sh
carrie@ubuntu:~/0x03/6-linkedlist_length$ ls
6-linkedlist_length.cs  6-linkedlist_length.csproj  6-main.cs  bin  obj
carrie@ubuntu:~/0x03/6-linkedlist_length$ dotnet run
6
```
</details>

#### 7. Add node to the beginning
Write a method that adds a node to the beginning of a LinkedList.
- Class Name: `LList`
- Prototype: `public static LinkedListNode<int> Add(LinkedList<int> myLList, int n)`
- Returns the newly added node

<details>
<summary>Example:</summary>

```sh
carrie@ubuntu:~/0x03/7-linkedlist_add$ ls
7-linkedlist_add.cs  7-linkedlist_add.csproj  7-main.cs  bin  obj
carrie@ubuntu:~/0x03/7-linkedlist_add$ dotnet run
1 2 3 4 5 
0 1 2 3 4 5 
```
</details>

#### 8. Find value
Write a method that finds a value in a LinkedList and returns its index position in the list.
- Class Name: `LList`
- Prototype: `public static int FindNode(LinkedList<int> myLList, int value)`
- Returns the index position of the first occurrence of the value given or -`1` if the value is not in the list
- You are not allowed to use `.Find()` or `FindLast()`

<details>
<summary>Example:</summary>

```sh
carrie@ubuntu:~/0x03/8-linkedlist_find$ ls
8-linkedlist_find.cs  8-linkedlist_find.csproj  8-main.cs  bin  obj
carrie@ubuntu:~/0x03/8-linkedlist_find$ dotnet run
Node Position: 3
Node Position: 0
Node Position: -1
```
</details>

#### 9. Pop
Write a method that deletes the head node of a LinkedList and returns that node’s data.
- Class Name: `LList`
- Prototype: `public static int Pop(LinkedList<int> myLList)`
- Returns the value of the head node
- If the list is empty, return `0`

<details>
<summary>Example:</summary>

```sh
carrie@ubuntu:~/0x03/9-linkedlist_pop$ ls
9-linkedlist_pop.cs  9-linkedlist_pop.csproj  9-main.cs  bin  obj
carrie@ubuntu:~/0x03/9-linkedlist_pop$ dotnet run
11
```
</details>

#### 10. Get node at index
Write a method that returns the value of the nth node of a LinkedList.

Class Name: `LList`
Prototype: `public static int GetNode(LinkedList<int> myLList, int n)`
Returns the value of the node at the given index
If the node doesn’t exist, return `0`
Indexing starts at 0

<details>
<summary>Example:</summary>

```sh
carrie@ubuntu:~/0x03/10-linkedlist_get_node$ ls
10-linkedlist_get_node.cs  10-linkedlist_get_node.csproj  10-main.cs  bin  obj
carrie@ubuntu:~/0x03/10-linkedlist_get_node$ dotnet run
66
```
</details>

#### 11. LinkedList sum
Write a method that returns the sum of all the data of a LinkedList.
- Class Name: `LList`
- Prototype: `public static int Sum(LinkedList<int> myLList)`
- Returns the sum of the data in the LinkedList

<details>
<summary>Example:</summary>

```sh
carrie@ubuntu:~/0x03/11-linkedlist_sum$ ls
11-linkedlist_sum.cs  11-linkedlist_sum.csproj  11-main.cs  bin  obj
carrie@ubuntu:~/0x03/11-linkedlist_sum$ dotnet run
98
```
</details>

#### 12. Insert in order
Write a method that inserts a new node in the correct position in an ordered LinkedList.
- Class Name: `LList`
- Prototype: `public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)`
- Returns the newly created node

<details>
<summary>Example:</summary>

```sh
carrie@ubuntu:~/0x03/12-linkedlist_insert$ ls
12-linkedlist_insert.cs  12-linkedlist_insert.csproj  12-main.cs  bin  obj
carrie@ubuntu:~/0x03/12-linkedlist_insert$ dotnet run
1
4
9
16
25
36
49
------------------
1
4
9
16
21
25
36
49
```
</details>

#### 13. Delete at index
Write a method that deletes the node at given position in a LinkedList.
- Class Name: `LList`
- Prototype: `public static void Delete(LinkedList<int> myLList, int index)`

<details>
<summary>Example:</summary>

```sh
carrie@ubuntu:~/0x03/13-linkedlist_delete$ ls
13-linkedlist_delete.cs  13-linkedlist_delete.csproj  13-main.cs  bin  obj
carrie@ubuntu:~/0x03/13-linkedlist_delete$ dotnet run
1
4
9
16
25
36
49
-------------------
1
4
9
16
25
49
```
</details>

---

## Author :bust_in_silhouette:
- [Adrian Vides] | [Twitter] | [GitHub]


---

[GitHub]: <https://github.com/AdrianVides56>
[Twitter]: <https://twitter.com/termi56661>
[Adrian Vides]: <https://www.linkedin.com/in/adrianvides56/>    
