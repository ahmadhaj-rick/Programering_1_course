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

        public static void MaxMinArray() // 6.4
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

        public static void CountNegtivePostiveNums() // 6.5 
        {

            /*
             * skapa en vektor med 30 platser, och fyll i den med random (-100, 100).
             * Räkna hur många positiva o negativa elementen finns i vektor o skriv ut det på skärmen.
             */


            int[] array30 = new int[30];

            void RandomFill()
            {
                Random rnd = new Random();
                int random;

                for (int i = 0; i < array30.Length; i++)
                {
                    random = rnd.Next(-100, 100);
                    array30[i] = random;

                }

            }


            void PrintArray()
            {

                for (int i = 0; i < array30.Length; i++)
                {

                    Console.Write("{0} ", array30[i]);
                    
                }
                Console.WriteLine();
            }

            void counting()
            {
                int Neg = 0 ;
                int Pos = 0 ;
                int Zero = 0;
                for (int i = 0; i < array30.Length; i++)
                {

                    if (array30[i] > 0)
                    {
                        Pos++;
                    }
                    if (array30[i] < 0)
                    {
                        Neg++;
                    }
                    if (array30[i] == 0)
                    {
                        Zero++;
                    }

                }

                Console.WriteLine("The Amount of Postive Numbers is : {0}, And the Ammount of Negtive numbers is {1}, The Ammount of Zeros is : {2}", Pos, Neg, Zero);

            }


            RandomFill();
            PrintArray();
            counting();



        }

        public static void MirroFlipArray() //6.6
        {

            /*
             * Vi har en vektor med 51 platser. 
             * Vi ska byta platserna mellan första o sista platsen,
             * andra o näst sista osv.. Skriv på skärmen den nya vektor
             */

            int[] array = new int[51];
            void RandomFill()
            {
                int random;
                Random rnd = new Random();

                for (int i = 0; i < array.Length; i++)
                {
                    random = rnd.Next(0, 100);
                    array[i] = random;

                }

            }

            void PrintArray()
            {

                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write("{0} ", array[i]);
                    
                }
                Console.WriteLine();
            }

            void MirroFlip() // i can use the Array.Reverse() Methond too, felt like writing simple version myself
            {

                
                for (int i = 0; i < array.Length / 2 ; i++) // we dont need to loop through the whole array we just need to loop the first part
                {                                           // [array.length / 2]. if we loop through whole, it reverse back to the original state.
                    int tmp = array[i];                     // almost killed my self figuring out what is happening :) the logic was right 
                    array[i] = array[array.Length - i - 1]; // but the implemntion missed something hence [array.lenght / 2]
                    array[array.Length - i - 1] = tmp;

                }

            }

            RandomFill();
            PrintArray();
            MirroFlip();
            PrintArray();



        }

        public static void SortLowestToHighest() // 6.7
        {
            /*
             * deklarera en vektor med 30 platser. 
             * Fyll i vektorn med metoden random. Sortera därefter vektorn stigande, 
             * med minsta värde på plats 0 och högsta på plats 30.
             * Skriv ut den nya vektor på skärmen
             */

            int[] array = new int[30];

            void RandomFill()
            {
                Random rnd = new Random();
                int random;

                for (int i = 0; i < array.Length; i++)
                {
                    random = rnd.Next(0, 100);

                    array[i] = random;

                }
            }

            void PrintArray()
            {

                for (int i = 0; i < array.Length; i++)
                {

                    Console.Write("{0} ", array[i]);

                }
                Console.WriteLine();

            }

            void Sort() // You can use Array.Sort() instead this is a ghetto way, compare an element to all next elemetns. 
            {


                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i + 1; j < array.Length; j++) // [j] the Element Next/After to [i] Element
                    {
                        if (array[i] > array[j])
                        {
                            int tmp = array[i];
                            array[i] = array[j];
                            array[j] = tmp;

                        }

                    }

                }

            }


            RandomFill();
            PrintArray();
            Sort();
            PrintArray();




        }

        public static void SumOfElements() //6.8
        {

            /*
             * skapa en vektor med 20 platser. 
             * Fyll i med metoden random. Skriv på skärmen summan av alla elementen från vektor.
             */

            int[] array = new int[20];


            void RandomFill()
            {
                Random rnd = new Random();
                int random;

                for (int i = 0; i < array.Length; i++)
                {
                    random = rnd.Next(0, 10);
                    array[i] = random;

                }
            }

            void PrintArray()
            {

                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write("{0} ", array[i]);
                }
                Console.WriteLine();
            }

            void SumOf()
            {
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {

                    sum += array[i];

                }
                Console.WriteLine("The Sum Of All Elemetns is : {0}", sum);
            }

            RandomFill();
            PrintArray();
            SumOf();


        }


        public static void ShiftingAndZeroing() //6.9
        {
            /*skapa en vektor med 30 platser. Fyll i vektor med metoden Random.
             * (1) ta bort elementen från plats 11 till plats 20, 
             * (2) flytta elementen från plats 21-30 på platserna som blev lediga, 11-20. 
             * (3) Fyll i sedan platserna 21-30 med 0 o skriv ut slutresultaten på skärmen
             */

            int[] arr = new int[30];

            void RandomFill()
            {
                Random rnd = new Random();
                int random;

                for (int i = 0; i < arr.Length; i++)
                {
                    random = rnd.Next(0, 10);
                    arr[i] = random;

                }
            }



        }

        public static void ShiftCenterToLeft() // 6.10
        {
            /*Deklarera en vektor med 21 platser. 
             * fyll i med metoden random med siffror mellan 1-1000. 
             * Ta bort elementen från mitten av vektorn (plats 10). 
             * Flytta alla elementen efter plats 10 till vänster en positionering 
             * och fyll i sista platsen med 0.
             * Därefter skriv "den nya" vektor på skärmen.
             */


        }

        public static void OddOrEvenElement() // 6.11
        {
            /* Skapa en vektor med 50 platser, fyll i med random.
             * Skriv sedan hur många udda o hur många jämna nummer innehåller vektorn.
             */

            int[] arr = new int[50];

            void RandomFill()
            {

                Random rnd = new Random();
                int random;

                for (int i = 0; i < arr.Length; i++)
                {

                    random = rnd.Next(1, 100);
                    arr[i] = random;

                }

            }

            void PrintArr()
            {

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write("{0} ", arr[i]);
                }
                Console.WriteLine();
            }

            void OddOrEven()
            {
                int Odd = 0;
                int Even = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        Even++;
                    }
                    else
                    {
                        Odd++;
                    }

                }

                Console.WriteLine("The Amount of Odd's is :{0}, And Even's is : {1} .", Odd, Even);


            }


            RandomFill();
            PrintArr();
            OddOrEven();


        }

        public static void PrimeOrNahElement() //6.12
        {
            /* skapa en vektor med 40 element, fyll i den med metoden random.
             * Skapa en metod primtal, som säger om ett numer är prim eller inte. 
             * Kolla sen med hjälp av den metoden hur många element i vektor är primtal eller ej. 
             * Skriv sedan resultatet på skärmen (antal primtal nummer, antal ikke primtal)
             * Metoden primtal ska ha som indata ett numer och som utdata en boolean!
             */

            int[] arr = new int[40];

            void RandomFil()
            {
                Random rnd = new Random();
                int random;

                for (int i = 0; i < arr.Length; i++)
                {
                    random = rnd.Next(1, 100);
                    arr[i] = random;
                }
            }


            void CountType()
            {
                int Pri = 0;
                int Odd = 0;


                for (int i = 0; i < arr.Length; i++)
                {
                    if (IsPrime(arr[i]) == true)
                    {
                        Pri++;
                    }
                    if (IsPrime(arr[i]) == false)
                    {
                        Odd++;
                    }

                }
                Console.WriteLine("The Amount of Prime's is : {0}, The Ammount Of Odd's is : {1} .", Pri,Odd);

            }


            void PrintArr()
            {

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write("{0} ", arr[i]);
                }
                Console.WriteLine();
            }

            bool IsPrime(int num)
            {
                if (num == 0) { return false; }
                if (num == 1) { return true; }
                if (num == 2) { return true; }

                for (int counter = 2; counter < num; counter++)
                {
                    if (num % counter == 0) { return false; }
                }

                return true;
            }

            RandomFil();
            PrintArr();
            CountType();


        }

    }

}
