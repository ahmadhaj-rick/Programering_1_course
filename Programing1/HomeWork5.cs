using System;
namespace Programing1
{
    public class HomeWork5
    {
        public static void SwitchRowsArray() // 6.1
        {

            /*
            deklarera en vektor med 4 rader, 4 kolumner.
            fyll i den med metoden random.
            byt rad nummer 2 med rad numer 3.
            Skriv ut den nya vektor.
            */

            /* help visualize the array 4x4
                 0 1 2 3
             0 { 0 1 2 3 }
             1 { 3 2 1 0 }
             2 { 0 1 2 3 }
             3 { 3 2 1 0 }

           */

            int[,] numbers = new int[4, 4]; // iniate a 4x4 array

            void RandomFill()
            {
                Random rnd = new Random();   // initatie and store the random number deivce in rnd
                int random;

                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        random = rnd.Next(0, 5);
                        numbers[i, j] = random;
                    }
                }

            }
            
            void SwapFunction()
            {
                Console.WriteLine("Select the First Row");
                int row1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Select the Second row");
                int row2 = Convert.ToInt32(Console.ReadLine());

                for (int q = 0; q < 4; q++)
                {
                    int temp = numbers[row1, q]; // makes a copy of elemnet numbers[row1, q] into temp 
                    numbers[row1, q] = numbers[row2, q]; // overrides the content of numbers[row1, q] with the content of numbers[row2, q]
                    numbers[row2, q] = temp; // finally uses the temp to override the content of numbers[row2, q]

                }

            }

            void prettyPrintArray()
            {
                Console.WriteLine("The Array is : ");
                for (int i = 0; i < 4; i++)
                {
                    Console.Write(i + "["); // shows row number 
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write("{0},", numbers[i, j]);
                    }
                    Console.Write("]");
                    Console.WriteLine();
                }

            }
            
            // Calling the Functions 
            RandomFill();
            prettyPrintArray();
            SwapFunction();
            prettyPrintArray();


        }

        public static void LettersInCharCounter() // 6.2
        {

            /*
            Läs en mening från tangentbordet.
            Konvertera den i en array ("char[] myString = Console.ReadLine().ToCharArray();" ).
            Räkna hur många gånger förekommer en visst bokstav i den mening
            (bokstaven läser du in från tangentbordet).
            Skriv det på skärmen.
            */
            int counter = 0;

            Console.WriteLine("Enter a Sentence Below to check for repeated Letters: ");
            char[] myString = Console.ReadLine().ToCharArray();

            
            Console.WriteLine("Enter The letter you want to check for!\n");
            char letter = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < myString.Length; i++)
            {
                myString[i] = Char.ToLower(myString[i]);
                //Console.WriteLine(myString[i]); ghetto debugging 
            }
           
            foreach (char c in myString) // loops trough each char in the char array 
            {
                 
                if (c == letter) // checks the letter agaisnt the char array 
                {
                    counter++; // starts from zero and adds up if the IF condition is true 
                }
            }

            Console.WriteLine("The Letter  {0}, is repeated {1} times", letter, counter);

        }

        public static void InputFromUserRepostionArray() //6.3
        {

            /*
            Skapa en vektor med 21 platser.
            Fyll i dem första 20 platserna med metoden Random.
            Fråga användare på vilken plats o vilken element ska man lägga i
            (T. Ex, på plats 5, nr. 432). Flytta alla elementen en position till höger
            o lägg i den nya elementen på rätt plats.
            Skriv ut den nya vektor på skärmen.
            */

            int[] array21 = new int[21]; // makes array of size 21 last place always empty for swap
            
            
            void RandomFill() 
            {
                Random rnd = new Random();
                int random;

                for (int i = 0; i < array21.Length - 1 ; i++) // random fill the array
                {
                    random = rnd.Next(1, 9);
                    array21[i] = random;

                }

            }

            void PrintArray()
            {               
                
                for (int i = 0; i < array21.Length; i++)
                {
                    Console.Write("{0} ", array21[i]);
                }

            }

            void SwapFunction()
            {

                Console.WriteLine("Enter the Element you want to store: ");
                int Element = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Index Where you wish to store it: ");
                int index = Convert.ToInt32(Console.ReadLine());

                int counter = array21.Length;

                for (int i = 20; i > index; i--) // moves the data to the right 
                {

                    array21[i] = array21[i - 1];

                } // when the loop exits we know the Index requested is empty 

                array21[index] = Element; // we insert the value at the index wanted 

            }

            RandomFill();
            PrintArray();
            SwapFunction();
            PrintArray();
        }

        public static void MaxMinArray()
        {

            /*
            deklarera en vektor med 20 platser, o fyll den med Random metoden,
            med siffror mellan 1 till 10.000.
            Hitta därefter min o max i den vektor o skriv den på skärmen
            */

            int[] Array = new int[20];
            int MaxNum ,MaxIndex; // this will store the MAx Value and Its Index
            int MinNum, MinIndex; // this will store the Min Value and Its Index


            void RandomFill()
            {
                Random rnd = new Random();
                int random;

                for (int i = 0; i < Array.Length; i++)
                {
                    random = rnd.Next(0, 10000);
                    Array[i] = random;

                }
            }

            void PrintArray()
            {
                Console.WriteLine();
                for (int i = 0; i < Array.Length; i++)
                {
                    Console.Write("{0} ", Array[i]);
                }
                Console.WriteLine();
            }

            void MaxMinFuncation()
            {
                MaxNum = Array[0];
                MinNum = Array[0];
                MaxIndex = 0;
                MinIndex = 0;
                Console.WriteLine();
                for (int i = 0; i < Array.Length; i++)
                {

                    if (Array[i] > MaxNum)
                    {
                        MaxNum = Array[i];
                        MaxIndex = i + 1;
                    }

                    if (Array[i] < MinNum)
                    {
                        MinNum = Array[i];
                        MinIndex = i + 1;
                    }

                }
                
                Console.WriteLine("The Max Number Is: {0} at Index : {1}. The Min Number Is: {2} at Index: {3}.", MaxNum, MaxIndex, MinNum, MinIndex);
                Console.WriteLine();

            }

            RandomFill();
            PrintArray();
            MaxMinFuncation();


        }

        public static void 

        public  HomeWork5()
        {

        }
    }
}
