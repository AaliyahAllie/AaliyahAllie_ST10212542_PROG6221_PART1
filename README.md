Welcome to Recipe App
Tthis read me file will help you navigate how to run the program using visual studio 2022 and explain exactly how to get each step to run smoothly from beginning to end.

How to run the program
-Firstly open up the file in visual studio code
-When the file is open, in the ribbons click on build and the option rebuild solution
-When in the bottom corner it says rebuild successfully press the run button (a side ways triangle with the projects name)
-The program will now open

How the program works:
The recipe app works as a console app and is based off a 6 option numeric menu. It works by taking in user options and executing them. There are 6 options which all conduct different tasks. 
The 6 options are:
1.Enter new recipe
2.Display recipe
3.Scale recipe (0.5, 2, or 3)
4.Reset recipe to original values
5.Clear recipe data
6.Exit Program

How you as a user will use this program from start to end:
-The program starts with the following interface:
***********************************************
Welcome To Your Recipe Application
***********************************************
Please enter (1) to launch the menu

-You as a user must do what is instructed and press the key " 1 " to get the program to launch the menu (The 6 Options).
-if you as a user enters the wrong option i.e: " 2 " or " A " the program will display the following error message and not display the menu but rather the first display again
INVALID OPTION.ENTER (1) TO LAUNCH MENU
***********************************************
Welcome To Your Recipe Application
***********************************************
Please enter (1) to launch the menu

-This is what we as programmers call exception handling to ensure the correct procedure is used to run an application.
-Now if you as a user decide to now use the correct option and press they key " 1 " the menu will now launch and display the following:
***********************************************
PLEASE SELECT ONE OF THE NUMERIC OPTIONS BELOW
***********************************************
1.Enter new recipe
2.Display recipe
3.Scale recipe (0.5, 2, or 3)
4.Reset recipe to original values
5.Clear recipe data
6.Exit Program
***********************************************

These are what the following options will display:

-If you select option 1 : Enter new recipe by entering the key " 1 " , Option 1 works by taking users inputs and storing it into an array.
If you choose this the following will display:


Are you sure you want to enter a new recipe?(y/n)

-now you as a user must enter either the key " y " or the key " n "
-" y " proceeds with entering the recipe
-" n " cancels this option and goes back

-Now this is what happens when you press " n ":

Are you sure you want to enter a new recipe?(y/n)
n
Returning to the main menu.
***********************************************
Welcome To Your Recipe Application
***********************************************
Please enter (1) to launch the menu

-And this is what happens when you press " y : 

Are you sure you want to enter a new recipe?(y/n)
y
Now Capturing Recipe
***********************************************
ENTER NEW RECIPE DETAILS
***********************************************
Enter recipe name:

