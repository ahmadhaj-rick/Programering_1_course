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
                    case 6:
                        Console.WriteLine("!!Random Fill for testing the array!!");
                        RandomFill();
                        break;
                    case 7:
                        Ranking();
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
                Console.WriteLine("----------Table Of Players----------\n");

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

                //comment section broke my shit!!!!!!! moved it to seperate method
                //Copy then linear sort lowest to hightest. Ranking() funcation.
                /*
                Console.WriteLine("----------Ranking----------");
                
               
                try
                {
                    double FirstPlace=0, SecondPlace = tabel[2].Age, ThirdPlace = tabel[2].Age;
                    int FirstIndex = 0, SecondIndex = 0, ThirdIndex = 0;
                    for (int i = 0; i < tabel.Length; i++) // finding first, second and third place linear sorting
                    {
                        /*
                        if (tabel[i] != null)
                        {
                            if (tabel[i].Age < FirstPlace)
                            {
                                FirstPlace = tabel[i].Age;
                                FirstIndex = i;
                            }
                            if (tabel[i].Age < SecondPlace && tabel[i].Age < FirstPlace)
                            {
                                SecondPlace = tabel[i].Age;
                                SecondIndex = i;
                            }
                            if (tabel[i].Age < ThirdPlace && tabel[i].Age < SecondPlace)
                            {
                                ThirdPlace = tabel[i].Age;
                                ThirdIndex = i;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Row {0} is empty", i + 1);
                        }
                        */
                /*
                if (tabel[i].Age < FirstPlace)
                {
                    ThirdPlace = SecondPlace;
                    SecondPlace = FirstPlace;
                    FirstPlace = tabel[i].Age;
                    FirstIndex = i;
                }
                else if (tabel[i].Age < SecondPlace)
                {
                    ThirdPlace = SecondPlace;
                    SecondPlace = tabel[i].Age;
                    SecondIndex = i;
                }
                else if (tabel[i].Age < ThirdPlace)
                {
                    ThirdPlace = tabel[i].Age;
                    ThirdIndex = i;
                }

            }

            Console.WriteLine("1-First Place Goes To {0} at Record of {1}sec.\n2-Second Place Goes To {2} at Record of {3}sec.\n-3 Third Place Goes to {4} at Record of {5}sec.\n",
                       tabel[FirstIndex].Name, tabel[FirstIndex].Time,
                       tabel[SecondIndex].Name, tabel[SecondIndex].Time,
                       tabel[ThirdIndex].Name, tabel[ThirdIndex].Time);
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("The Tournament isn't Full thus can't make an accurate decession!!");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            Console.WriteLine("There is less than three players to give ranking!!");
        }
        */

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
                    /*
                    tabel[i].Age = randomAge;
                    tabel[i].Time = randomTime;
                    tabel[i].Name = "Debugging";
                    */
                    randomTime = rnd.Next(1, 25);
                    randomAge = rnd.Next(18, 45);
                    debugg = "Debugging " + i;
                    tabel[i] = new Players(debugg, randomAge, randomTime);
                }

                Console.WriteLine("----------Random Fill Players----------\n");

            }

            void Ranking()
            {
                Console.Clear();
                Console.WriteLine("----------RANKING----------\n");

                Players[] tmp = new Players[11];
                //tmp = tabel;
                int rank = 0;

                for (int i = 0; i < tabel.Length; i++)
                {
                    tmp[i] = tabel[i];
                    
                }
                Console.WriteLine("Copy Done!!");

                Console.WriteLine("!!Ranking!!");
                for (int i = 0; i < tmp.Length - 1 ; i++)
                {
                    for (int j = i + 1; j < tmp.Length - 1; j++)
                    {
                        /*checking for time not age dumbass!
                         * plus i need to move the whole object not just the child {age or time or name}
                        if (tmp[i].Age > tmp[j].Age)
                        {
                            tmp[10].Age = tmp[i].Age;
                            tmp[i].Age = tmp[j].Age;
                            tmp[j].Age = tmp[11].Age;

                        }
                        */
                        // checks for time and moves the whole object
                        //Linear search >>
                        if (tmp[i].Time > tmp[j].Time) 
                        {
                            tmp[10] = tmp[i];
                            tmp[i] = tmp[j];
                            tmp[j] = tmp[10];

                        }
                       

                    }
                }

                Console.WriteLine("Result.\n");
                foreach (Players players in tmp)
                {
                    rank++;

                    Console.WriteLine("Rank:{0}, Player:{1}, Age:{2}, Record:{3}sec.", rank, players.Name, players.Age, players.Time);
                }

                Console.WriteLine("----------RANKING----------\n");

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
