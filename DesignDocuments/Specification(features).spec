
Feature:Program prompts user for first input and display an outcome
===========================================================

The console displays it is an area calculator, shows shapelist command, quit command, and awaits prompt


Scenario:User inputs the command to see the list of shapes
-------------------------------------------------

A list of shapes is displayed in the console. The user is prompted to pick one.

* user types the command to list the shapes correctly
* console displays the list of shapes (see shapelist.png)
* user enters a shape from the list



Scenario:User types an invalid command or shape name
--------------------------------------------

The User is told he entered the command incorrectly, and is given anouther chance.

* user types a shape that is not supported
* console informs user that what he typed is invalid
* console reprompts the user for input



Scenario:User types a shape recognized by the console
-------------------------------------------

A valid shape is entered correctly, the system prompts for shape properties

** user types a recognized shape
** console prompts user for the shape properties
** console outputs the area



Scenario:User types the command to quit
------------------------------

Quit command entered in the prompt, quitting the program.

** user types the quit command
** console recognizes the command, says goodbye to the user
** user is prompted to click any key to close the program 


Feature:User enters shape required parameters
=====================================

The user enters values that the shape requires to calculate the area


Scenario:User enters the correct values for a shape
------------------------------------------

correct and valid numbers are entered for shape parameters

** console prompts user to enter parameters for given shape
** user enters in valid numbers for the parameters
** console asks user to verify the numbers are correct
** user verifies the numbers are correct
** console displays the area of the shape based on given parameters(see shaperesults.png)


Scenario:User enters invalid values for a shape
--------------------------------------

the user enters incorrect numbers, which prompts him to enter valid ones

** console prompts user to enter parameters for given shape
** user enters a word instead of numbers for the parameters
** console tells user to enter a valid number, and reprompts him to do so

Scenario:User decides he wants to go back a step **REMOVED
---------------------------------------

using a command that is listed in the command list, the user goes back to the main menu

** console prompts user to enter parameters for given shape
** user enters the command to go back to the main menu
** console exits out of the shape parameters selection, and returns user to main menu


Feature:User receives prompt after receiving a shape area
===============================================================

the user is brought back to the main menu

Scenario:User enters 'QUIT' as input
---------------------------

the program reloops 

** user prompted the main menu and asked to enter a command

