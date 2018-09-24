//***************************************************************************
//File: Program.cs
//
//Purpose: This console applicaiton is designed to unit test the dynamic Class
//  library that contains the Currency class and the Language class. 
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
using cHprogramming_cH_Project1_ClassLibrary;

namespace cHprogramming_cH_Project1
{
    class Program
    {
        #region Main
        //***************************************************************************
        //Method: Main
        //
        //Purpose: To run the Main method that will display menu to run unit test.	   
        //***************************************************************************
        static void Main(string[] args)
        {
            CountryAppUnitTesting c = new CountryAppUnitTesting(); // To call unit testing methods
            string userChoice; // For switch statement

            // Loop to display menu until user decides to end program
            do
            {
                //**********************************************************************
                // Display the menu to the user
                // User has the option to run unit test on dynamic library classes
                // If 3 is selected, loop will end
                //**********************************************************************
                Console.WriteLine("\nCountry Testing Menu");
                Console.WriteLine("--------------------");
                Console.WriteLine("1 - Unit Test Currency");
                Console.WriteLine("2 - Unit Test Language");
                Console.WriteLine("3 - Exit");
                Console.Write("Enter Choice: ");

                // Read Choice
                userChoice = Console.ReadLine();

                // Switch Statement to call a method that will run the user's choice
                switch (Convert.ToInt32(userChoice))
                {
                    case 1: c.UnitTestCurrency(); // Calls UnitTestCurrency Method
                        break;
                    case 2: c.UnitTestLanguage(); // Calls UnitTestLanguage Method
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("\nChoice/Option must be a number from 1-3.\n");
                        break;
                }
            } while (Convert.ToInt32(userChoice) != 3);

            Console.Write("\nPress any key to continue...");
            Console.ReadLine();
        }
        #endregion
    }
}
