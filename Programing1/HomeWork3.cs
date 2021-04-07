

using System;
using System.Collections.Generic;

namespace Programing1
{
    public class HomeWork3
    {
        
        public static void Steps() // 4.1 
        {
            /**
            1. Konstruera ett program som ber om inmatning för "start", "stop" och "steg".
            Programmet skall sedan baserat på inmatningen göra en for-loop och skriva ut
            de tal som finns mellan start och stopp med den steg som användare
            väljer(t.ex.om vi har 4, 12 och steg 3 så blir det 4, 7, 10)
            **/

            Console.WriteLine("Enter The Starting Point: ");
            int Start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Stopping Point: ");
            int Stop = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter How many steps Point: ");
            int steps = Convert.ToInt32(Console.ReadLine());

            if (steps != 0) // SafeGuard Against Infinit Zeros.
            {

                for (int counter = Start; counter <= Stop; counter += steps)
                {

                    Console.WriteLine(counter);

                }
            }
            else
            {
                Console.WriteLine("You have entered 0 steps");
            }

            
        }

        public static void CountingUp2Input() // 4.2
        {

            /**
            2.Skriv ett program som läser in ett positivt heltal.
            Programmet skall sedan summera alla tal från 1 till och
            med det inmatade heltalet
            **/

            Console.WriteLine("Entere the Number you want to count up to: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int counter = 1;
            if (num > counter)
            {
                for (counter = 1 ; counter <= num; counter++)
                {
                    Console.WriteLine(counter);

                }
            }

            
        }

        public static void CountingUp2Input2() // 4.3
        {

            /**
            3.Skriv ett program som läser in ett positivt heltal.
            Lista sedan alla tal från 1 till det inmatade talet
            som är jämt delbart med både 3 och 7.Om inga tal hittats
            så skall detta skrivas ut(använd operatören %);
            **/


            Console.WriteLine("Input a Number to check if its dividable by 3 and 7, then count up to it: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {

                if (num % 3 == 0 && num % 7 == 0)
                {
                    for (int counter = 1; counter <= num; counter++)
                    {
                        Console.WriteLine(counter);

                    }
                }
                else
                {
                    Console.WriteLine("The number you entered Can't be Divided by 3 and 7!");
                }
            }
            else
            {
                Console.WriteLine("You have entered a zero or a negtive number!");
            }
        }

        public static void FibonacciSequence() // 4.4
        {
            /**
            4.Skriv ett program som listar de N första talen i Fibonacci serien
            **/

            /**
            the logic is the sequnce start with 0 and then 1, those two number are
            then added so 0 + 1 = 1 > 1 + 1 = 2 > 1 + 2 = 3 > 2 + 3 = 5 > 3 + 5
            so after starting the Sequenc by adding 0 and 1
            we add last number with the new result.
            we need two num varibles and num3/result to store the addition then 
            we swap value of num2 into num1 and num3/result into num2 then loop the addition ?????
            put this into a loop using [counter < (N)] some how ???
            **/

            int num1 = 0;
            int num2 = 1;
            int num3;
            Console.WriteLine("Enter How many numbers you would like the app to print: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("This is the Fibonacci Numbers\n");
            Console.Write(num1 + " " + num2 + " ");

            for (int counter = 0; counter < n; counter++)
            {
                num3 = num1 + num2;
                num1 = num2;
                num2 = num3;

                Console.Write(num3 + " ");
            }
        }

        public static void PrimeCheck() //4.5
        {
            /**
            5.Skriv ett program som undersöker om ett heltal är ett primtal eller inte.
            Du måste alltså undersöka om det finns något tal mellan 1 och heltalet
            som ger en jämn division med heltalet.Om det finns en jämn division så är heltalet inte ett primtal.
            Tips: Använd operatorn %.
            **/

            Console.WriteLine("Enter a Whole number to check if its prime or not: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (IsPrime(num))
            {
                Console.WriteLine("The Number entered is Prime");
            }
            else
            {
                Console.WriteLine("The number is not Prime");
            }


            static bool IsPrime(int num)
            {
                if (num == 0) { return false; }
                if (num == 1) { return false; }
                if (num == 2) { return true; }

                for (int counter = 2; counter <= Math.Sqrt(num); counter++)
                {
                    if (num % counter == 0) { return false; }
                }

                return true;
            }

        }

        public static void CalcNumN() // 4.6
        {
            /**
            6.Läs ett nummer från tangentbordet. Räkna n!(1 * 2 * 3 *?.* n)
            **/
            int result1 = 1;
            int result2 = 1;
            int num;
            Console.WriteLine("Enter a number to Calculate n = (1 * 2 * 3 * n");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Path 1 - While Loop");
            int j = 1;
            while (j <= num)
            {
                result1 = result1 * j;
                j++;
                Console.WriteLine(result1);
            }

            Console.WriteLine("Path 2 - For Loop");
            for (int i = 1; i <= num; i++)
            {
                result2 = result2 * i;
                Console.WriteLine(result2);

            }
            

        }

        public static void CalcNumN2() // 4.7
        {
            /**
            7.Läs ett nummer från tangentbordet. Räkna o skriv 
            på skärmen 1 + 1 * 2 + 1 * 2 * 3 +?.+ 1 * 2 * 3 *? *n;
            **/






        }

        public static void RangePrimNum() //4.8
        {

            // 8. Utgår från punkt 5 och skriv alla primtal mellan 2 nummer du läser från tangentbordet.

            //num > 5 and between num1 and num2

            int num = 5;
            Console.WriteLine("Enter the First number of the Range");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second number of the range");
            int num2 = Convert.ToInt32(Console.ReadLine());


            

            if (num1 >= num)
            {
                
                for(int counter = num; counter <= num2; counter++)
                {
                    if (IsPrime(counter))
                    {
                        Console.WriteLine("The Number " + counter + " Is a Prime number ");
                    }
                    

                }

            }


            static bool IsPrime(int num)
            {
                if (num == 0) { return false;}
                if (num == 1) { return true; }
                if (num == 2) { return true; }

                for (int counter = 2; counter <= Math.Sqrt(num); counter++)
                {
                    if (num % counter == 0) { return false; }
                }

                return true;
            }


        }

        public static void Alphabet() // 4.9
        {

            // 9. Skriv hela alfabetet på skärmen

            Console.WriteLine("This Small script prints out the Alphabet into the screen");
            Console.WriteLine("Accessing a List Index every Letter gets printed out \n");

            var Alphabet = new List <string>()
            {
                
                "A","B","C","D","E","F","G","H","I","J","K",
                "L","M","N","O","P","Q","R","S","T","U","V","W",
                "X","Y","Z",

            };

            for (int i = 0; i < Alphabet.Count; i++)
            {
                Console.Write(" " + Alphabet[i] + " ");
            }
        }

        public static void MulitTable() // 4.10
        {
            // 10. Skriv på skärmen multiplikationstabellen 1-15.

            int num1 = 1;
            int num2 = 15;

            for (int i = 0; i < num2; i++)
            {
                int result = i * num1;
                Console.WriteLine(result);

            }


        }

        public static void PowerTo() // 4.11
        {
            Console.WriteLine("Enter the base number! ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Power number");
            int pow = Convert.ToInt32(Console.ReadLine());
            int result = num;
            for (int i = 1; i < pow; i++)
            {

                result *= num;
               
            }
            Console.WriteLine(result);

        }

        
    }
}