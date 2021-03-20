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

            int[,] numbers = new int[4,4]; // a 2D array with 4x4 
            int random;
            Random rnd = new Random();
            

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    random = rnd.Next(0, 5);
                    numbers[i,j] = random;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int J = 0; J < 4; J++)
                {
                    Console.WriteLine("Value:{0} at Index: {1} {2}", numbers[i, J], i, J);
                }
            }
            
            /*foreach (var number in numbers)
            {
                number = new Random();
            }*/


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
