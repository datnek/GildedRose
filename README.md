# Presentation

**Gilded Rose Requirements Specification**


Hi and welcome to team Gilded Rose. As you know, we are a small inn with a prime location in a
prominent city ran by a friendly innkeeper named Allison. We also buy and sell only the finest goods.
Unfortunately, our goods are constantly degrading in quality as they approach their sell by date. We
have a system in place that updates our inventory for us. It was developed by a no-nonsense type named
Leeroy, who has moved on to new adventures. Your task is to add the new feature to our system so that
we can begin selling a new category of items. First an introduction to our system:

	- All items have a SellIn value which denotes the number of days we have to sell the item
	- All items have a Quality value which denotes how valuable the item is
	- At the end of each day our system lowers both values for every item

Pretty simple, right? Well this is where it gets interesting:

	- Once the sell by date has passed, Quality degrades twice as fast
	- The Quality of an item is never negative
	- "Aged Brie" actually increases in Quality the older it gets
	- The Quality of an item is never more than 50
	- "Sulfuras", being a legendary item, never has to be sold or decreases in Quality
	- "Backstage passes", like aged brie, increases in Quality as its SellIn value approaches;
	Quality increases by 2 when there are 10 days or less and by 3 when there are 5 days or less but
	Quality drops to 0 after the concert

We have recently signed a supplier of conjured items. This requires an update to our system:

	- "Conjured" items degrade in Quality twice as fast as normal items

Feel free to make any changes to the UpdateQuality method and add any new code as long as everything
still works correctly. However, do not alter the Item class or Items property as those belong to the
goblin in the corner who will insta-rage and one-shot you as he doesn't believe in shared code
ownership (you can make the UpdateQuality method and Items property static if you like, we'll cover
for you).

Just for clarification, an item can never have its Quality increase above 50, however "Sulfuras" is a
legendary item and as such its Quality is 80 and it never alters.


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
	
~~~~
- Dependencies: which contains the dependencies or libraries for the good functioning of the project
- Services: Contains the operations necessary for solving the problem
- Models: Contain the Item
- Csharpcore.Test: Contain all tests
- Utils: Contain the constants
- .gitignore: private file to git
- program.cs: Contain the main function
- README.md: Contain instructions 
~~~~

# Achitecture
Here is an abstract architecture of the project


![Wemanity-test-achitecture.jpg](/.attachments/Wemanity-test-achitecture-53685420-1df1-4603-9069-a3e31cfa0cb0.jpg)


#Features model
*To show the link with dev, just click to item*

#4
- #65
- #69
- #70
- #71
- #72
- #74

#1
- #66
- #67
- #68

#3
- #10
- #23
- #43
- #50
- #60

#2
- #8
- #9
- #11
- #20
- #26
- #40
- #41
- #47
- #48
- #54
- #55
- #73

#Continious Intégration  result

https://dev.azure.com/WemanityTest/GildedRose/_build/results?buildId=30&view=logs&j=12f1170f-54f2-53f3-20dd-22fc7dff55f9
