#!/usr/bin/env bash
# initializes a new C# project inside a folder titled 2-new_project
dotnet new console -o 2-new_project
cd 2-new_project
dotnet build
dotnet run
