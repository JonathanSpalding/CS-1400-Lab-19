// Author: Jonathan Spalding
// Assignment: lab 19
// Instructor "Roger deBry
// Clas: CS 1400
// Date Written: 3/9/2016
//
// "I declare that the following source code was written solely by me. I understand that copying any source code, in whole or in part, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy."
//----------------------------------------------------
using System;
using static System.Console;

namespace lab19
{
    class Program
    {
        // State Constants, Snake eyes, boxcars etc
        const int SNAKEEYES = 1;
        const int BOXCARS = 6;
        const int MIN = 1;
        const int MAX = 7;
        static void Main(string[] args)
        {
                string userResponse;
                //create random number generator.
                Random randomNums = new Random();
                //ask for user input in WriteLine
                Write("Would you like to roll a die? y or n: ");
                //Do loop {
                do
                {
                    //readline the user's input and put it in a variable.
                    userResponse = ReadLine();
                    //if else statement for if the user pressed yes {
                    if (userResponse == "y")
                    {
                        //create two integers for the random number generator for the dice.
                        int d1 = randomNums.Next(MIN, MAX);
                        int d2 = randomNums.Next(MIN, MAX);
                        //if statement for snake eyes 
                        if (SNAKEEYES == d1 && SNAKEEYES == d2)
                            //write "You rolled snake eyes"
                            Write("You rolled Snake Eyes.\n");
                        //else if statement for boxcars 
                        else if (BOXCARS == d1 && BOXCARS == d2)
                            //write "You rolled BoxCars"
                            Write("You rolled boxcars.\n");
                        //else statement that WriteLines the result for each die.
                        else WriteLine($"You rolled {d1} and {d2}.");
                        //close if statement }
                        Write("Do you want to roll the dice again (y or n)? ");
                    }
                    // else if answer was no {
                    else if (userResponse == "n")
                    {
                        // print goodbye message and quit. }
                        WriteLine("Well fine then! Be that way...");
                        System.Threading.Thread.Sleep(1500);
                        Environment.Exit(0);
                        // else if user response is not yes and not no, {
                        // respond that the input was incorrect and to please enter y or n }
                    }
                    else WriteLine("I'm sorry, that was not a valid response, please enter either y or n.");
                    //close out do While Loop }  while (userResponse != "y" || userResponse != "n");
                } while (userResponse != "y" || userResponse != "n");
            }
    }
}
