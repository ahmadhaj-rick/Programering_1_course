﻿

using System;
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
            **/

            // put this into a loop using counter (N) some how ???
            int num1 = 0;
            int num2 = 1;
            int num3;
            Console.WriteLine("Enter How many numbers you would like the app to print: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("This is the Fibonacci Numbers\n");
            Console.Write(num1 + " " + num2 + " ");

            for (int counter = 0; counter <= n; counter++)
            {
                num3 = num1 + num2;
                num1 = num2;
                num2 =num3;
                // Console.WriteLine("The new value for Number2 " + num2);
                // Console.WriteLine("The new Value for Number1 " + num1);

                Console.Write(num3 + " ");

            }
        }



        public HomeWork3()
        {
        }
    }
}