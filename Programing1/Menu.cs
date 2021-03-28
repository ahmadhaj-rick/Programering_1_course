using System;
using System.Collections.Generic;
namespace HomeWorkMenu
{
    class Menu
    {
       private static void Main(string[] arg)
        {
            int Main_option = 1;
            while (Main_option != 0) //While Loop Main Menu.
            {
                Console.WriteLine("\n" +
                                  "Welcome To this Little Project Made By ..... \n" +
                                  "This Project is made for Programing 1 Course. \n" +
                                  "Below you can choose from different Homeworks to see how they work \n");

                Console.WriteLine("On the first page of the menu. \n" +
                                  "pick which section you would like to see first. " +
                                  "To Exit Enter (0).\n");

                Console.WriteLine("The Menu Tree Looks Like This: \n" +
                    "1- Basics of Coding -> 1- Sum of 2 Numbers.\n" +
                    "                    -> 2- Sum of 3 numbers And Medium.\n" +
                    "                    -> 3- Convert Decimal To Whole.\n" +
                    "                    -> 4- A salary Calculation App\n" +
                    "\n" +
                    "2-IF/Switch States  -> 1-  Comparing Two Numbers\n" +
                    "                    -> 2-  Comparing Three Numbers\n" +
                    "                    -> 3-4 How Many Zeros in 3 Numbers\n" +
                    "                    -> 5-  Calculator for Triangle\n" +
                    "                    -> 6-  Age Calculator and sorter\n" +
                    "                    -> 7-  Two Athlets Who first place and Second\n" +
                    "                    -> 8-  3 students Results and Names + Sorting\n" +
                    "                    -> 9-  Solving An Equation with 3 Varibles\n" +
                    "                    -> 10- Finding if Number is Odd Or Even\n" +
                    "                    -> 11- Figuring out if a year is a Leap Year\n" +
                    "                    -> 12- Enter your age to see if you Legal age for Alcohol\n" +
                    "                    -> 13- Convert Minutes To hours\n" +
                    "                    -> 14- Convert New grading system to Old system\n" +
                    "\n" +
                    "3- Loops For/While  -> 1- Start, Step and Stop\n" +
                    "                    -> 2- Counting up to the number inputed\n" +
                    "                    -> 3- Counting up to the number inputed,Check dividable by 3 & 7\n" +
                    "                    -> 4- Printing the (N) numbers of the Fibonacci Sequence\n" +
                    "                    -> 5- Checking if a Whole number is Prime?\n" +
                    "                    -> 6 - Reading(N) and Calculating N = 1 * 2 * n\n" +
                    "                    -> 7 - Work in progress\n" +
                    "                    -> 8- Check Prime Number in Range of Two numbers\n" +
                    "                    -> 9- Print out the Alphabet on screen (List)\n" +
                    "                    ->10- Multiplication table.\n" +
                    "                    ->11- Raise to Power\n" +
                    "\n" +
                    "4- Methods          -> 1- 4 Types of Methods.\n" +
                    "                    -> 2- Count up to input and sum primes in between.\n" +
                    "                    -> 3- Size of the TV from the diagonal length.\n" +
                    "                    -> 4- Guessing the Random Number Game!\n" +
                    "                    -> 5- Printing Primes up to a number.\n" +
                    "                    -> 6- Number Of Days\n" +
                    "                    -> 7- Simple Speed Cam App\n" +
                    "                    -> 8- Simple ATM App\n" +
                    "\n" +
                    "5-Vectors And Lists -> 1- Swtiching Rows of a 2D Array.\n" +
                    "                    -> 2- Char in a input string.\n" +
                    "                    -> 3- Repostion Array Elements And Insert.\n" +
                    "                    -> 4- A salary Calculation App.\n" +
                    "                    -> 5- Find Min And Max Num in an int Arry.\n" +
                    "                    -> 6- Sum of 3 numbers And Medium.\n" +
                    "                    -> 7- Sum of 3 numbers And Medium.\n" +
                    "                    -> 8- Sum of 3 numbers And Medium.\n" +
                    "                    -> 9- Sum of 3 numbers And Medium.\n" +
                    "                    -> 10- Sum of 3 numbers And Medium.\n" +
                    "                    -> 11- Sum of 3 numbers And Medium.\n" +
                    "                    -> 12- Sum of 3 numbers And Medium.\n" +
                    "                    -> 13- Sum of 3 numbers And Medium.\n");

                Console.WriteLine("Enter An Opetion: .....");
                Main_option = Convert.ToInt16(Console.ReadLine());

                // Menu and Sub-Menu To choose which home work to execute!
                switch (Main_option)
                {
                    case 1: // First HomeWork Section - Sub Menu (1)


                        int Option_1 = 1;
                        while (Option_1 != 0) // While Loop  Sub-Menu (1).
                        {
                            // Console.WriteLine("Choose an Opetion to execute! ");
                            Console.WriteLine("\n" +
                                              "1- Basics of Coding -> 1- Sum of 2 Numbers.\n" +
                                              "                    -> 2- Sum of 3 numbers And Medium.\n" +
                                              "                    -> 3- Convert Decimal To Whole.\n" +
                                              "                    -> 4- A salary Calculation App.\n" +
                                              "                    -> 0- To go Back To Main_Menu.\n" +
                                              "\n");

                            Option_1 = Convert.ToInt16(Console.ReadLine());
                            // make a while loop to loop the menu after executing an option 
                            switch (Option_1) // Sub-Menu 1
                            {
                                case 1:
                                    Console.WriteLine("You Are At -> *1- Sum of 2 Numbers" + "\n");
                                    Programing1.HomeWork1.SumTwoNums();

                                    break;
                                case 2:
                                    Console.WriteLine("You Are At ->* 2- Sum of 3 numbers And Medium." + "\n");
                                    Programing1.HomeWork1.Sum3NumsAndMedium();
                                    // HomeWork1.SumTwoNums();

                                    break;
                                case 3:
                                    Console.WriteLine("You Are At -> 3- Convert Decimal To Whole." + "\n");
                                    Programing1.HomeWork1.DecToWhole();

                                    break;
                                case 4:
                                    Console.WriteLine("You Are At -> 4- A salary Calculation App." + "\n");
                                    Programing1.HomeWork1.SalaryCalc();

                                    break;

                                default:
                                    Console.WriteLine("You have Entered an invalid Choice! " + "\n");
                                    // Menu.Main(); try to bring back the user to start of the
                                    // program to input a valid choice !!!
                                    break;

                            }

                        } // End While Loop  Sub-Menu (1).

                        break; // End First HomeWork Section - Sub Menu (1)

                    case 2: // Second HomeWork Section - Sub Menu (2)

                        int Option_2 = 1;
                        while (Option_2 != 0) // While Loop  Sub-Menu (2).
                        {

                            // Console.WriteLine("Choose an Opetion to execute! ");
                            Console.WriteLine("\n" +
                                              "2-IF/Switch States  -> 1-  Comparing Two Numbers\n" +
                                              "                    -> 2-  Comparing Three Numbers\n" +
                                              "                    -> 3-4 How Many Zeros in 3 Numbers\n" +
                                              "                    -> 5-  Calculator for Triangle\n" +
                                              "                    -> 6-  Age Calculator and sorter\n" +
                                              "                    -> 7-  Two Athlets Who first place and Second\n" +
                                              "                    -> 8-  3 students Results and Names + Sorting\n" +
                                              "                    -> 9-  Solving An Equation with 3 Varibles\n" +
                                              "                    -> 10- Finding if Number is Odd Or Even\n" +
                                              "                    -> 11- Figuring out if a year is a Leap Year\n" +
                                              "                    -> 12- Enter your age to see if you Legal age for Alcohol\n" +
                                              "                    -> 13- Convert Minutes To hours\n" +
                                              "                    -> 14- Convert New grading system to Old system\n" +
                                              "\n");
                            Option_2 = Convert.ToInt16(Console.ReadLine());

                            switch (Option_2) // Sub-Menu 2 
                            {
                                case 1:
                                    Console.WriteLine("You Are At -> 1-  Comparing Two Numbers." + "\n");
                                    Programing1.HomeWork2.CompTwoNums();

                                    break;

                                case 2:
                                    Console.WriteLine("You Are At -> 2-  Comparing Three Numbers." + "\n");
                                    Programing1.HomeWork2.Comp3Nums();

                                    break;

                                case 3:
                                    Console.WriteLine("You Are At -> 3-4 How Many Zeros in 3 Numbers." + "\n");
                                    Programing1.HomeWork2.HowManyZero();

                                    break;

                                case 4:
                                    Console.WriteLine("You Are At -> 3-4 How Many Zeros in 3 Numbers." + "\n");
                                    Programing1.HomeWork2.HowManyZero();

                                    break;

                                case 5:
                                    Console.WriteLine("You Are At -> 5-  Calculator for Triangle." + "\n");
                                    Programing1.HomeWork2.Triangle();

                                    Console.WriteLine("You Here 2_1");

                                    break;

                                case 6:
                                    Console.WriteLine("You Are At -> 6-  Age Calculator and sorter." + "\n");
                                    Programing1.HomeWork2.Age();

                                    break;

                                case 7:
                                    Console.WriteLine("You Are At -> 7-  Two Athlets Who first place and Second." + "\n");
                                    Programing1.HomeWork2.Winner();

                                    break;

                                case 8:
                                    Console.WriteLine("You Are At -> 8-  3 students Results and Names + Sorting." + "\n");
                                    Programing1.HomeWork2.Result();

                                    break;

                                case 9:
                                    Console.WriteLine("You Are At -> 9-  Solving An Equation with 3 Varibles." + "\n");
                                    Programing1.HomeWork2.Equations();

                                    break;

                                case 10:
                                    Console.WriteLine("You Are At -> 10- Finding if Number is Odd Or Even." + "\n");
                                    Programing1.HomeWork2.EvenOdd();

                                    break;

                                case 11:
                                    Console.WriteLine("You Are At -> 11- Figuring out if a year is a Leap Year." + "\n");
                                    Programing1.HomeWork2.LeapOrNot();

                                    break;

                                case 12:
                                    Console.WriteLine("You Are At -> 12- Enter your age to see if you Legal age for Alcohol." + "\n");
                                    Programing1.HomeWork2.BarOrBolaget();

                                    break;

                                case 13:
                                    Console.WriteLine("You Are At -> 13- Convert Minutes To hours." + "\n");
                                    Programing1.HomeWork2.MinutesToHours();

                                    break;

                                case 14:
                                    Console.WriteLine("You Are At -> 14- Convert New grading system to Old system." + "\n");
                                    Programing1.HomeWork2.OldToNew();

                                    break;

                                default:
                                    Console.WriteLine("Back To Main Menu.\n");


                                    // Menu.Main(); try to bring back the user to start of the
                                    // program to input a valid choice !!!
                                    break;
                            }

                        } // End While Loop Sub-Menu (2).


                        break; // End Second HomeWork Section - Sub Menu (2)

                    case 3: // Third HomeWork Section  - Sub Menu (3)
                            // Console.WriteLine("You Here 3_1");

                        int Option_3 = 1;
                        while (Option_3 !=0)  // While Loop Sub-Menu (3).
                        {

                            Console.WriteLine("\n" +
                                              "3- Loops For/While  -> 1- Start, Step and Stop\n" +
                                              "                    -> 2- Counting up to the number inputed\n" +
                                              "                    -> 3- Counting up to the number inputed,Check dividable by 3 & 7\n" +
                                              "                    -> 4- Printing the (N) numbers of the Fibonacci Sequence\n" +
                                              "                    -> 5- Checking if a Whole number is Prime?\n" +
                                              "                    -> 6- Reading (N) and Calculating N = 1 * 2 * n.\n" +
                                              "                    -> 7- Work in progress.\n" +
                                              "                    -> 8- Check Prime Number in Range of Two numbers.\n" +
                                              "                    -> 9- Print out the Alphabet on screen (List).\n" +
                                              "                    ->10- Multiplication table.\n" +
                                              "                    ->11- Raise to Power.\n" +
                                              "\n");

                            Option_3 = Convert.ToInt16(Console.ReadLine());
                            switch (Option_3) // Sub-Menu 3 
                            {
                                case 1:
                                    Console.WriteLine("You Are At -> 1- Start, Step and Stop" + "\n");
                                    Programing1.HomeWork3.Steps();

                                    break;
                                case 2:
                                    Console.WriteLine("You Are At -> 2- Counting up to the number inputed" + "\n");
                                    Programing1.HomeWork3.CountingUp2Input();

                                    break;

                                case 3:
                                    Console.WriteLine("You Are At -> 3- Counting up to the number inputed,Check dividable by 3 & 7" + "\n");
                                    Programing1.HomeWork3.CountingUp2Input2();

                                    break;
                                case 4:
                                    Console.WriteLine("You Are At -> 4- Printing the (N) numbers of the Fibonacci Sequence" + "\n");
                                    Programing1.HomeWork3.FibonacciSequence();

                                    break;
                                case 5:
                                    Console.WriteLine("You Are At -> 5- Checking if a Whole number is Prime ?" + "\n");
                                    Programing1.HomeWork3.PrimeCheck();

                                    break;
                                case 6:
                                    Console.WriteLine("You Are At -> 6- Reading (N) and Calculating N = 1 * 2 * n" + "\n");
                                    Programing1.HomeWork3.CalcNumN();
                                    break;
                                case 7:
                                    Console.WriteLine("You Are At -> 7- Work in progress "+ "\n");
                                    break;
                                case 8:
                                    Console.WriteLine("You Are At -> 8- Check Prime Number in Range of Two numbers " + "\n");
                                    Programing1.HomeWork3.RangePrimNum();
                                    break;
                                case 9:
                                    Console.WriteLine("You Are At -> 9- Print out the Alphabet on screen (List)"+ "\n");
                                    Programing1.HomeWork3.Alphabet();
                                    break;
                                case 10:
                                    Console.WriteLine("You Are At -> 10- Multiplication table. " + "\n");
                                    Programing1.HomeWork3.MulitTable();
                                    
                                    break;
                                case 11:
                                    Console.WriteLine("You Are At -> 11- Raise to Power"+ "\n");
                                    Programing1.HomeWork3.PowerTo();
                                    break; 
                                default:
                                    Console.WriteLine("Back To Main Menu.\n");
                                    // Menu.Main(); try to bring back the user to start of the
                                    // program to input a valid choice !!!
                                    break;

                                    /**
                                    Console.WriteLine("You Are At ->   + "\n");
                                    **/
                            }

                        } // End While Loop Sub-Menu (3).
                        

                        break; // End Third HomeWork Section - Sub Menu (3)

                    case 4: // Fourth HomeWork Section - Sub Menu (4)

                        int Option_4 = 1;
                        while (Option_4 != 0)
                        {
                            Console.WriteLine("\n" +
                                "4- Methods          -> 1- 4 Types of Methods.\n" +
                                "                    -> 2- Count up to input and sum primes in between.\n" +
                                "                    -> 3- Size of the TV from the diagonal length.\n" +
                                "                    -> 4- Guessing the Random Number Game!\n" +
                                "                    -> 5- Printing Primes up to a number.\n" +
                                "                    -> 6- Number Of Days\n" +
                                "                    -> 7- Simple Speed Cam App\n" +
                                "                    -> 8- Simple ATM App\n" +
                                "\n");

                            Option_4 = Convert.ToInt32(Console.ReadLine());

                            switch (Option_4)
                            {
                                case 1:
                                    Console.WriteLine("You are at 1- 4 types of methods.");
                                    Programing1.HomeWork4.MethodTypes();
                                    break;
                                case 2:
                                    Console.WriteLine("You are at 2- Count up to input and sum primes in between.\n");
                                    Programing1.HomeWork4.SumUpToPrim();
                                    break;
                                case 3:
                                    Console.WriteLine("You are at 3- Size of the TV from the diagonal length.\n");
                                    Programing1.HomeWork4.TvSize();
                                    break;
                                case 4:
                                    Console.WriteLine("You are at 4- Guessing the Random Number Game!\n");
                                    Programing1.HomeWork4.GuessingGame();
                                    break;
                                case 5:
                                    Console.WriteLine("You are at  5- Printing Primes up to a number.\n");
                                    Programing1.HomeWork4.PrimCounter();
                                    break;
                                case 6:
                                    Console.WriteLine("You are at  6- Number Of Days Calculator\n");
                                    Programing1.HomeWork4.Veckodag();
                                    break;
                                case 7:
                                    Console.WriteLine("You are at  7- Simple Speed Cam App\n");
                                    Programing1.HomeWork4.SpeedCam();
                                    break;
                                case 8:
                                    Console.WriteLine("You are at  8- Simple ATM App\n");
                                    Programing1.HomeWork4.ATM();
                                    break;
                                default: // Default HomeWork Section - Main Menu (Default)
                                    Console.WriteLine("Back To Main Menu.\n");
                                    break;
                            }


                        }


                        break;

                    case 5: // Fifth HomeWork Section - Sub Menu (5)


                        int Option_5 = 1;
                        while (Option_5 != 0) // While Loop  Sub-Menu (5).
                        {
                            // Console.WriteLine("Choose an Opetion to execute! ");
                            Console.WriteLine("\n" +
                                              "5-Vectors And Lists -> 1- Swtiching Rows of a 2D Array.\n" +
                                              "                    -> 2- Char in a input string.\n" +
                                              "                    -> 3- Repostion Array Elements And Insert.\n" +
                                              "                    -> 4- Max And Min In Array.\n" +
                                              "                    -> 5- Find Min And Max Num in an int Arry.\n" +
                                              "                    -> 6- Sum of 3 numbers And Medium.\n" +
                                              "                    -> 7- Sum of 3 numbers And Medium.\n" +
                                              "                    -> 8- Sum of 3 numbers And Medium.\n" +
                                              "                    -> 9- Sum of 3 numbers And Medium.\n" +
                                              "                    -> 10- Sum of 3 numbers And Medium.\n" +
                                              "                    -> 11- Sum of 3 numbers And Medium.\n" +
                                              "                    -> 12- Sum of 3 numbers And Medium.\n" +
                                              "                    -> 13- Sum of 3 numbers And Medium.\n" +
                                              "                    -> 0- To go Back To Main_Menu.\n" +
                                              "\n");

                            Option_5 = Convert.ToInt16(Console.ReadLine());
                            // make a while loop to loop the menu after executing an option 
                            switch (Option_5) // Sub-Menu 5
                            {
                                case 1:
                                    Console.WriteLine("You Are At -> 1- Swtiching Rows of a 2D Array." + "\n");
                                    Programing1.HomeWork5.SwitchRowsArray();
                                    break;
                                case 2:
                                    Console.WriteLine("You Are At -> 2- Char in a input string. " + "\n");
                                    Programing1.HomeWork5.LettersInCharCounter();                                    
                                    break;
                                case 3:
                                    Console.WriteLine("You Are At -> 3- Repostion Array Elements And Insert." + "\n");
                                    Programing1.HomeWork5.InputFromUserRepostionArray();
                                    break;
                                case 4:
                                    Console.WriteLine("You Are At -> 4- Max And Min In Array." + "\n");
                                    Programing1.HomeWork5.MaxMinArray();
                                    break;
                                case 5:
                                    Console.WriteLine("You Are At -> 4- A salary Calculation App." + "\n");
                                    Programing1.HomeWork5.MaxMinArray();
                                    break;
                                case 6:
                                    Console.WriteLine("You Are At -> 4- A salary Calculation App." + "\n");
                                    Programing1.HomeWork5.MaxMinArray();
                                    break;
                                case 7:
                                    Console.WriteLine("You Are At -> 4- A salary Calculation App." + "\n");
                                    Programing1.HomeWork5.MaxMinArray();
                                    break;
                                case 8:
                                    Console.WriteLine("You Are At -> 4- A salary Calculation App." + "\n");
                                    Programing1.HomeWork5.MaxMinArray();
                                    break;
                                case 9:
                                    Console.WriteLine("You Are At -> 4- A salary Calculation App." + "\n");
                                    Programing1.HomeWork5.MaxMinArray();
                                    break;
                                case 10:
                                    Console.WriteLine("You Are At -> 4- A salary Calculation App." + "\n");
                                    Programing1.HomeWork5.MaxMinArray();
                                    break;
                                case 11:
                                    Console.WriteLine("You Are At -> 4- A salary Calculation App." + "\n");
                                    Programing1.HomeWork5.MaxMinArray();
                                    break;
                                case 12:
                                    Console.WriteLine("You Are At -> 4- A salary Calculation App." + "\n");
                                    Programing1.HomeWork5.MaxMinArray();
                                    break;
                                case 13:
                                    Console.WriteLine("You Are At -> 4- A salary Calculation App." + "\n");
                                    Programing1.HomeWork5.MaxMinArray();
                                    break;
                                default:
                                    Console.WriteLine("You have Entered an invalid Choice! " + "\n");
                                    // Menu.Main(); try to bring back the user to start of the
                                    // program to input a valid choice !!!

                                    break;

                            }

                        } // End While Loop  Sub-Menu (5).

                        break; // End Fifth HomeWork Section - Sub Menu (5)

                    default: // Default HomeWork Section - Main Menu (Default)
                        Console.WriteLine("Back To Main Menu.\n");

                        break; // End Default HomeWork Section - Main Menu (Default)

                } // End of the Menu and Sub- Menu Switch Cases !!

            } // End Of While Loop Main Menu.

        }

    }
}
