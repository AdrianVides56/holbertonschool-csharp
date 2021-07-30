# 0x06. C# - Classes and Namespaces

---

## Description :newspaper:
This project was created with learning purposes at Holberton School; on `Ubuntu 14.04` `.NET Core 2.1 LTS SDK`; and is about Classes and Namespaces. in C#.

---

 <p align="center">
<img height="250" src="https://miro.medium.com/max/1200/1*p6pwxZcq7-uww6pbqf2a2g.png">
</p>

### More Info
From this project forward, documenting your code is required!

Use [XML documentation comments](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/recommended-tags)
- [XML Documentation Best Practices](https://blog.rsuter.com/best-practices-for-writing-xml-documentation-phrases-in-c/)
- All public types / classes and their members should be documented with `<summary>` tags
- Private members should be documented but without XML comments
- To enable XML documentation in your project, you must add this line to the `PropertyGroup` in your `.csproj` file:
	- `<DocumentationFile>bin\$(Configuration)\$(TargetFramework)\$(AssemblyName).xml</DocumentationFile>`
- Compiling your project with `/doc` will create an XML file in the directory specified above. With the .xml in the same directory as the compiled assembly, VSCode will automatically read the XML file and use it to provide tooltips with your documentation. Keep this in mind as you write your comments; they should give the programmer clear, concise information about your methods’ purpose and usage.

### Learning Objectives

- [x] How to document C# code with XML comments
- [x] What is object-oriented programming?
- [x] What is a namespace
- [x] What is a class
- [x] What are objects and instances
- [x] What is the difference between a class and an object or instance
- [x] What is a field
- [x] What is a constructor
- [x] What is a property
- [x] How to use get and set
- [x] When to use a constructor and when to use a property
- [x] What is this and when to use it
- [x] What is a method
- [x] What are access modifiers
- [x] What is a static class
- [x] What is a static member
- [x] What is encapsulation
- [x] What is polymorphism
- [x] What is abstraction
- [x] What does toString do and how to override it
- [x] What is the difference between a class and a struct
- [x] When to use a class and when to use a struct
- [x] What is garbage collection in C#

---

### Resources :blue_book: :orange_book: :green_book:
Read or watch:
- [Object-Oriented programming (C#)](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/oop)

- [Object oriented programming](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/)

- [C# Classes & OOP](https://youtu.be/GAvhe6oe-_4)

- [Objects - create instances of types](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/objects)

- [Using namespaces (C# Programming Guide)](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/namespaces/using-namespaces)

- [this (C# Reference)](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/this)

- [.NET Stack and Heap](https://youtu.be/clOUdVDDzIM)

- [Fundamentals of garbage collection](https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/fundamentals)

---

### Tasks :white_check_mark:

#### 0. Braaainsss
Create a new namespace `Enemies`. Create an empty public class `Zombie` within `Enemies` that defines a zombie.

<details>
<summary>Example:</summary>

```sh
Your@Shell:~/0x06-csharp-classes/0-enemy$ ls
0-enemy.cs  0-enemy.csproj  0-main.cs  bin  obj
Your@Shell:~/0x06-csharp-classes/0-enemy$ dotnet run
newObject is of type Enemies.Zombie
String representation: Enemies.Zombie
```
</details>

#### 1. Healthy competition
Based on `0-enemy`, write a public class `Zombie` that defines a zombie by:

- public field `health`
- `health` should be an int and have no value
- public constructor: `public Zombie()`
	- sets the value of `health` to `0`

<details>
<summary>Example:</summary>

```sh
Your@Shell:~/0x06-csharp-classes/1-enemy$ ls
1-enemy.cs  1-enemy.csproj  1-main.cs  bin  obj
Your@Shell:~/0x06-csharp-classes/1-enemy$ dotnet run
newObject is of type Enemies.Zombie and has a total of 0 health
```
</details>

#### 2. Health validation
Based on `1-enemy`, write a public class `Zombie` that defines a zombie by:
- a new public constructor: `public Zombie(int value)`
	- `value` must be greater than or equal to 0
	- if value is less than 0, throw an ArgumentException with the message `Health must be greater than or equal to 0`

<details>
<summary>Example:</summary>

```sh
Your@Shell:~/0x06-csharp-classes/2-enemy$ ls
2-enemy.cs  2-enemy.csproj  2-main.cs  bin  obj
Your@Shell:~/0x06-csharp-classes/2-enemy$ dotnet run
newObject1 is of type Enemies.Zombie and has a total of 10 health
Health must be greater than or equal to 0
```
</details>

#### 3. Zombie health
Based on `2-enemy`, write a public class `Zombie` that defines a zombie by:
- private field `health`
- `health` should be an int and have no value
- public constructor: `public Zombie()`
	- sets the value of `health` to `0`
- public constructor: `public Zombie(int value)`
	- `value` must be greater than or equal to 0
- public method `public int GetHealth()` that returns the value of health of the Zombie object

<details>
<summary>Example:</summary>

```sh
Your@Shell:~/0x06-csharp-classes/3-enemy$ ls
3-enemy.cs  3-enemy.csproj  3-main.cs  bin  obj
Your@Shell:~/0x06-csharp-classes/3-enemy$ dotnet run
newObject1 is of type Enemies.Zombie and has a total of 10 health
newObject2 is of type Enemies.Zombie and has a total of 98 health
```
</details>

#### 4. Hello, my name is
Based on `3-enemy`, write a public class `Zombie` that defines a zombie by:
- private field `name`
- `name` should be a string and have a default value of `(No name)`
- public property `Name`
	- `get`: retrieve name
	- `set`: set name

<details>
<summary>Example:</summary>

```sh
Your@Shell:~/0x06-csharp-classes/4-enemy$ ls
4-enemy.cs  4-enemy.csproj  4-main.cs  bin  obj
Your@Shell:~/0x06-csharp-classes/4-enemy$ dotnet run
Ed is of type Enemies.Zombie and has a total of 10 health
(No name) is of type Enemies.Zombie and has a total of 98 health
```
</details>

#### 5. Printing a zombie
Based on `4-enemy`, write a public class `Zombie` that defines a zombie by:
- public `.toString()` override that prints the Zombie object’s attributes to stdout
	- Format: `Zombie Name: <name> / Total Health: <health>` (see example below)

<details>
<summary>Example:</summary>

```sh
Your@Shell:~/0x06-csharp-classes/5-enemy$ ls
5-enemy.cs  5-enemy.csproj  5-main.cs  bin  obj
Your@Shell:~/0x06-csharp-classes/5-enemy$ dotnet run
Zombie Name: Ed / Total Health: 10
Zombie Name: (No name) / Total Health: 98
```
</details>

---

## Author :bust_in_silhouette:
- [Adrian Vides] | [Twitter] | [GitHub]


---

[GitHub]: <https://github.com/AdrianVides56>
[Twitter]: <https://twitter.com/termi56661>
[Adrian Vides]: <https://www.linkedin.com/in/adrianvides56/>    