-Now each process of entering the details will display as you enter in the details.
-When you are done it will look something like this(keep in mind that there is exception handling in here as well and i will show you what it looks like at the end of what the correct out put looks like):
Are you sure you want to enter a new recipe?(y/n)
y
Now Capturing Recipe
***********************************************
ENTER NEW RECIPE DETAILS
***********************************************
Enter recipe name:
Strawberry Tart
Enter number of ingredients:
9
Ingredient 1
Name:
Jelly
Quantity:
2
Unit of Measurement (ml/mg/teaspoon/tablespoon/cup)
cup
Ingredient 2
Name:
Condensed Milk
Quantity:
1
Unit of Measurement (ml/mg/teaspoon/tablespoon/cup)
cup
Ingredient 3
Name:
Yogurt
Quantity:
350
Unit of Measurement (ml/mg/teaspoon/tablespoon/cup)
ml
Ingredient 4
Name:
water
Quantity:
2
Unit of Measurement (ml/mg/teaspoon/tablespoon/cup)
cup
Ingredient 5
Name:
Tennis Biscuits
Quantity:
250 mg
Invalid input.Please enter a valid number.
Ingredient 6
Name:
Butter
Quantity:
150
Unit of Measurement (ml/mg/teaspoon/tablespoon/cup)
mg
Ingredient 7
Name:
strawberries
Quantity:
1
Unit of Measurement (ml/mg/teaspoon/tablespoon/cup)
cup
Ingredient 8
Name:
whip cream
Quantity:
1
Unit of Measurement (ml/mg/teaspoon/tablespoon/cup)
cup
Ingredient 9
Name:
sugar
Quantity:
2
Unit of Measurement (ml/mg/teaspoon/tablespoon/cup)
tablespoon
Enter the number of steps:
12
Step 1:
Melt Butter
Step 2:
Crush Tennis Biscuits
Step 3:
Pour Melted Butter Onto Crushed Tennis Biscuits and Mix Them, Then Place Into Pan and Flatten
Step 4:
Put Jelly Into A Bowl
Step 5:
Pour 1 Cup of Hot Water into The Bowl of Jelly and Mix, Then Pour 1 Cup of Cold Water into The Bowl and Mix
Step 6:
When All The Jelly Has Dissovled Pour 1 Cup of Condensed Milk Into The Bowl and Mix
Step 7:
Now We Take The Yogurt(any flavour) and Pour It Into The Bowl And Mix
Step 8:
Pour Mixture into Pan Where The Crushed Tennis Biscuits Are And Place It In The Fridge for 4 hours or Over Night
Step 9:
When The Tart Is Set and Isn't Runny Anymore, Place Your Whipping Cream into A Bowl
Step 10:
Take An Electric Mixer on High and Start Whipping The Cream, Place The Sugar Into The Whipping Cream Before Mixing
Step 11:
Place The Whipped Cream Onto The Tart In Anyway you wish, and chop a cup of strawberries and place it onto the tart
Step 12:
Now that it is done cut it and serve. ENJOY!
RECIPE SUCCESSFULLY SAVED
-This is how the program will work if you enter the steps correctly,if you encounter exception handling errors it will look like this:
Are you sure you want to enter a new recipe?(y/n)
y
Now Capturing Recipe
***********************************************
ENTER NEW RECIPE DETAILS
***********************************************
Enter recipe name:
Tea
Enter number of ingredients:
k
INVALID INPUT.PLEASE ENTER A VALID NUMBER.
***********************************************
Welcome To Your Recipe Application
***********************************************
Please enter (1) to launch the menu
||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
Option 2 Works by taking the information stored in arrays and dsiplaying it to the user
-If you select option 2 : Display Recipe it will work like this:
Are you sure ypu want to display the recipe?(y/n)
y
Now Displaying Recipe
***********************************************
DISPLAYING RECIPE DETAILS:
***********************************************
***********************************
RECIPE DETAILS
***********************************
Recipe Name: Strawberry Tart
Ingredients:
Jelly - 2 cup
Condensed Milk - 1 cup
Yogurt - 350 ml
water - 2 cup
Butter - 150 mg
strawberries - 1 cup
whip cream - 1 cup
sugar - 2 tablespoon
Steps:
1.Melt Butter
2.Crush Tennis Biscuits
3.Pour Melted Butter Onto Crushed Tennis Biscuits and Mix Them, Then Place Into Pan and Flatten
4.Put Jelly Into A Bowl
5.Pour 1 Cup of Hot Water into The Bowl of Jelly and Mix, Then Pour 1 Cup of Cold Water into The Bowl and Mix
6.When All The Jelly Has Dissovled Pour 1 Cup of Condensed Milk Into The Bowl and Mix
7.Now We Take The Yogurt(any flavour) and Pour It Into The Bowl And Mix
8.Pour Mixture into Pan Where The Crushed Tennis Biscuits Are And Place It In The Fridge for 4 hours or Over Night
9.When The Tart Is Set and Isn't Runny Anymore, Place Your Whipping Cream into A Bowl
10.Take An Electric Mixer on High and Start Whipping The Cream, Place The Sugar Into The Whipping Cream Before Mixing
11.Place The Whipped Cream Onto The Tart In Anyway you wish, and chop a cup of strawberries and place it onto the tart
12.Now that it is done cut it and serve. ENJOY!
***********************************
-if there is no recipe the following will display:
2

Are you sure ypu want to display the recipe?(y/n)
y
Now Displaying Recipe
THERE IS NO RECIPE
Returning to main menu
***********************************************
Welcome To Your Recipe Application
***********************************************
Please enter (1) to launch the menu
||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
Option 3 works by taking the values stored in the arrays and multiplying them by 0.5,2 or 3
-If you select Option 3:.Scale recipe (0.5, 2, or 3)
-The ouptut will work like this:
3

