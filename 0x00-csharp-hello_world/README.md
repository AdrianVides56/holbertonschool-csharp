# 0x00-csharp-hello_world
---

## Description :newspaper:
This project was created with learning purposes at Holberton School; on `Ubuntu 14.04` `.NET Core 2.1 LTS SDK`; and is an introduction to C#.

---

C# (pronounced "See Sharp") is a modern, object-oriented, and type-safe programming language. C# enables developers to build many types of secure and robust applications that run in the .NET ecosystem.
- Fun Fact: C# was Inspired from musical notation where a sharp indicates that the written note should be made a half-step higher in pitch (`c++++`)

<p align="center">
<img height="300" src="https://seeklogo.com/images/C/c-sharp-c-logo-02F17714BA-seeklogo.com.png">
</p>

### Learning Objectives

- [x] What is the meaning behind the name C#?
- [x] Who is the lead architect of the development team of C#?
- [x] What is .NET?
- [x] What is the difference between C# and .NET?
- [x] How to use VSCode and the integrated terminal to initialize, build, and run C# projects
- [x] How to print text and variables using Console.Write

---

### Resources :blue_book: :orange_book: :green_book:
Read or watch:
- [Introduction to C#](https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/)
- [C# documentation](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [Strings (C# Programming Guide)](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/)
- [C# and VSCode](https://docs.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code)
- [Console.WriteLine Method](https://docs.microsoft.com/en-us/dotnet/api/system.console.writeline?view=netframework-4.8)
- [C# Coding Conventions](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)

---

### Tasks :white_check_mark:

#### 0. Initialize new project
Write a Bash script that initializes a new C# project inside a folder titled `0-new_project`.
- Use the command `dotnet`

#### 1. Build new project
Write a Bash script that initializes and builds a new C# project inside a folder titled `1-new_project`.
- Use the command `dotnet`

#### 2. Run new project
Write a Bash script that initializes, builds, and runs a new C# project from a folder titled `2-new_project`.
- Use the command `dotnet`

#### 3. Hello, WriteLine
Write a C# script that prints exactly `"Programming is like building a multilingual puzzle` followed by a new line.
- Use the method `Console.WriteLine`

<details>
<summary>Example:</summary>

```sh
Your@Shell$ ~/0x00-csharp-hello_world/3-writeline$ ls
3-writeline.csproj  bin  obj  3-writeline.cs
Your@Shell$ ~/0x00-csharp-hello_world/3-writeline$ dotnet run
"Programming is like building a multilingual puzzle
Your@Shell$ ~/0x00-csharp-hello_world/3-writeline$ 
```
</details>

#### 4. Print integer
Complete this [source code](https://github.com/holbertonschool/0x00.cs/blob/master/4-print_integer.cs) in order to print the integer stored in the variable `number`, followed by `Mission Street` followed by a new line.
- Your code should be exactly 10 lines long
- The output of the script should be:
    - the number, followed by `Mission Street`
    - followed by a new line

<details>
<summary>Example:</summary>

```sh
Your@Shell$ ~/0x00-csharp-hello_world/4-print_integer$  ls
4-print_integer.cs  4-print_integer.csproj  bin  obj
Your@Shell$ ~/0x00-csharp-hello_world/4-print_integer$ dotnet run
972 Mission Street
```
</details>

#### 5. Print float
Complete this [source code](https://github.com/holbertonschool/0x00.cs/blob/master/5-print_float.cs) in order to print the float stored in the variable `number` with a precision of 2 digits.
- Your script should be exactly 10 lines long
- The output of the script should be:
    - `Float:` followed by the number with only 2 digits
    - followed by a new line

<details>
<summary>Example:</summary>

```sh
Your@Shell$ ~/0x00-csharp-hello_world/5-print_float$ ls
5-print_float.cs  5-print_float.csproj  bin  obj
Your@Shell$ ~/0x00-csharp-hello_world/5-print_float$ dotnet run
Float: 3.14
```
</details>

#### 6. Print string
mandatory
Complete this [source code](https://github.com/holbertonschool/0x00.cs/blob/master/6-print_string.cs) in order to print a string stored in the variable `str` 3 times, followed by its first 9 characters.
- The output of the script should be:
    - the value of `str` 3 times
    - followed by a new line
    - followed by the first 9 characters of `str`
    - followed by a new line
- You are not allowed to use any loops or conditional statement

<details>
<summary>Example:</summary>

```sh
Your@Shell$ ~/0x00-csharp-hello_world/6-print_string$ ls
6-print_string.cs  6-print_string.csproj  bin  obj
Your@Shell$ ~/0x00-csharp-hello_world/6-print_string$ dotnet run
Holberton SchoolHolberton SchoolHolberton School
Holberton
```
</details>

#### 7. Play with strings
Complete this [source code](https://github.com/holbertonschool/0x00.cs/blob/master/7-concat.cs) to print `Welcome to Holberton School!`
- Your code should be exactly 12 lines long
- You are not allowed to use any loops or conditional statement
- You have to use the variables `str1` and `str2` in your new line of code

#### 8. Print variables
Complete this [source code](https://github.com/holbertonschool/0x00.cs/blob/master/8-print_variable.cs) in order to print the given variables as `972 Mission Street`.
- Your code should be exactly 12 lines long
- You are not allowed to create new variables
- You are not allowed to edit existing variables
- The output of the script should be:
    - `972 Mission Street`
    - followed by a new line

<details>
<summary>Example:</summary>

```sh
Your@Shell$ ~/0x00-csharp-hello_world/8-print_variables$ ls
8-print_variables.cs  8-print_variables.csproj  bin  obj
Your@Shell$ ~/0x00-csharp-hello_world/8-print_variables$ dotnet run
972 Mission Street
```
</details>

#### 9. Print specifiers
Complete this [source code](https://github.com/holbertonschool/0x00.cs/blob/master/9-print_specifiers.cs) in order to print the given variables as in the result shown.
- Your code should be no more than 12 lines long
- You are not allowed to create new variables
- The target locale is `en-US.utf-8`
- The output of the script should be:
    - `Percent: 75.53%`
    - followed by a new line
    - followed by `Currency: $98,765.43`
    - followed by a new line

<details>
<summary>Example:</summary>

```sh
Your@Shell$ ~/0x00-csharp-hello_world/9-print_specifiers$ ls
9-print_specifiers.cs  9-print_specifiers.csproj  bin  obj
Your@Shell$ ~/0x00-csharp-hello_world/9-print_specifiers$ dotnet run
Percent: 75.53%
Currency: $98,765.43
```
</details>

#### 10. Copy - Cut - Paste
Complete this [source code](https://github.com/holbertonschool/0x00.cs/blob/master/10-copy_cut_paste.cs).
- Your code should be exactly 15 lines long
- You are not allowed to use any loops or conditional statements
- `word_first_3` should contain the first 3 letters of the variable `word`
- `word_last_2` should contain the last 2 letters of the variable `word`
- `middle_word` should contain the value of the variable `word` without the first and last letters

<details>
<summary>Example:</summary>

```sh
10-copy_cut_paste.cs  10-copy_cut_paste.csproj  bin  obj
Your@Shell$ ~/0x00-csharp-hello_world/10-copy_cut_paste$ dotnet run
First 3 letters: Hol
Last 2 letters: on
Middle word: olberto
```
</details>

#### 11. Create a new sentence
Complete this [source code](https://github.com/holbertonschool/0x00.cs/blob/master/11-concat_edges.cs) to print `object-oriented programming in C#` followed by a new line.
- Your code should be exactly 11 lines long
- You are not allowed to use any loops or conditional statements
- You are not allowed to create new variables
- You are not allowed to use string literals

<details>
<summary>Example:</summary>

```sh
Your@Shell$ ~/0x00-csharp-hello_world/11-concat_edges$ ls
11-concat_edges.cs  11-concat_edges.csproj  bin  obj
Your@Shell$ ~/0x00-csharp-hello_world/11-concat_edges$ dotnet run
object-oriented programming in C#
```
</details>


### Advanced Tasks :100: :ballot_box_with_check:

#### 12. Object
Write a C# script that prints exactly `and that piece of art is useful - Dora Korpar, 2015-10-19` followed by a new line.
- Your script should print to `stderr`
- Your script should exit with the status code `1`

<details>
<summary>Example:</summary>

```sh
Your@Shell$ ~/0x00-csharp-hello_world/100-hello_error$ ls
100-hello_error.cs  100-hello_error.csproj  obj
Your@Shell$ ~/0x00-csharp-hello_world/100-hello_error$ dotnet run
and that piece of art is useful - Dora Korpar, 2015-10-19
Your@Shell$ ~/0x00-csharp-hello_world/100-hello_error$ echo $?
1
Your@Shell$ ~/0x00-csharp-hello_world/100-hello_error$ dotnet run 2> q
Your@Shell$ ~/0x00-csharp-hello_world/100-hello_error$ cat q
and that piece of art is useful - Dora Korpar, 2015-10-19
```
</details>

---

## Author :bust_in_silhouette:
- [Adrian Vides] | [Twitter] | [GitHub]


---

[GitHub]: <https://github.com/AdrianVides56>
[Twitter]: <https://twitter.com/termi56661>
[Adrian Vides]: <https://www.linkedin.com/in/adrianvides56/>    
