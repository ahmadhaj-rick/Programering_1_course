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

        Players[] tabel = new Players[10];
        readonly int ageLimit = 18;
        
        void Run() // Head of Project You call this to trigger the rest. 
        {

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

                Option = Convert.ToInt32(Console.ReadLine());

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


        }

        // Defining Methods
        void SearchPlayers()
        {


        }

        void PrintPlayers()
        {


        }

        void AverageAge()
        {



        }

        void AddPlayers()
        {
            string inputName;
            while (true) // taking Name input
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

            int inputAge;
            while (true) // taking Age input
            {
                try
                {
                    Console.WriteLine("Enter the Age Of the Player: \n");
                    inputAge = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please Enter a number!!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

            double inputTime;
            while (true) // taking Record/Time input
            {
                try
                {
                    Console.WriteLine("Enter the Player's Record/Time: \n");
                    inputTime = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please Enter a double!!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

            Console.WriteLine("Press (y) to add the player at a certain place. Or Press (n) to add it at the first empty place.\n");
            ConsoleKeyInfo option = Console.ReadKey(true);
            switch (option.Key)
            {
                case ConsoleKey.Y:
                    int pos;
                    pos = Convert.ToInt32(Console.ReadLine());
                    if (tabel[pos - 1] == null) // check if the index is empty 
                    {
                        
                        tabel[pos - 1] = new Players(inputName, inputAge, inputTime);
                    }
                    else // in case the index isn't empty, to avoid overwriting info
                    {
                        for (int i = 0; i < tabel.Length - 1; i++)
                        {
                            if (tabel[i] == null)
                            {
                                tabel[i] = new Players(inputName, inputAge, inputTime);
                                break;
                            }
                            else
                            {
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

        void RemovePlayers()
        {



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
