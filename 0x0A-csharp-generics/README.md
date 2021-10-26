# 0x0A. C# - Generics

---

## Description :newspaper:
This project was created with learning purposes at Holberton School; on `Ubuntu 14.04` `.NET Core 2.1 LTS SDK`; and is Generics in C#.

---

 <p align="center">
<img height="250" src="https://i2.wp.com/codingsonata.com/wp-content/uploads/2017/07/c.jpg?fit=1280%2C720">
</p>


### Learning Objectives

- [x] What are generics and what are their purpose
- [x] What common generic classes and interfaces are provided in the .NET class library
- [x] When and how to create generic classes
- [x] When and how to create generic methods
- [x] How access modifiers affect a class and its members
- [x] What is the `default(T)` expression used for
- [x] What is covariance and contravariance

---

### Resources :blue_book: :orange_book: :green_book:
Read or watch:
- [Generics (C# Programming Guide)](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/types/generics)
- [Generics in .NET](https://docs.microsoft.com/en-us/dotnet/standard/generics/)
- [C# Generics Tutorial: Whats and Whys](https://youtu.be/gyal6TbgmSU)
- [Access Modifiers (C# Programming Guide)](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers)
- [Covariance and Contravariance in Generics](https://docs.microsoft.com/en-us/dotnet/standard/generics/covariance-and-contravariance)
- [Covariance and Contravariance with C#](https://codepureandsimple.com/covariance-and-contravariance-with-c-410fc4102a02)

---

### Tasks :white_check_mark:

#### 0. Queue
Create a new class called Queue<T>.
- `Queue<T>` should not inherit from other classes or interfaces.
- Within `Queue<T>`, create a new method `CheckType()` that returns the Queue’s type.
- You are not allowed to use System.Collections or `System.Collections.Generic` for this project.
<details>
<summary>Example:</summary>

```sh
carrie@ubuntu:~/0x0A-csharp-generics/0-queue$ dotnet run
myStrQ Queue Type: System.String
myObjQ Queue Type: System.Object
carrie@ubuntu:~/0x0A-csharp-generics/0-queue$
```
</details>

#### 1. Enqueue
Based on `0-queue`, within `Queue<T>`, create a public class called `Node` with the following properties:
- `value`: can be of any type, set its initial value to `null`
- `next`: must be an object of type `Node`, set its initial value to `null`
- Define a constructor that takes a `value` for a new `Node` as its only parameter and sets it

Within `Queue<T>`, add the following properties:
- `head`: must be an object of type `Node`
- `tail`: must be an object of type `Node`
- `count`: type `int`

Add a new method `Enqueue()` to the class `Queue` that creates a new `Node` and adds it to the end of the queue.
- If the queue is empty, the method should make the new node the head of the queue
- `count` should update every time a new node is added

Add a new method `Count()` to the class that returns the number of nodes in the Queue.
<details>
<summary>Example:</summary>

```sh
carrie@ubuntu:~/0x0A-csharp-generics/1-enqueue$ dotnet run
Number of nodes in queue: 1
Number of nodes in queue: 2
----------
Number of nodes in queue: 3
Number of nodes in queue: 4
```
</details>

#### 2. Dequeue
Based on `1-enqueue`, add a new method `Dequeue()` to the class `Queue<T>` that removes the first node in the queue and returns its value.
- If the queue is empty, the method should write `Queue is empty` to the console and return the default value of the parameter’s type
<details>
<summary>Example:</summary>

```sh
carrie@ubuntu:~/0x0A-csharp-generics/2-dequeue$ dotnet run
Number of nodes in queue: 2
First value: 100
Number of nodes in queue: 1
----------
Number of nodes in queue: 1
First value: 9.8
Number of nodes in queue: 0
Queue is empty
First value: 0
```
</details>

#### 3. Peek
Based on `2-dequeue`, add a new method `Peek()` to the class `Queue<T>` that returns the value of the first node of the queue without removing the node.
- If the queue is empty, the method should write `Queue is empty` to the console and return the default value of the parameter’s type
<details>
<summary>Example:</summary>

```sh
carrie@ubuntu:~/0x0A-csharp-generics/3-peek$
First value: 100
Number of nodes in queue: 3
----------
Queue is empty
First value:
```
</details>

#### 4. Print
Based on `3-peek`, add a new method `Print()` to the class `Queue<T>` that prints the queue, starting from the head.
- If the queue is empty, the method should write `Queue is empty` to the console
<details>
<summary>Example:</summary>

```sh
carrie@ubuntu:~/0x0A-csharp-generics/4-print$
hello
holberton
school
----------
Queue is empty
```
</details>

#### 5. Concatenate
Based on `4-print`, create a method `Concatenate()` that concatenates all values in the queue only if the queue is of type `String` or `Char`.
- If queue is empty, print `Queue is empty` and return `null`
- If the queue is not of type `String` or `Char`, print `Concatenate() is for a queue of Strings or Chars only.` to the console and return `null`
<details>
<summary>Example:</summary>

```sh
carrie@ubuntu:~/0x0A-csharp-generics/5-concatenate$
hello holberton school
----------
Queue is empty
----------
abc
```
</details>

---

## Author :bust_in_silhouette:
- [Adrian Vides] | [Twitter] | [GitHub]


---

[GitHub]: <https://github.com/AdrianVides56>
[Twitter]: <https://twitter.com/termi56661>
[Adrian Vides]: <https://www.linkedin.com/in/adrianvides56/>    
