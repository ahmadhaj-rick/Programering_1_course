using System;
namespace Programing1
{
    public class HomeWork4
    {


        public static void MethodTypes() // 5.1 
        {

            /**
            Skriv ett program som ska innehålla alla 4 typer av metoder
            (utan in/ut-data, med indata, med utdata och med in och ut-data)
            Forslag:Gör ett meny:
            1. Metod utan in/utdata
            2. Metod med indata
            3. Metod med utdata
            4. Metod med in/utdata
            5. Exit
            **/


            static void Method_No_InOrOut()
            {
                Console.WriteLine("This is an Exmple of a Method that dont take any argument" +
                    "henc Method With no Input or Output");

            }

            static void Method_With_InputOnly(string name)
            {
                Console.WriteLine("Hello" + name);
                Console.WriteLine("This is an example of a method that only takes in an argument but dont give back an Output" +
                    "in other words nothing is done to the argument passed to it but used as is");

            }

            static void Method_With_OutputOnly()
            {

                Console.WriteLine("Sup");

            }

            static int Method_With_InAndOutPut(int num1, int num2)
            {

                int result = num1 + num2;
                return result;

            }

            Method_No_InOrOut();

            Method_With_InputOnly(Console.ReadLine());

            Method_With_OutputOnly();

            Method_With_InAndOutPut(4, 6);


        }


        public static void SumUpToPrim()
        {
            /**
            Be användare att ange ett nummer. Du ska summera alla primtal fram till den nummer.
            Till exempel: 30, du ska summera 1+2+3+5+7+11+13+17+19+23+29 = 130
            Du ska använda metoder för att göra det.
            **/

            int counter = 0;
            int result = 0;
            int result2 = 0;
            //int result;
            Console.Write("Enter a number to count up to and sum all the primes in between! : .. ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            // sincec i'm stubborn this is the while do method :3 
            do
             {
                //int counter = 1:
                //int result = 0;
                if (IsPrime(counter))
                {
                    //Console.WriteLine(result + "result Stage1\n");
                   // Console.WriteLine(counter + "counter Stage1\n");
                    
                    result += counter;
                    counter++;
                   
                    //Console.WriteLine(result + "result Stage2\n");
                    //Console.WriteLine(counter + "counter Stage2\n");
                }
                else
                {
                    counter++;
                    //Console.WriteLine(counter + "not prime!\n");
                }
             } while (counter != num);
            
            Console.WriteLine("the sum of primes up to " + num + " is " + result);
            //end of the while do method xD

            // this is the for loop method 

            for (int i = 1; i <= num; i++)
            {
                if (IsPrime(i))
                {
                    
                    result2 += i;
                }
            }
            
            Console.WriteLine("the sum of primes up to " + num + " is " + result2);

            //end of the for loop method
            static bool IsPrime(int num)
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


        }




    }

}
