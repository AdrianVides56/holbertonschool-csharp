# 0x02. C# - Data Structures: Arrays, Lists, Dictionaries

---

## Description :newspaper:
This project was created with learning purposes at Holberton School; on `Ubuntu 14.04` `.NET Core 2.1 LTS SDK`; and is about Arrays, Lists and Dictionaries in C#.

---

 <p align="center">
<img height="250" src="https://www.educative.io/cdn-cgi/image/f=auto,fit=cover,w=600/v2api/collection/10370001/6110546783895552/image/4818184752857088">
</p>



### Learning Objectives

- [x] How to create and use arrays
- [x] What are Collections in C#
- [x] How to create and use lists
- [x] What is the difference between arrays and lists in C#
- [x] When would you use an array vs a list
- [x] How to create and use dictionaries
- [x] What is the difference between dictionary and hashtables in C#
- [x] How to use `foreach`

---

### Resources :blue_book: :orange_book: :green_book:
Read or watch:
- [Arrays (C# Programming Guide)](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/)

- [How to program in C# - Arrays](https://www.youtube.com/watch?v=RQ0JHMGiobo)

- [Collections (C#)](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/collections)

- [List<T> Class](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netcore-2.0)

- [Dictionary<TKey,TValue> Class](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=netcore-2.0)

- [C# Dictionaries](http://csharp.net-informations.com/collection/dictionary.htm)

- [The foreach statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement)

- [C# Coding Conventions](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)

---

### Tasks :white_check_mark:

#### 0. Print an array of integers
Write a method that creates and prints an array of integers of a given size.
- Class Name: `Array`
- Prototype: `public static int[] CreatePrint(int size)`
- Returns the new array
- The integers in the array should start with `0` and increment by one until the given size is met (see output below)
- If `size` is `0`, print a blank line
- If `size` is less than `0`, print `Size cannot be negative` and return `null`

<details>
<summary>Example:</summary>

```sh
Your@Shell:~/0x02/0-print_array$ ls
0-main.cs  0-print_array.cs  0-print_array.csproj  bin  obj
Your@Shell:~/0x02/0-print_array$ dotnet run | cat -e
0 1 2 3 4 5 6 7 8 9$
Array Length: 10$
----------------$
0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15$
Array Length: 16$
----------------$
$
Array Length: 0$
----------------$
Size cannot be negative
```
</details>

#### 1. Access an element in an array
Write a method that retrieves an element from an array.
- Class Name: `Array`
- Prototype: `public static int elementAt(int[] array, int index)`
- Returns the element at the given index
- If `index` is out of range, print `Index out of range` and return -`1`

<details>
<summary>Example:</summary>

```sh
Element at index 4 is -12
Element at index 9 is -9
Element at index 0 is 10
Index out of range
```
</details>

#### 2. Replace element
Write a method that replaces an element of an array at a given index.
- Class Name: `Array`
- Prototype: `public static int[] ReplaceElement(int[] array, int index, int n)`
- Returns the updated array
- If `index` is out of range, print `Index out of range` and return the unchanged array

<details>
<summary>Example:</summary>

```sh
Your@Shell:~/0x02/2-replace_element$ ls
2-main.cs             2-replace_element.csproj  obj
2-replace_element.cs  bin
Your@Shell:~/0x02/2-replace_element$ dotnet run
0 1 2 3 4 5 6
0 98 2 3 4 5 6
```
</details>

#### 3. Print an array of integers... in reverse!
Write a method that prints all integers of an array, in reverse order.
- Class Name: `Array`
- Prototype: `public static void Reverse(int[] array)`

<details>
<summary>Example:</summary>

```sh
Your@Shell:~/0x02/3-print_array_reverse$ ls
3-main.cs                 3-print_array_reverse.csproj  obj
3-print_array_reverse.cs  bin
Your@Shell:~/0x02/3-print_array_reverse$ dotnet run | cat -e
9 8 7 6 5 4 3 2 1 0$
$
$
-42 972 0 -10 98$
```
</details>

#### 4. Print a list of integers
Write a method that creates and prints a list of integers of a given size.
- Class Name: `List`
- Prototype: `public static List<int> CreatePrint(int size)`
- The integers in the list should start with `0` and increment by one until the given `size` is met (see output below)
- Returns the newly created list
- If size is less than 0, print `Size cannot be negative` and return `null`

<details>
<summary>Example:</summary>

```sh
Your@Shell:~/0x02/4-print_list$ ls
4-main.cs  4-print_list.cs  4-print_list.csproj  bin  obj
Your@Shell:~/0x02/4-print_list$ dotnet run | cat -e
0 1 2 3 4 5 6 7 8 9$
List Length: 10$
----------------$
0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15$
List Length: 16$
----------------$
$
List Length: 0$
----------------$
0$
List Length: 1$
```
</details>

#### 5. Find the max
Write a method that finds the biggest integer of a list.

- Class Name: `List`
- Prototype: `public static int MaxInteger(List<int> myList)`
- Returns the largest element in a given list
- If list is empty, print `List is empty` and return -`1`
- You are not allowed to use LINQ or `.Max()`

<details>
<summary>Example:</summary>

```sh
5-main.cs  5-max_integer.cs  5-max_integer.csproj  bin  obj
Your@Shell:~/0x02/5-max_integer$ dotnet run
Max: 1024
Max: 972
```
</details>

#### 6. Only by 2
Write a method that finds all multiples of 2 in a list.
- Class Name: `List`
- Prototype: `public static List<bool> DivisibleBy2(List<int> myList)`
- Returns a new list containing `true` or `false`, depending on whether the integer at the same position in the original list is a multiple of 2
- The new list should have the same size as the original list

<details>
<summary>Example:</summary>

```sh
Your@Shell:~/0x02/6-divisible_by_2$ dotnet run
1 is not divisible by 2
2 is divisible by 2
3 is not divisible by 2
4 is divisible by 2
5 is not divisible by 2
6 is divisible by 2
```
</details>

#### 7. Delete at
Write a method that deletes the item at a specific position in a list.
- Class Name: `List`
- Prototype: `public static List<int> DeleteAt(List<int> myList, int index)`
- Returns the updated list
- If `index` is out of range, print `Index is out of range` and return the unchanged list
- You are not allowed to use `.RemoveAt()`


<details>
<summary>Example:</summary>

```sh
Your@Shell:~/0x02/7-delete_at$ ls
7-delete_at.cs  7-delete_at.csproj  7-main.cs  bin  obj
Your@Shell:~/0x02/7-delete_at$ dotnet run
1
2
3
4
5
----------
1
2
4
5
```
</details>

#### 8. Number of keys
Write a method that returns the number of keys in a dictionary.
- Class Name: `Dictionary`
- Prototype: `public static int NumberOfKeys(Dictionary<string, string> myDict)`
- Returns the number of keys in a dictionary
- You are not allowed to use `.Count()`

<details>
<summary>Example:</summary>

```sh
Your@Shell:~/0x02/8-number_keys$ ls
8-main.cs  8-number_keys.cs  8-number_keys.csproj  bin  obj
Your@Shell:~/0x02/8-number_keys$ dotnet run
Number of keys: 3
```
</details>

#### 9. Update dictionary
Write a method that adds a key and value to a dictionary.
- Class Name: `Dictionary`
- Prototype: `public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)`
- If a key exists in the dictionary, the value will be replaced
- If a key doesn’t exist in the dictionary, it will be created
- Returns the updated dictionary

<details>
<summary>Example:</summary>

```sh
Your@Shell:~/0x02/9-add_key_value$ ls
9-add_key_value.cs  9-add_key_value.csproj  9-main.cs  bin  obj
Your@Shell:~/0x02/9-add_key_value$ dotnet run
school: Holberton
------------------
school: Holberton
city: San Francisco
```
</details>

#### 10.  Delete from dictionary
Write a method that deletes a key in a dictionary
- Class Name: `Dictionary`
- Prototype: `public static Dictionary<string, string> DeleteKeyValue(Dictionary<string, string> myDict, string key)`
- Returns the updated dictionary

<details>
<summary>Example:</summary>

```sh
Your@Shell:~/0x02/10-delete_key_value$ ls
10-delete_key_value.cs  10-delete_key_value.csproj  10-main.cs  bin  obj
Your@Shell:~/0x02/10-delete_key_value$ dotnet run
language: C
track: low level
school: Holberton
address: 972 Mission St.
city: San Francisco
----------------
language: C
school: Holberton
address: 972 Mission St.
city: San Francisco
-----
language: C
school: Holberton
address: 972 Mission St.
city: San Francisco
```
</details>

#### 11. Multiply by 2
Write a method that returns a new dictionary with all values multiplied by 2.
- Class Name: `Dictionary`
- Prototype: `public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)`
- Returns the new dictionary

<details>
<summary>Example:</summary>

```sh
Your@Shell:~/0x02/11-multiply_by_2$ ls
11-main.cs           11-multiply_by_2.csproj  obj
11-multiply_by_2.cs  bin
Your@Shell:~/0x02/11-multiply_by_2$ dotnet run
John: 12
Alex: 8
Bob: 14
Mary: 14
Molly: 16
--------------------
John: 24
Alex: 16
Bob: 28
Mary: 28
Molly: 32
```
</details>

#### 12. Print sorted dictionary
Write a method that prints a dictionary by ordered keys.
- Class Name: `Dictionary`
- Prototype: `public static void PrintSorted(Dictionary<string, string> myDict)`
- You are not allowed to use `SortedDictionary`
- Output should be formatted as in the example below

<details>
<summary>Example:</summary>

```sh
Your@Shell:~/0x02/12-print_sorted_dictionary$ ls
12-main.cs                         bin
12-print_sorted_dictionary.cs      obj
12-print_sorted_dictionary.csproj
Your@Shell:~/0x02/12-print_sorted_dictionary$ dotnet run
address: 972 Mission St.
city: San Francisco
language: C
school: Holberton
track: low level
```
</details>

#### 13. Best score
Write a method that returns the key with the biggest integer value in a given dictionary.
- Class Name: `Dictionary`
- Prototype: `public static string BestScore(Dictionary<string, int> myList)`
- Returns the key with the biggest integer value
- You can assume that all values are non-negative integers
- You can assume that all students have a different score
- If no scores are found, return “None”

<details>
<summary>Example:</summary>

```sh
Your@Shell:~/0x02/13-best_score$ ls
13-best_score.cs  13-best_score.csproj  13-main.cs  bin  obj
Your@Shell:~/0x02/13-best_score$ dotnet run
Best Score: Molly
```
</details>

#### 14. Rectangular array
Write a program that creates and prints a 5 by 5 two-dimensional array and initialize index `[2,2]` to `1` and all other indices to `0`.

<details>
<summary>Example:</summary>

```sh
Your@Shell:~/0x02/14-rectangular_array$ ls
14-rectangular_array.cs  14-rectangular_array.csproj  bin  obj
Your@Shell:~/0x02/14-rectangular_array$ dotnet run | cat -e
0 0 0 0 0$
0 0 0 0 0$
0 0 1 0 0$
0 0 0 0 0$
0 0 0 0 0$
```
</details>

#### 15. Matrix squared
Write a method that computes the square value of all integers of a matrix.
- Class Name: `Matrix`
- Prototype: `public static int[,] Square(int[,] myMatrix)`
- Returns a new matrix containing the square value of all integers of the original matrix

<details>
<summary>Example:</summary>

```sh
Your@Shell:~/0x02/15-square_matrix$ ls
15-main.cs           15-square_matrix.csproj  obj
15-square_matrix.cs  bin
Your@Shell:~/0x02/15-square_matrix$ dotnet run
0 1 4
9 16 25
36 49 64
```
</details>

### Advanced Tasks :100: :ballot_box_with_check:

#### 16. Jagged array

Write a program that creates and prints a [jagged array](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/jagged-arrays) containing 3 arrays.
- The first array should contain `0, 1, 2, 3`
- The second array should contain `0, 1, 2, 3, 4, 5, 6`
- The third array should contain `0, 1`

<details>
<summary>Example:</summary>

```sh
Your@Shell:~/0x02/100-jagged_array$ ls
100-jagged_array.cs  100-jagged_array.csproj  bin  obj
Your@Shell:~/0x02/100-jagged_array$ dotnet run | cat -e
0 1 2 3$
0 1 2 3 4 5 6$
0 1$
```
</details>

---

## Author :bust_in_silhouette:
- [Adrian Vides] | [Twitter] | [GitHub]


---

[GitHub]: <https://github.com/AdrianVides56>
[Twitter]: <https://twitter.com/termi56661>
[Adrian Vides]: <https://www.linkedin.com/in/adrianvides56/>