Are you sure ypu want to scale the recipe?(y/n)
y
Now Scaling Recipe
***********************************************
SCALE RECIPE:
***********************************************
Enter the scaling factor(0.5,2,3):
2
RECIPE SUCCESSFULLY SAVED

.....
Now Displaying Recipe
***********************************************
DISPLAYING RECIPE DETAILS:
***********************************************
***********************************
RECIPE DETAILS
***********************************
Recipe Name: Strawberry Tart
Ingredients:
Jelly - 4 cup
Condensed Milk - 2 cup
Yogurt - 700 ml
water - 4 cup
Butter - 300 mg
strawberries - 2 cup
whip cream - 2 cup
sugar - 4 tablespoon
Steps:
1.Melt Butter
2.Crush Tennis Biscuits
3.Pour Melted Butter Onto Crushed Tennis Biscuits and Mix Them, Then Place Into Pan and Flatten
4.Put Jelly Into A Bowl
5.Pour 1 Cup of Hot Water into The Bowl of Jelly and Mix, Then Pour 1 Cup of Cold Water into The Bowl and Mix
6.When All The Jelly Has Dissovled Pour 1 Cup of Condensed Milk Into The Bowl and Mix
7.Now We Take The Yogurt(any flavour) and Pour It Into The Bowl And Mix
8.Pour Mixture into Pan Where The Crushed Tennis Biscuits Are And Place It In The Fridge for 4 hours or Over Night
9.When The Tart Is Set and Isn't Runny Anymore, Place Your Whipping Cream into A Bowl
10.Take An Electric Mixer on High and Start Whipping The Cream, Place The Sugar Into The Whipping Cream Before Mixing
11.Place The Whipped Cream Onto The Tart In Anyway you wish, and chop a cup of strawberries and place it onto the tart
12.Now that it is done cut it and serve. ENJOY!
***********************************
||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
Option 4 works by setting the values back to 1 by multipling or diving them by 1
-If you select option 4: Reset recipe to original values
-It will output this :
Are you sure ypu want to reset the recipe?(y/n)
y
Now Reseting Recipe
***********************************************
RESET RECIPE TO ORIGINAL VALUES
***********************************************
RECIPE SUCCESSFULLY SAVED

-and then show the recipe with the original values

|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
Option 5 works by taking all the information in the array and clearing the array
- Option 5 will delete all the recipes data and look like this:
- 5

Are you sure ypu want to clear the recipe?(y/n)
y
Now Clearing Recipe
***********************************************
CLEAR RECIPE DATA:
***********************************************
RECIPE DATA SUCCESSFULLY CLEARED

***********************************************
Welcome To Your Recipe Application
***********************************************
Please enter (1) to launch the menu

1

***********************************************
PLEASE SELECT ONE OF THE NUMERIC OPTIONS BELOW
***********************************************
1.Enter new recipe
2.Display recipe
3.Scale recipe (0.5, 2, or 3)
4.Reset recipe to original values
5.Clear recipe data
6.Exit Program
***********************************************

2

Are you sure ypu want to display the recipe?(y/n)
y
Now Displaying Recipe
THERE IS NO RECIPE
Returning to main menu
||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
Option 6 works by taking the whole program and closing it
-The last option is option 6 : Exit the program and this will completely exit the program

***********************************************
PLEASE SELECT ONE OF THE NUMERIC OPTIONS BELOW
***********************************************
1.Enter new recipe
2.Display recipe
3.Scale recipe (0.5, 2, or 3)
4.Reset recipe to original values
5.Clear recipe data
6.Exit Program
***********************************************

6

Are you sure you want to exit? (y/n)
y
THANK YOU FOR USING THIS APPLICATION
PROGRAM WILL NOW CLOSE
|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

And in conclusion this is how the program works and how you as a user can operate the program and ensure that you run into no problems.
This program works solely off what the user gives so if you give an incorrect value it will give you error messages and this can be avoided if you run it the way it is explained in this read me file.
