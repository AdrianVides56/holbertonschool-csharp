# 0x04. C# - Exceptions

---

## Description :newspaper:
This project was created with learning purposes at Holberton School; on `Ubuntu 14.04` `.NET Core 2.1 LTS SDK`; and is about Exceptions and Exception Handling in C#.

---

 <p align="center">
<img height="250" src="https://raygun.com/blog/images/common-c-sharp-exceptions/feature.png">
</p>



### Learning Objectives

- [x] What are exceptions and when to use them
- [x] What is the purpose of catching exceptions
- [x] How to handle exceptions
- [x] How to use `try`, `catch`, `finally`
- [x] How to raise built-in exceptions
- [x] When to implement clean-up actions after exceptions


---

### Resources :blue_book: :orange_book: :green_book:
Read or watch:
- [Exceptions and Exception Handling](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/)
- [C# Exception Handling Best Practices](https://stackify.com/csharp-exception-handling-best-practices/)
- [Creating and Throwing Exceptions](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/creating-and-throwing-exceptions)
- [How to execute cleanup code using finally](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/how-to-execute-cleanup-code-using-finally)

---

### Tasks :white_check_mark:

#### 0. Safe list printing
Write a method that prints n elements of a list.
- Class Name: `List`
- Prototype: `public static int SafePrint(List<int> myList, int n)`
- `n` represents the number of elements to print
- `n` can be bigger than the length of `myList`
- Returns number of elements actually printed
- You have to use `try` / `catch`

<details>
<summary>Example:</summary>

```sh
Your@Shell: ~/0x04/0-safe_list_print$ ls
0-main.cs  0-safe_list_print.cs  0-safe_list_print.csproj  bin  obj
Your@Shell: ~/0x04/0-safe_list_print$ dotnet run
1
2
3
4
5
Number of integers printed: 5

1
2
3
Number of integers printed: 3

1
2
3
4
5
Number of integers printed: 5
```
</details>

#### 1. Integer division
Write a function that divides 2 integers and prints the result.
- Class Name: `Int`
- Prototype: `public static void divide(int a, int b)`
- You can assume that `a` and `b` are integers
- You have to use `try` / `catch` / `finally`
- The result of the division should print in the `finally` section in the format shown in the example

<details>
<summary>Example:</summary>

```sh
Your@Shell: ~/0x04/1-divide_print$ ls
1-main.cs  1-divide_print.cs  1-divide_print.csproj  bin  obj
Your@Shell: ~/0x04/1-divide_print$ dotnet run
4 / 3 = 1

Cannot divide by zero
9 / 0 = 0
```
</details>

#### 2. Divide lists
Write a function that divides element by element 2 lists.
- Class Name: `List`
- Prototype: `public static List<int> Divide(List<int> list1, List<int> list2, int listLength)`
- `length` can be bigger than the length of either list
- Returns a new list of all division results
- If 2 elements can’t be divided, the division result should be equal to `0`
- If the division can’t be done (dividing by 0):
	- print `Cannot divide by zero`
- If either list is too short:
	- print `Out of range`
- You have to use `try` / `catch`

<details>
<summary>Example:</summary>

```sh
Your@Shell: ~/0x04/2-divide_lists$ ls
2-main.cs  2-divide_lists.cs  2-divide_lists.csproj  bin  obj
Your@Shell: ~/0x04/2-divide_lists$ dotnet run
Cannot divide by zero
Out of range
1
0
8
5
```
</details>

#### 3. Throw exception
Write a function that throws an `Exception`.
- Class Name: `Except`
- Prototype: `public static void Throw()`

<details>
<summary>Example:</summary>

```sh
Your@Shell: ~/0x04/3-throw_exception$ ls
3-main.cs  3-throw_exception.cs  3-throw_exception.csproj  bin  obj
Your@Shell: ~/0x04/3-throw_exception$ dotnet run
Exception raised
```
</details>

#### 4. Throw exception with message
Write a method that throws an `Exception` with a message.
- Class Name: `Except`
- Prototype: `public static void ThrowMsg(string msg)`

<details>
<summary>Example:</summary>

```sh
Your@Shell: ~/0x04/4-throw_exception_msg$ ls
4-main.cs  4-throw_exception_msg.cs  4-throw_exception_msg.csproj  bin  obj
Your@Shell: ~/0x04/4-throw_exception_msg$ dotnet run
C is fun
```
</details>


## Author :bust_in_silhouette:
- [Adrian Vides] | [Twitter] | [GitHub]


---

[GitHub]: <https://github.com/AdrianVides56>
[Twitter]: <https://twitter.com/termi56661>
[Adrian Vides]: <https://www.linkedin.com/in/adrianvides56/>    
