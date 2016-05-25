# BitsNPiecesConsoleEdition

Bits 'N' Pieces Console Edition

Introduction: Thank you for taking a moment to review the contents of this README file.  The Bits 'N' Pieces application initially began as a Windows Client application that was developed in C# using Visual Studio.  Like it's predecessor, the Bits 'N' Pieces Console Edition was also developed in C# using Visual Studio, but rather than using a form-based approach, this edition of the Bits 'N' Pieces inventory system runs in a console window.

Instructions: To run the Bits 'N' Pieces Console Edition application, follow the steps below:    
1. Begin by launching the application.  This can be done by downloading the zip file which contains the entire project and navigating to the following directory within the project folder: ..\BitsNPieces\BitsNPieces\bin\Release\BitsNPieces.exe   
2. Upon launching the application, the main menu will be displayed.   
3. To make use of the inventory, begin by selecting option # 1 from the main menu.  Selecting this option will allow the user to add a single item to the inventory.  Adding an item may seem tricky at first, but it's quite simple.  In this application, an item is made up of four distinct attributes which are as follows: 
    * The ID of the item being entered.  This can be any integer value that you would like to use, except negative values.
    * The Name of the item.  This can be any string that you would like to enter.  Think of the item's name as the "Make".
    * The Type of item being entered.  This can also be any string that you would like.  Think of the item's name as the "Model".
    * The Expiration Date of the item.  This attribute expects a date to be entered, so try not to dissapoint it.
When adding an item, the attributes will be entered in the order shown above.  After entering the value of an attribute, be sure to press Enter in order to record the value and move on to the next attribute.  For example, if we were to begin entering an item into our list, this is how an item would appear in the console window just prior to being added to the inventory:
    * 1
    * Honda
    * Civic
    * 09/21/1994    
4. Once a few items have been added to the inventory, it might be necessary to remove one or more items.  This can be done by selecting option # 2 from the main menu.  The inventory will be displayed at the top of the screen and an item can be removed simply by typing it's ID when prompted to do so.  Once the ID of the item has been entered, the inventory will be re-displayed along with a notification that the item has been removed.    
5. Each of the items in the inventory should have an associated expiration date.  Some of the items may have dates which are prior to the current date.  By selecting option # 3 from the main menu, the application will count the number of items that have an expiration date that is prior to the current date and notify the user of the number of items that have expired.    
6. Selecting option # 4 from the main menu will display a README file in the console window that provides a brief overview of the application.    
7. Finally, if you choose to exit the application, select option # 5 from the main menu.    

Project Design: During the design phase of this project, I wanted to make use of an in-memory data-structure.  At first, I was considering using an array to hold the items that would be included in the inventory, but after some research, I decided to make use of a List.  The main reason for this decision is because an array cares about it's size whereas a List does not.  While writing the code, my main goal was to produce a set of classes that could easily be utilized in other applications that may require such features.
So I began by creating a class called "Item" which is used to define an item that would be added to the inventory.  In this case, a single item is made up of four attributes which are "ItemID", "ItemName", "ItemType", and "ItemExpirationDate".  The other class that I created for this project is called "Inventory".  The purpose of the Inventory class is to define the structure and functionality of an inventory.  In this case, the inventory itself is a List.  The functionalities of the inventory include the ability to ADD items, REMOVE items, VIEW items, and CHECK for expired items. The final class in this project is called "Program" which contains the main functionality of the entire console application.  The program class utilizes the Inventory class by calling its functions, and the Inventory class makes use of the Item class when it's ADD, REMOVE, VIEW, and CHECK functionalities are invoked.
- This project can easily be extended to include much more detail in terms of the items that are being dealt with simply by declaring more attributes to the Item class.  These could be specific attributes such as "Make", "Model", "SerialNumber", and so forth.
- As for the maintainability of this application, it was designed with the purpose of being easily maintained with little to no code changes that are necessary.  Try and Catch blocks were used to handle user-errors including invalid inputs while comments were included to assist with future development.
- Security was not implemented in this application due to a lack of time that was available, but it is possible to adapt security features into this code.

Notes: It would have been nice to have had time to implement a search feature into this application which would allow the user to search for a particular item in the inventory, or even to locate items that have expired.  This functionality could easily be incorporated, but due to time constraints, it was not possible for this iteration of the project.

Feedback: Please feel free to download the zip file which contains the solution for the Bits 'N' Pieces project, and try out the executable which can be found in the following path: ..\PGIS\PGIS\bin\Release\PGIS.exe
Your feedback is greatly appreciated so please leave comments and questions at your convenience.

Project Details:                               
Version: 1.0                               
IDE: Visual Studio 2010                              
Framework: .NET                             
Language: C#                               
