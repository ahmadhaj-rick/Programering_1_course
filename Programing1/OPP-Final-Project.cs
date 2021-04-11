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

            Players[] tabel = new Players[10];
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
                        SearchPlayers();

                        break;
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
                    default:
                        Console.Clear();
                        Console.WriteLine("Thank you for using our App, GoodBye!!!");
                        Environment.Exit(0);
                        break;
                }





            }

            // Defining Methods
            void SearchPlayers()
            {
                Console.Clear();



                Console.WriteLine("--------------------------------------------------");
            }

            void PrintPlayers()
            {
                /*
                for (int i = 0; i < tabel.Length; i++)
                {
                    Console.WriteLine("Player : {0}, Age: {1}, Time: {3}");
                }
                */
                Console.Clear();
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
                Console.WriteLine("--------------------------------------------------");
            }

            void AverageAge()
            {
                Console.Clear();


                Console.WriteLine("--------------------------------------------------");
            }

            void AddPlayers()
            {
                Console.Clear();
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
                                for (int i = 0; i < tabel.Length - 1; i++) // Linear Search for an empty place
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

                            for (int i = 0; i < tabel.Length - 1; i++)
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
                else
                {
                    Console.WriteLine("The Player is too young to participate in the Tournament!!!.\n");
                }




                Console.WriteLine("--------------------------------------------------");
            }

            void RemovePlayers()
            {
                Console.Clear();
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

                Console.WriteLine("--------------------------------------------------");
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
