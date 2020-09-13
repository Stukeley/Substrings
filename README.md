# Substrings
A Fiverr order made on 13.09

## Specification

**Create a console application that takes a text string (argument) as an argument.**  
The text string should then be searched for all substrings that are numbers that begin and ends in the same digit, without the start / end digit, or any other character other than numbers occur in between.
ex. 3463 is a correct such number, but 34363 it is not because it exists another 3rd in the number, in addition to the start and final figure. Strings with letters in, eg 95a9 is also not a correct number.

**Print and select each correct substring.**  
For each such substring that matches the above criterion, the program shall print one row with the entire string, but where the sub-string is highlighted in a different color.  
You can choose which colors you print with as long as you see a difference between them. You changes color by changing the value of Console.ForegroundColor.

**Add up all the numbers and print the totals.**  
The program should also add together all the numbers it found as above and print it.  
last in the program. Feel free to make an empty line in between to distinguish from the output above.  
Example output for input "29535123p48723487597645723645":  
Total = 5836428677242  

**Console application on .NET Framework 4.8**
