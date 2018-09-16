//***************************************************************************
//File: Program.cs
//
//Purpose: This console applicaiton is designed do the following
//      
//      Step 1: Display a Country Testing Menu
//      Step 2: Read in the users choice
//      Step 3: Compute the users choice
//
//Written By: Timothy Negron
//
//Compiler: Visual Studio C# 2017
//
//Update Information
//------------------
//
//***************************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cHprogramming_cH_Project1
{
    class Program
    {
        //***************************************************************************
        //Method: Main
        //
        //Purpose: To run the Main method.
        //		   
        //Update Information
        //------------------
        //
        //***************************************************************************

        static void Main(string[] args)
        {
            string userChoice;

            do
            {


                // Display the menu to the user
                Console.WriteLine("Country Testing Menu");
                Console.WriteLine("--------------------");
                Console.WriteLine("1 - Unit Test Currency");
                Console.WriteLine("2 - Unit Test Language");
                Console.WriteLine("3 - Exit");
                Console.WriteLine("Enter Choice: ");

                // Read Choice
                userChoice = Console.ReadLine();

                // Switch Statement to call a method that will run the user's choice
                switch (Convert.ToInt32(userChoice))
                {
                    case 1: //Unit Test Currency
                        Console.WriteLine("\nCase/Option 1 was selected.\n");
                        break;
                    case 2: // Unit Test Language
                        Console.WriteLine("\nCase/Option 2 was selected.\n");
                        break;
                    case 3: // Exit
                        Console.WriteLine("\nCase/Option 3 was selected.\n");
                        break;
                    default:
                        Console.WriteLine("\nChoice/Option must be a number from 1-3.\n");
                        break;
                }
            } while (Convert.ToInt32(userChoice) != 3);

            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
