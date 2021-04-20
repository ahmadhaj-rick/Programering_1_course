using System;
using System.Collections.Generic;
namespace Programing1
{
    /*
        Skapa en klass som ska inehålla följande:
        variabel - klassmedlemmar:Namn, ålder, tid

        metoder: Skriv en metod som ska skriva tävlarens namn+tid
        konstruktor som tar emot namn, ålder, tid

        Skapa en lista med 10 tävlare av klassen som du precis byggde som matas in från tangentbordet.
        gör en meny som ska ha följande alternativ:

        1. Sök tävlare (om du hittar den skriver du ut tiden och placeringen);
        2. Skriv ut alla tävlare (namn+tid+placering);
        3. Medelålder på tävlare;
        4. Add tävlare till lista;
        5. Ta bort tävlare från listan;

        Försök skriva programmet så den ska hantera undantag och felinmatning.
    */


    public class Final_Project_Run
    {

        
        public static void  Run() // Head of Project You call this to trigger the rest. 
        {
            Console.Clear();

            Players[] tabel = new Players[10]; // Main Array of type Players 
            int ageLimit = 18;

            int Option = 1;
            while (Option != 0)
            {
                Console.Write("This is the tabel of players, what would you like to do :\n" +
                              "1- Search For players.\n" +
                              "2- Print out the Whole table content.\n" +
                              "3- Get the average Age of Registered players.\n" +
                              "4- Add a Player to the tabel.\n" +
                              "5- Remove a Player from the tabel.\n" +
                              "6- Random fill for debugging.\n" +
                              "7- Ranking Players \n" +
                              "0- To Exit The Table App.\n");


                while (true)
                {
                    try
                    {
                        Option = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("Please Enter a Number from the Menu");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        
                    }
                }
                

                switch (Option)
                {
                    case 1:
                        while (true)
                        {
                            Console.WriteLine("" +
                                              "This is the Search Menu, enter a key to choose!!\n" +
                                              "[N]Show Players within a record range.\n" +
                                              "[R]Show a Player based on Rank/placemnet.\n" +
                                              "[A]Show Players within Age range.\n" +
                                              "[E] To exit to the main Menu.\n");

                            ConsoleKeyInfo charInput = Console.ReadKey(true);
                            switch (charInput.Key)
                            {
                                case ConsoleKey.N:
                                    searchTime();
                                    break;

                                case ConsoleKey.R:
                                    searchRank();
                                    break;

                                case ConsoleKey.A:
                                    searchAge();
                                    break;
                                case ConsoleKey.E:
                                    //will take you back to main menu ?? maybe ??
                                    break; 
                                default:
                                    Console.WriteLine("Please Enter an Option From the Menu!\n");
                                    continue;// this will keep you inside the swtich while break; will exit the swtich 

                            }
                            break;// this will break/exit the loop 
                        }

                        break; // the case break 

                        
                    case 2:
                        PrintPlayers();

                        break;
                    case 3:
                        AverageAge();

                        break;
                    case 4:
                        AddPlayers();

                        break;
                    case 5:
                        RemovePlayers();

                        break;
                    case 6:
                        Console.WriteLine("!!Random Fill for testing the array!!");
                        RandomFill();
                        break;
                    
                    default:
                        Console.Clear();
                        Console.WriteLine("Thank you for using our App, GoodBye!!!");
                        Environment.Exit(0);
                        break;
                }





            }

            // Defining Methods



            void searchAge() // Looks for age rang from input
            {
                Console.Clear();
                Console.WriteLine("----------Requested Player Based On Age Rank----------\n");

                try
                {
                    Console.WriteLine("Enter the first number, Where the range start: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Second number, Where the range end: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < tabel.Length; i++)
                    {
                        if (tabel[i].Time >= num1 && tabel[i].Time <= num2)
                        {
                            Console.WriteLine("{0}; Player: {1}; Age: {2}; Time: {3}", i, tabel[i].Name, tabel[i].Age, tabel[i].Time);
                        }
                    }

                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("The Table, Can't search an empty tabel!!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please Enter a number!!!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                Console.WriteLine("--------------------------------------------------");

            }




            void searchTime() // looks for records rang from input
            {
                Console.Clear();
                Console.WriteLine("----------Requested Player Based On Time Range----------\n");

                try
                {
                    Console.WriteLine("Enter the first number, Where the range start: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the Second number, Where the range end: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    for (int i = 0; i < tabel.Length; i++)
                    {
                        if (tabel[i].Time >= num1 && tabel[i].Time <= num2)
                        {
                            Console.WriteLine("{0}; Player: {1}; Age: {2}; Time: {3}", i, tabel[i].Name, tabel[i].Age, tabel[i].Time);
                        }
                    }
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("The Table, Can't search an empty tabel!!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please Enter a number!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                Console.WriteLine("--------------------------------------------------");


            }



            void searchRank() // prints out rank from input
            {
                Console.Clear();
                Console.WriteLine("----------Requested Player Based On Rank----------\n");

                try
                {
                    Ranking();
                    Console.WriteLine("Enter the Rank you would like to See!!");
                    int pos = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("{0}; Player: {1}; Age: {2}; Time: {3}");

                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("The Table, Can't search an empty tabel!!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please Enter a whole number!!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                Console.WriteLine("--------------------------------------------------");


            }

      

            void PrintPlayers()
            {
                
                Console.Clear();
                Console.WriteLine("----------Table Of Players----------\n");

                Ranking();

                int place = 0;
                foreach (Players player in tabel)
                {
                    place++;
                    if (player == null)
                    {
                        Console.WriteLine("{0}: This Row {1} is Empty", place, place);
                    }
                    else
                    {
                        Console.WriteLine("{0}: Player : {1}, Age: {2}, Time: {3}.", place, player.Name, player.Age, player.Time);
                    }
                }

                Console.WriteLine("----------Table Of Players----------\n");

            }




            void AverageAge()
            {
                Console.Clear();
                Console.WriteLine("----------Average Age Of Players----------\n");

                int avg = 0;

                try
                {
                    for (int i = 0; i < tabel.Length; i++)
                    {
                        if (tabel[i] != null) // testing if else statment might be stupid :/
                        {
                            avg += tabel[i].Age;
                        }
                        else
                        {
                            Console.WriteLine("Row {0} is empty", i);
                        }

                    }
                    avg = avg / 10;
                    Console.WriteLine("The Average age of the current Players is: {0}", avg);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

                Console.WriteLine("----------Average Age Of Players----------\n");
            }




            void AddPlayers()
            {
                Console.Clear();

                Console.WriteLine("----------Regestering Players----------\n");

                // taking Name input
                string inputName;
                while (true) 
                {
                    try
                    {
                        Console.WriteLine("Enter The Name Of the Player: \n");
                        inputName = Console.ReadLine();
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }

                // taking Age input
                int inputAge;
                while (true) 
                {
                    try
                    {
                        Console.WriteLine("Enter the Age Of the Player: \n");
                        inputAge = Convert.ToInt32(Console.ReadLine());
                        break;
                        
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Please Enter a Number!!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }

                // taking Record/Time input
                double inputTime;
                while (true) 
                {
                    try
                    {
                        Console.WriteLine("Enter the Player's Record/Time: \n");
                        inputTime = Convert.ToDouble(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Please Enter a Number!!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }

                // Inserting Values And Checking if the player is of allowed age!!

                if (inputAge >= ageLimit)
                {
                    // Give the user an option to choose the place if empty 
                    Console.WriteLine("Press (y) to add the player at a certain place. Or Press (n) to add it at the first empty place.\n");
                    ConsoleKeyInfo option = Console.ReadKey(true);
                    switch (option.Key)
                    {
                        case ConsoleKey.Y:
                            int pos;
                            while (true) // taking input of the Postion/Place {pos}
                            {
                                try
                                {
                                    Console.WriteLine("Enter the place where you want to place the player: \n");
                                    pos = Convert.ToInt32(Console.ReadLine());
                                    break;
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Please Enter a Number");
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex);
                                }
                            }


                            if (tabel[pos - 1] == null) // check if the index is empty 
                            {
                                tabel[pos - 1] = new Players(inputName, inputAge, inputTime);
                            }
                            else // in case the index isn't empty, to avoid overwriting info
                            {
                                for (int i = 0; i < tabel.Length; i++) // Linear Search for an empty place
                                {
                                    if (tabel[i] == null)
                                    {
                                        tabel[i] = new Players(inputName, inputAge, inputTime);
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Row {0}, is full. Trying next row.", i);
                                        continue;
                                    }

                                }
                            }

                            break;

                        case ConsoleKey.N:

                            for (int i = 0; i < tabel.Length; i++)
                            {
                                if (tabel[i] == null)
                                {
                                    tabel[i] = new Players(inputName, inputAge, inputTime);
                                    Console.WriteLine("Player Has been Added at row {0}", i);
                                    break;
                                }
                                else
                                {
                                    continue;
                                }

                            }
                            break;

                        default:
                            Console.WriteLine("Invalid Option, try again!");
                            break;

                    }
                }
                else // If the player is too young !!
                {
                    Console.WriteLine("The Player is too young to participate in the Tournament!!!.\n");
                }

                Console.WriteLine("----------Regestering Players----------\n");

            }



            void RemovePlayers()
            {
                Console.Clear();
                Console.WriteLine("----------Removing A Players----------\n");

                PrintPlayers(); // print the current tabel of players info 
                try
                {
                    Console.WriteLine("Choose the row to clear thus delete the player from the Table ");
                    int row = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (row < 0 || row > tabel.Length)
                    {
                        Console.WriteLine("Please Choose a number between 1 and {0}", tabel.Length);
                    }
                    else if (tabel[row] == null)
                    {
                        Console.WriteLine("The Row is alraedy empty, no player info is found");
                    }
                    else
                    {
                        Console.WriteLine("PLayer: {0} at Row: {1} has been Deleted!", tabel[row].Name, row);
                        tabel[row] = null;
                    }
                }
                catch(FormatException)
                {
                    Console.WriteLine("Please Enter a Number!!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

                Console.WriteLine("----------Removing A Players----------\n");
            }


            void RandomFill()
            {
                Console.Clear();
                Console.WriteLine("----------Random Fill Players----------\n");

                Random rnd = new Random();
                int randomTime;
                int randomAge;
                string debugg;
                for (int i = 0; i < tabel.Length; i++)
                {
                    randomTime = rnd.Next(1, 25);
                    randomAge = rnd.Next(18, 45);
                    debugg = "Debugging " + i;
                    tabel[i] = new Players(debugg, randomAge, randomTime);
                }

                Console.WriteLine("----------Random Fill Players----------\n");

            }
            
            void Ranking()
            {
                try
                {
                    for (int i = 0; i < tabel.Length; i++)
                    {
                        for (int j = i + 1; j < tabel.Length; j++)
                        {
                            // checks for time and moves the whole object
                            if (tabel[i].Time > tabel[j].Time) //Linear search >>
                            {
                                var Tmp = tabel[i];
                                tabel[i] = tabel[j];
                                tabel[j] = Tmp;

                            }


                        }
                    }
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("No Ranks to show Table is empty");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

            }


        }


    }

   

    class Players // the Object (Players) class
    {
        private string name;
        private int age;
        private double time;
        


        public Players(string _name, int _age, double _time)
        {
            this.Name = _name;
            this.Age = _age;
            this.Time = _time;
        }


        public string Name
        {
            get { return name; }

            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value;}
        }

        public double Time
        {
            get { return time; }
            set { time = value; }

        }

    }

}
