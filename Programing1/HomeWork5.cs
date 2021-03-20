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





        }

        public static void MaxMinArray()
        {

            /*
            deklarera en vektor med 20 platser, o fyll den med Random metoden,
            med siffror mellan 1 till 10.000.
            Hitta därefter min o max i den vektor o skriv den på skärmen
            */




        }



        public  HomeWork5()
        {

        }
    }
}
