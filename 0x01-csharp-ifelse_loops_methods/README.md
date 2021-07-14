# 0x01-csharp-ifelse_loops_methods

---

## Description :newspaper:
This project was created with learning purposes at Holberton School; on `Ubuntu 14.04` `.NET Core 2.1 LTS SDK`; and is about Conditionas, iterations & loops, and function in C#.

---

 <p align="center">
<img height="250" src="https://mymasterdesigner.com/wp-content/uploads/2021/04/C-For-Beginner-Tutorial-Loop-Part.jpeg">
</p>



### Learning Objectives

- [x] How to use if, else if, else statements
- [x] How to use while and for loops
- [x] What is .NET?
- [x] How to use break and continue statements
- [x] How to use numeric format strings
- [x] How to declare methods within a class
- [x] How to call public methods from another class
- [x] What is passing by reference and passing by value

---

### Resources :blue_book: :orange_book: :green_book:
Read or watch:
- [If-Else (C# reference)](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if-else)

- [Methods (C# Programming Guide)](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods)

- [Iteration statements (C# reference)](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements)

- [Standard numeric format strings](https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings)

- [C# Coding Conventions](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)

---

### Tasks :white_check_mark:

#### 0. Positive anything is better than negative nothing
This program will assign a random signed number to the variable `number` each time it is executed. Complete the source code in order to print whether the number stored in the variable `number` is positive or negative.
- The variable `number` will store a different value every time you will run this program
- The output of the program should be:
    - The number, followed by
        - if the number is greater than 0: `is positive`
        - if the number is 0: `is zero`
        - if the number is less than 0: `is negative`
    - followed by a new line

<details>
<summary>Example:</summary>

```sh
Your@Shell$ ~/0x01/0-positive_or_negative$ ls
0-positive_or_negative.cs  0-positive_or_negative.csproj  bin  obj
Your@Shell$ ~/0x01/0-positive_or_negative$ dotnet run
3 is positive
Your@Shell$ ~/0x01/0-positive_or_negative$ dotnet run
6 is positive
Your@Shell$ ~/0x01/0-positive_or_negative$ dotnet run
-1 is negative
Your@Shell$ ~/0x01/0-positive_or_negative$ dotnet run
-7 is negative
Your@Shell$ ~/0x01/0-positive_or_negative$ dotnet run
0 is zero
```
</details>

#### 1. The last digit
This program will assign a random signed number to the variable `number` each time it is executed. Complete the source code in order to print whether the number stored in the variable `number` is positive or negative.
- The variable `number` will store a different value every time you will run this program
- The output of the program should be:
    - The string `The last digit of`, followed by
    - the `number`, followed by
    - the string `is`, followed by
        - if the last digit is greater than 5: the digit `and is greater than 5`
        - if the last digit is 0: the digit `and is 0`
        - if the last digit is less than 6 and not 0: the digit `and is less than 6 and not 0`
    - followed by a new line

<details>
<summary>Example:</summary>

```sh
Your@Shell$ ~/0x01/1-last_digit$ ls
1-last_digit.cs  1-last_digit.csproj  bin  obj
Your@Shell$ ~/0x01/1-last_digit$ dotnet run
The last digit of 8903 is 3 and is less than 6 and not 0
Your@Shell$ ~/0x01/1-last_digit$ dotnet run
The last digit of -6117 is -7 and is less than 6 and not 0
Your@Shell$ ~/0x01/1-last_digit$ dotnet run
The last digit of 2790 is 0 and is 0
Your@Shell$ ~/0x01/1-last_digit$ dotnet run
The last digit of 7363 is 3 and is less than 6 and not 0
Your@Shell$ ~/0x01/1-last_digit$ dotnet run
The last digit of 7590 is 0 and is 0
Your@Shell$ ~/0x01/1-last_digit$ dotnet run
The last digit of -3435 is -5 and is less than 6 and not 0
Your@Shell$ ~/0x01/1-last_digit$ dotnet run
The last digit of 6661 is 1 and is less than 6 and not 0
Your@Shell$ ~/0x01/1-last_digit$ dotnet run
The last digit of -365 is -5 and is less than 6 and not 0
Your@Shell$ ~/0x01/1-last_digit$ dotnet run
The last digit of 619 is 9 and is greater than 5
```
</details>

#### 2. I sometimes suffer from insomnia. And when I can't fall asleep, I play what I call the alphabet game
Write a program that prints the alphabet, in lowercase, not followed by a new line.
- You can only use `Console.Write` once
- You can only use one loop in your code

<details>
<summary>Example:</summary>

```sh
Your@Shell$ 0x01/2-print_alphabet$ ls
2-print_alphabet.cs  2-print_alphabet.csproj  bin  obj
Your@Shell$ 0x01/2-print_alphabet$ dotnet run
abcdefghijklmnopqrstuvwxyzYour@Shell$ 0x01/2-print_alphabet$ 
```
</details>

#### 3. When I was having that alphabet soup, I never thought that it would pay off
Write a program that prints the alphabet, in lowercase, not followed by a new line.
- Print all the letters except `q` and `e`
- You can only use `Console.Write` once
- You can only use one loop in your code

<details>
<summary>Example:</summary>

```sh
Your@Shell$ 0x01/3-print_alphabt$ ls
3-print_alphabt.cs  3-print_alphabt.csproj  bin  obj
Your@Shell$ 0x01/3-print_alphabt$ dotnet run
abcdfghijklmnoprstuvwxyzYour@Shell$ 0x01/3-print_alphabt$ 
```
</details>

#### 4. Hexadecimal printing
Write a program that prints all numbers from 0 to 98 in decimal and in hexadecimal (as in the following example)
- You can only use `Console.Write` once
- You can only use one loop in your code

<details>
<summary>Example:</summary>

```sh
Your@Shell$ 0x01/4-print_hexa$ ls
4-print_hexa.cs  4-print_hexa.csproj  bin  obj
Your@Shell$ 0x01/4-print_hexa$ dotnet run
0 = 0x0
1 = 0x1
2 = 0x2
3 = 0x3
...
10 = 0xa
11 = 0xb
12 = 0xc
13 = 0xd
...
96 = 0x60
97 = 0x61
98 = 0x62
```
</details>

#### 5. 00...99
Write a program that prints numbers from `0` to `99`.
- Numbers must be separated by `,`, followed by a space
- Numbers should be printed in ascending order, with two digits
- The last number should be followed by a new line
- You can only use `Console.Write` no more than twice
- You can only use one loop in your code

<details>
<summary>Example:</summary>

```sh
Your@Shell$ 0x01/5-print_comb$ ls
5-print_comb.cs  5-print_comb.csproj  bin  obj
Your@Shell$ 0x01/5-print_comb$ dotnet run
00, 01, 02, 03, 04, 05, 06, 07, 08, 09, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99
```
</details>

#### 6. Inventing is a combination of brains and materials. The more brains you use, the less material you need
Write a program that prints all possible different combinations of two digits.
- Numbers must be separated by `,`, followed by a space
- The two digits must be different
- 01 and 10 are considered the same combination of the two digits 0 and 1
- Print only the smallest combination of two digits
- Numbers should be printed in ascending order, with two digits
- The last number should be followed by a new line
- You can only use `Console.Write` and `Console.WriteLine` no more than three times total
- You can only use no more than 2 loops in your code

<details>
<summary>Example:</summary>

```sh
Your@Shell$ 0x01/6-print_comb2$ ls
6-print_comb2.cs  6-print_comb2.csproj  bin  obj
Your@Shell$ 0x01/6-print_comb2$ dotnet run
01, 02, 03, 04, 05, 06, 07, 08, 09, 12, 13, 14, 15, 16, 17, 18, 19, 23, 24, 25, 26, 27, 28, 29, 34, 35, 36, 37, 38, 39, 45, 46, 47, 48, 49, 56, 57, 58, 59, 67, 68, 69, 78, 79, 89
```
</details>

#### 7. islower
Write a method that checks for lowercase character.
- Class Name: `class Character`
- Prototype: `public static bool IsLower(char c)`
- Returns `True` if `c` is lowercase
- Returns `False` otherwise
- You are not allowed to use `Char.IsLower()` or `Char.IsUpper()`

<details>
<summary>Example:</summary>

```sh
Your@Shell$ ~/0x01/7-islower$ ls
7-islower.cs  7-islower.csproj  7-main.cs  bin  obj
Your@Shell$ ~/0x01/7-islower$ dotnet run
a is lowercase
A is uppercase
Q is uppercase
h is lowercase
9 is uppercase
B is uppercase
g is lowercase
```
</details>

#### 8. There are only 3 colors, 10 digits, and 7 notes; its what we do with them that's important
Write a method that prints the last digit of a number.
- Class Name: `class Number`
- Prototype: `public static int PrintLastDigit(int number)`
- Returns the value of the last digit

<details>
<summary>Example:</summary>

```sh
Your@Shell$ 0x01/8-print_last_digit$ ls
8-main.cs  8-print_last_digit.cs  8-print_last_digit.csproj  bin  obj
Your@Shell$ 0x01/8-print_last_digit$ dotnet run
8044
```
</details>

#### 9. a + b
Write a method that adds two integers and returns the result.
- Class Name: `class Number`
- Prototype: `public static int Add(int a, int b)`
- Returns the value of a + b

<details>
<summary>Example:</summary>

```sh
Your@Shell$ 0x01/9-add$ ls
9-add.cs  9-add.csproj  9-main.cs  bin  obj
Your@Shell$ 0x01/9-add$ dotnet run
3
98
98
```
</details>

#### 10. The shortest distance between two points is a straight line
Write a method that draws a straight line in the terminal.
- Class Name: `class Line`
- Prototype: `public static void PrintLine(int length)`
- Where `length` is the number of times the character _ should be printed
- The line should end with a new line
- If `length` is `0` or less, the function should only print a new line

<details>
<summary>Example:</summary>

```sh
Your@Shell$ 0x01/10-print_line$ 
Your@Shell$ 0x01/10-print_line$ ls
10-main.cs  10-print_line.cs  10-print_line.csproj  bin  obj
Your@Shell$ 0x01/10-print_line$ dotnet run | cat -e
___$
$
____________$
$
```
</details>

#### 11. I feel like I am diagonally parked in a parallel universe
Write a method that draws a diagonal line in the terminal.
- Class Name: `class Line`
- Prototype: `public static void PrintDiagonal(int length)`
- Where `length` is the number of times the character `\` should be printed
- The line should end with a new line
- If `length` is `0` or less, the function should only print a new line

<details>
<summary>Example:</summary>

```sh
Your@Shell$ 0x01/11-print_diagonal$ ls
11-main.cs  11-print_diagonal.cs  11-print_diagonal.csproj  bin  obj
Your@Shell$ 0x01/11-print_diagonal$ dotnet run | cat -e
\$
 \$
  \$
$
$
\$
 \$
  \$
   \$
    \$
     \$
      \$
       \$
        \$
         \$
          \$
           \$
$
$
```
</details>

#### 12. Fizz Buzz
Write a program that prints the numbers from 1 to 100 separated by a space.
- For multiples of three print `Fizz` instead of the number and for multiples of five print `Buzz`.
- For numbers which are multiples of both three and five print `FizzBuzz`.
- Each element should be followed by a space
- The last element should be followed by a new line

<details>
<summary>Example:</summary>

```sh
Your@Shell$ 0x01/12-fizzbuzz$ ls
12-fizzbuzz.cs  12-fizzbuzz.csproj  bin  obj
Your@Shell$ 0x01/12-fizzbuzz$ dotnet run | cat -e
1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz Fizz 22 23 Fizz Buzz 26 Fizz 28 29 FizzBuzz 31 32 Fizz 34 Buzz Fizz 37 38 Fizz Buzz 41 Fizz 43 44 FizzBuzz 46 47 Fizz 49 Buzz Fizz 52 53 Fizz Buzz 56 Fizz 58 59 FizzBuzz 61 62 Fizz 64 Buzz Fizz 67 68 Fizz Buzz 71 Fizz 73 74 FizzBuzz 76 77 Fizz 79 Buzz Fizz 82 83 Fizz Buzz 86 Fizz 88 89 FizzBuzz 91 92 Fizz 94 Buzz Fizz 97 98 Fizz Buzz$
```
</details>

---

## Author :bust_in_silhouette:
- [Adrian Vides] | [Twitter] | [GitHub]


---

[GitHub]: <https://github.com/AdrianVides56>
[Twitter]: <https://twitter.com/termi56661>
[Adrian Vides]: <https://www.linkedin.com/in/adrianvides56/>    
