# Text Line Comparison
This is a line comparison program that checks each line of one text file to find out if they appear in any line of another text file.

## General Information
This program checks each line of an input text file to find out if they can be found as substrings in any line of another input text file. The lines of the first file that cannot be found in any line of the second file are listed and saved in a new text file.

There are 2 different input files given:
1. **checklist.txt**: When this file is given as the first input, each line of this file is checked if they appear in any line of the second input file.
2. **mainlist.txt**: When this file is given as the second input, each line of this file is searched for containing any line from the first input file. 
* **checklist_.txt**: This file will be created after running the program to show which lines from the **checklist.txt** file could not be found in any line of the **mainlist.txt** file.

## Technologies
This project is created with:
* Microsoft Visual Studio
  * C# Console Application

## Setup & Run
To run this project, open the **CompareTextfiles.sln** solution file with Visual Studio, then build and run this solution, or use C# compiler to directly compile the **Program.cs** file and run the created executable (.exe) file:
```
csc Program.cs
```
The input files related to this program are given in both the root directory and the execution working directory of this solution: **.../bin/Debug/net6.0/**
