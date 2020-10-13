using System;
namespace HomeWorkMenu
{
    class Menu
    {
       private static void Main(string[] arg)
        {
            int Main_option = 1;
            while (Main_option != 0) //While Loop Main Menu.
            {


                // Console.WriteLine("Choose an Opetion to execute! ");
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
                    "\n" +
                    "4- Methods          -> 1- ....Work in Progress\n" +
                    "                    -> 2- ....Work in Progress\n" +
                    "\n" +
                    "5-Vectors And Lists -> 1- ....Work in Progress\n" +
                    "                    -> 2- ....Work in PRogress\n");

                Main_option = Convert.ToInt16(Console.ReadLine());

                // Menu and Sub-Menu To choose which home work to execute!
                switch (Main_option)
                {
                    case 1: // First HomeWork Section - Main Menu (1)


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

                        break; // End First HomeWork Section - Main Menu (1)

                    case 2: // Second HomeWork Section - Main Menu (2)

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


                        break; // End Second HomeWork Section - Main Menu (2)

                    case 3: // Third HomeWork Section
                            // Console.WriteLine("You Here 3_1");

                        int Option_3 = 1;
                        while (Option_3 !=0)  // While Loop Sub-Menu (3).
                        {

                            Console.WriteLine("\n" +
                                              "3- Loops For/While  -> 1- Start, Step and Stop\n" +
                                              "                    -> 2- Counting up to the number inputed\n" +
                                              "                    -> 3- Counting up to the number inputed,Check dividable by 3 & 7\n" +
                                              "                    -> 4- Printing the (N) numbers of the Fibonacci Sequence\n" +
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

                                default:
                                    Console.WriteLine("You have Entered an invalid Choice! ");
                                    // Menu.Main(); try to bring back the user to start of the
                                    // program to input a valid choice !!!
                                    break;

                                    /**
                                    Console.WriteLine("You Are At ->   + "\n");
                                    **/
                            }

                        } // End While Loop Sub-Menu (3).
                        

                        break; // End Third HomeWork Section - Main Menu (3)

                    default: // Default HomeWork Section - Main Menu (Default)
                        Console.WriteLine("You have Entered an invalid Choice! ");

                        break; // End Default HomeWork Section - Main Menu (Default)

                } // End of the Menu and Sub- Menu Switch Cases !!

            } // End Of While Loop Main Menu.

        }

    }
}
