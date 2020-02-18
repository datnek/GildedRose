# Presentation
Hi and welcome to team Gilded Rose. As you know, we are a small inn with a prime location in a
prominent city ran by a friendly innkeeper named Allison. We also buy and sell only the finest goods.
Unfortunately, our goods are constantly degrading in quality as they approach their sell by date. We
have a system in place that updates our inventory for us. It was developed by a no-nonsense type named
Leeroy, who has moved on to new adventures. Your task is to add the new feature to our system so that
we can begin selling a new category of items. First an introduction to our system

# Integration
To compile and run the application,
- Cloner the projet, use command
 ```diff
+  "git clone https://WemanityTest@dev.azure.com/WemanityTest/GildedRose/_git/GildedRose" 
``` 
- open console
- Place yourself at the root of the project
- To restore all .net core dependancies, run this command in the console
 ```diff
+  "donet restore" 
``` 
- To restore build project, run this command in the console
 ```diff
+  "donet build" 
``` 
- To show the result, run this command in the console
 ```diff
+  "donet run" 
``` 
- To show the  unit test, run this command in the console
 ```diff
+  "donet test" 
``` 

# Solution 
This application use scrum and devops. 
You can see the tasks related to development via this link
### https://dev.azure.com/WemanityTest/GildedRose/_boards/board/t/GildedRose%20Team/Features

## Structure:
- Dependencies: which contains the dependencies or libraries for the good functioning of the project
- Services: Contains the operations necessary for solving the problem
- Models: Contain the Item
- Csharpcore.Test: Contain all tests
- Utils: Contain the constants
- .gitignore: private file to git
- program.cs: Contain the main function
- README.md: Contain instructions 




