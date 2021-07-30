# 0x05. C# - Structs, Enumerations

---

## Description :newspaper:
This project was created with learning purposes at Holberton School; on `Ubuntu 14.04` `.NET Core 2.1 LTS SDK`; and is about Structures in C#.

---

 <p align="center">
<img height="200" src="https://askatul.com/wp-content/uploads/2020/09/C-Struct-1.png">
</p>



### Learning Objectives

- [x] What is a struct
- [x] What is a constructor
- [x] What is a field
- [x] What is a property
- [x] What is an enumeration and when to use them
- [x] What does `toString` do and how to override it

---

### Resources :blue_book: :orange_book: :green_book:
Read or watch:
- [Structure types (C# reference)](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/struct)

- [Enumeration types (C# reference)](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum)

- [Object.ToString Method](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring?view=netframework-4.7.2)

- [Object oriented programming](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/)


---

### Tasks :white_check_mark:

#### 0. They're good dogs
Define a new enum `Rating` with the values `Good`, `Great`, `Excellent`.

<details>
<summary>Example:</summary>

```sh
Your@Shell:~/0x05-csharp-structs_enums\0-dog$ ls
bin    obj    0-dog.cs    0-dog.csproj    0-main.cs
Your@Shell:~/0x05-csharp-structs_enums\0-dog$ dotnet run
Score: Great
Score: 1
```
</details>

#### 1. Chief Puppy Officer
Based on `0-dog`, define a new struct `Dog` with the following members:
- `name`, type: public string
- `age`, type: `public float`
- `owner`, type: `public string`
- `rating`, type `public Rating`

<details>
<summary>Example:</summary>

```sh
Your@Shell:~/0x05-csharp-structs_enums\1-dog$ ls
bin    obj    1-dog.cs    1-dog.csproj    1-main.cs
Your@Shell:~/0x05-csharp-structs_enums\1-dog$ dotnet run
My name is Poppy and I am 0.7. I am an Excellent dog. :)
```
</details>

#### 2. A dog is the only thing on earth that loves you more than you love yourself
Based on `1-dog`, add a constructor to struct `Dog` that takes parameters.

<details>
<summary>Example:</summary>

```sh
Your@Shell:~/0x05-csharp-structs_enums\2-dog$ ls
bin    obj    2-dog.cs    2-dog.csproj    2-main.cs
Your@Shell:~/0x05-csharp-structs_enums\2-dog$ dotnet run
My name is Poppy and I am 0.7. I am an Excellent dog. :)
```
</details>

#### 3. A dog will teach you unconditional love. If you can have that in your life, things won't be too bad
Based on `2-dog`, override the `.ToString()` method to print the Dog object’s attributes to stdout.

Format:
```sh
Dog Name: <name>
Age: <age>
Owner: <owner>
Rating: <rating>
```

<details>
<summary>Example:</summary>

```sh
Your@Shell:~/0x05-csharp-structs_enums\3-dog$ ls
bin    obj    3-dog.cs    3-dog.csproj    3-main.cs
Your@Shell:~/0x05-csharp-structs_enums\3-dog$ dotnet run
Dog Name: Poppy
Age: 0.7
Owner: Kris
Rating: Excellent
```
</details>

---

## Author :bust_in_silhouette:
- [Adrian Vides] | [Twitter] | [GitHub]


---

[GitHub]: <https://github.com/AdrianVides56>
[Twitter]: <https://twitter.com/termi56661>
[Adrian Vides]: <https://www.linkedin.com/in/adrianvides56/>    
