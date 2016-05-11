using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitsNPieces
{
    class Program
    {
        private static bool exitApplication = false;  //- Used as a trigger to close the application.
        private static double version = 1.0;  //- Used for Versioning Changes in the README section.

        /// <summary>
        /// Function: Main
        /// Description: Makes use of a switch statement in order to determine the course of 
        ///              action based on the user's selected option of the choices in the 
        ///              menu.  For example, if the user selects the number "1", then the
        ///              integer called menuSelection will receive that value and perform 
        ///              the code within "case 1" which will allow the user to ADD an item 
        ///              to the inventory.
        /// </summary>
        /// <returns>An integer value for the Error Code is returned.</returns>
        private static int Main(string[] args)
        {
            int menuSelection = 0;

            //- Using a Do-While Loop to repeatedly display the menu:
            do
            {
                menuSelection = DisplayMenu();

                //- The selected menu option determines which of the following cases will be run:
                switch (menuSelection) 
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("You are about to add an item to the inventory.");
                        Console.WriteLine("The System will prompt you for the following information:");
                        Console.WriteLine("The Unique Identifier (ID) of the Item.");
                        Console.WriteLine("The Name of the Item.");
                        Console.WriteLine("The Type of Item you are adding.");
                        Console.WriteLine("The Date in which the Item Expires.");
                        Console.WriteLine("Be sure to Press Enter after typing each required field.");
                        Console.WriteLine("For example, on the first blank line you would type the ");
                        Console.WriteLine("ID of the item which might be '42'.  After typing the ID, ");
                        Console.WriteLine("Press Enter to continue on to the next required field ");
                        Console.WriteLine("which would be the Name of the item.  Got it?");
                        Console.WriteLine("Now go forth and create your inventory...");
                        Console.WriteLine();
                        Inventory.AddItem();
                        Inventory.ViewItems();
                        Console.WriteLine();
                        Console.WriteLine("Press any key to return to the main menu.");
                        Console.WriteLine();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine();
                        Inventory.ViewItems();
                        Console.WriteLine();
                        Console.WriteLine("Please enter the ID of the Item to Remove");
                        int itemID = Convert.ToInt32(Console.ReadLine());
                        Inventory.RemoveItem(itemID);
                        Inventory.ViewItems();
                        Console.WriteLine();
                        Console.WriteLine("Press any key to return to the main menu.");
                        Console.WriteLine();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine();
                        Inventory.CheckForExpiredItems();
                        Console.WriteLine();
                        Console.WriteLine("Press any key to return to the main menu.");
                        Console.WriteLine();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        ViewReadMe();
                        Console.WriteLine();
                        Console.WriteLine("Press any key to return to the main menu.");
                        Console.WriteLine();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        exitApplication = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("To ADD an item to the inventory, type 1 and press Enter.");
                        Console.WriteLine("To REMOVE an item from the inventory, type 2 and press Enter.");
                        Console.WriteLine("To VIEW the README file, type 3 and press Enter.");
                        Console.WriteLine("To EXIT the application, type 4 and press Enter.");
                        Console.WriteLine();
                        DisplayMenu();
                        Console.WriteLine();
                        break;
                }

            } while (exitApplication != true);

            return (int)ExitCode.Success;
        }

        /// <summary>
        /// Function: DisplayMenu
        /// Description: Writes a numbered menu to the screen which is used to inform
        ///              the user of the options that are available to choose from.
        /// </summary>
        /// <returns>The integer value of the selection is returned</returns>
        private static int DisplayMenu()
        {
            var result = "";

            //- The following code display's the main menu of the application:
            try
            {
                Console.WriteLine("*******************************************");
                Console.WriteLine("*               Bits 'N' Pieces           *");
                Console.WriteLine("*              Inventory System           *");
                Console.WriteLine("*******************************************");
                Console.WriteLine();
                Console.WriteLine("Please select from one of the following options");
                Console.WriteLine("by typing 1, 2, 3, or 4 and pressing Enter.");
                Console.WriteLine();
                Console.WriteLine("1. ADD an Item to the Inventory");
                Console.WriteLine("2. REMOVE an Item from the Inventory");
                Console.WriteLine("3. CHECK the Inventory for Expired Items");
                Console.WriteLine("4. VIEW the README documentation");
                Console.WriteLine("5. EXIT");
                result = Console.ReadLine();
                Convert.ToInt32(result);
            }
            catch (Exception e)
            {
                result = "";
                Console.Clear();
                Console.WriteLine("Please follow the directions.  8^)");
                Console.WriteLine();
                DisplayMenu();
            }

            return Convert.ToInt32(result);
        }

        /// <summary>
        /// Function: ViewReadMe
        /// Description: Writes the README Documentation to the screen.
        /// </summary>
        private static void ViewReadMe()
        {
            Console.Clear();
            Console.WriteLine("*******************************************");
            Console.WriteLine("*               Bits 'N' Pieces           *");
            Console.WriteLine("*            READ ME Documentation        *");
            Console.WriteLine("*******************************************");
            Console.WriteLine();
            Console.WriteLine("INTRODUCTION:");
            Console.WriteLine("Hello, and welcome to the Bits 'N' Pieces  ");
            Console.WriteLine("READ ME documentation.  May your UX be un- ");
            Console.WriteLine("tarnished by the lack of a more glorified  ");
            Console.WriteLine("UI.  For this is only the beginning of many");
            Console.WriteLine("great and marvelous works to come.  ");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.WriteLine("DESCRIPTION:");
            Console.WriteLine("The purpose of this application is to allow");
            Console.WriteLine("a user to build and manage an inventory of ");
            Console.WriteLine("items.  Think of it as a personalized list.");
            Console.WriteLine("The Bits 'N' Pieces application launches in");
            Console.WriteLine("a console window and uses a menu system to ");
            Console.WriteLine("allow the user to select from 5 different  ");
            Console.WriteLine("options which include the ability to:      ");
            Console.WriteLine("(1) ADD an item to the inventory,          ");
            Console.WriteLine("(2) REMOVE an item from the inventory,     ");
            Console.WriteLine("(3) CHECK the inventory for expired items, ");
            Console.WriteLine("(4) VIEW the README documentation,         ");
            Console.WriteLine("(5) EXIT the application.                  ");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.WriteLine("USAGE:");
            Console.WriteLine("Upon launching the application, the user is");
            Console.WriteLine("greeted by the application menu which      ");
            Console.WriteLine("immediately allows the user to begin       ");
            Console.WriteLine("building a custom inventory.               ");
            Console.WriteLine("By pressing the number 1 at the menu screen");
            Console.WriteLine("the user will be able to add a single item ");
            Console.WriteLine("to the inventory by following the          ");
            Console.WriteLine("instructions on the screen.                ");
            Console.WriteLine("Pressing the number 2 at the menu screen   ");
            Console.WriteLine("allows the user to remove a single item    ");
            Console.WriteLine("from the inventory.                        ");
            Console.WriteLine("Selecting number 3 from the menu screen    ");
            Console.WriteLine("will count the number of expired items in  ");
            Console.WriteLine("the inventory and display the total to the ");
            Console.WriteLine("user.                                      ");
            Console.WriteLine("If you're currently reading this, you must ");
            Console.WriteLine("have figured out what number 4 does.  As it");
            Console.WriteLine("causes this README documentation to be     ");
            Console.WriteLine("written to the screen.                     ");
            Console.WriteLine("And last but not least, pressing the number");
            Console.WriteLine("5 will close the application.              ");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.WriteLine("FEEDBACK:");
            Console.WriteLine("As always, comments are both welcomed and  ");
            Console.WriteLine("appreciated.  So please feel free to drop  ");
            Console.WriteLine("me a line with anything that comes to mind.");
            Console.WriteLine("I can easily be reached via email at:      ");
            Console.WriteLine("michaelt0123@yahoo.com                     ");
            Console.WriteLine("Thank you for your interest and...         ");
            Console.WriteLine("-------------HAVE A GREAT DAY!-------------");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.WriteLine("PROJECT DETAILS:");
            Console.WriteLine("Version: " + version);
            Console.WriteLine("IDE: Visual Studio 2010");
            Console.WriteLine("Framework: .NET");
            Console.WriteLine("Language: C#");
        }

        //- Included for Debugging Purposes:
        enum ExitCode : int
        {
            Success = 0,
            InvalidFilename = 2,
            UnknownError = 10
        }
    }
}
