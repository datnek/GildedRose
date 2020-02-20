# Presentation
Gilded Rose is a product management 
application for a restaurant developed in C #

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

# Achitecture
Here is an abstract architecture of the project

![Wemanity-test-achitecture.jpg](/.attachments/Wemanity-test-achitecture-5af33d7c-ad63-4aa6-98f9-0a7ccb6bae88.jpg)


