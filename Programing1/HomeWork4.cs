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


        public static void SumUpToPrim() // 5.2
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

        public static void TvSize() // 5.3
        {
            /**
             Calle vill köpa en tv, men, vet inte om han får plats med den. Du ska göra ett program som ska räkna hur stort en wide screen tv är, beroende på diagonalen.
             Diagonalen ska matas in i tum och resultaten ska skrivas i cm.
             Widescreen betyder att tvn har en skala som är 16:9 eller för 9 enheter på höjden har vi 16 enheter på bredden.
             Du kommer att behöva papper o penna :) o Pytagorassatsen!!
            **/

            /**
              i can't implemnt >>> let X be the width , let y be the height. to calc x => [x = (arh * y) / arw ] . to calc y => [y = (arw * x ) / arh] , a  
              
              easier to implemnt >>>> aspect ratio W:H, the [width = W * X] , [height = H * X ] , where x is a base relitve number to both. 
              let D be the diagnol > sqrt(d) = sqrt(W * X) + sqrt(H * X) >> x = d / sqrt(W + H) . we find X and use it.   
            **/
            // Varibels section !!

            double h; // height
            double w; // width 
            double d; // diagnol
            double arw; // ration for width ex : 16
            double arh; // ratio for hieght ex : 9

            // End of Varibels sections

            // Taking input Value from user

            Console.WriteLine("Enter the Diagnol size : ");
            d = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the First Value of the Aspect Ratio: ");
            arw = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second Value of the Aspect Ratio: ");
            arh = Convert.ToDouble(Console.ReadLine());

            // End of Input Value from user 

            // Logic 


            double ratio1 = Math.Pow(arw,2) + Math.Pow(arh,2); // Calculating the sum of the power to 2 of the ratio
            // Console.WriteLine(ratio1); ghetto debugging xD
            
            double common = Math.Sqrt(ratio1); // Square rooting the sum of the ratio 
            //Console.WriteLine(common); ghetto debugging xD

            double rationDia = d / common; // Dividing the Diagnol on the square root of the sum of the ratio >> gives us X the reltive number. 
            //Console.WriteLine(rationDia); ghetto debugging xD

            w = rationDia * arw; // use X to figure out the Width 
            h = rationDia * arh; // use X to figure out the Height 

            Console.WriteLine("The Width of the TV is : " + w + "\n");
            Console.WriteLine("The Height of the TV is : " + h + "\n");



        }
        public static void GuessingGame() // 5.4
        {

            /**
             
            Dator slupar fram ett numer (se forumet för hur man gör). Du ska skapa ett program som ska visa ett meny:
            1. Spela
            2. Visa resultat
            3. Quit
            Spela ska vara ett metod som har inparameter namn. Metoden ska slumpa fram ett numer, och utmana spelaren att gissa ett tal.
            Om talet är för lågt eller för högt man få meddela, och när spelaren gissar rätt så man ska säga efter hur många försök +
            man ska skriva resultaten i en textfil (se forumet för hur man skriver i en textfil). 
            I textfilen  skriver du Namn och antalFörsök
            Visa resultat -ett metod med varken in eller utparameter som ska skriva ut textfilen på skärmen
            Man ska visa "spelmeny" tills användare trycker på 3.

            **/

            int RandNum = new Random().Next(0, 20);
            int GuessCounter = 0;
            int inputGuess = -1;
            
            Console.WriteLine(RandNum); // ghetto debugging
            Console.WriteLine("This is a Guess the Number Game, the number is between [0-20].\n" +
                    "The Game Will tell you if you guessed too low or too high. You only have 4 Guesses.");

            while (GuessCounter != 4 && inputGuess != RandNum)
            {
                
               
                Console.WriteLine("Please Enter your guess Between [0 - 20]");
                GuessCounter++;
                var UserInput = Console.ReadLine(); // Varible that used in the TryParse function 

                if (CheckInput(UserInput))
                {
                    CheckAnswer(inputGuess);
                }
                else
                {
                    Console.WriteLine("You have entered {0}, Which is not a valid number", inputGuess);
                }

                
                Console.WriteLine("You have tried {0}", GuessCounter);

            }

            bool CheckInput(string UserInput) // checks if the user entered a number. returns out a boolean value
            {                                   // returns a True or False to help in the If Else statment.

                if (int.TryParse(UserInput, out inputGuess)) // takes in the input and sends it out to inputguess 
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            

            void CheckAnswer(int input) // checks the answer funcation 
            {

                if(input == RandNum) // win condition
                {
                    Console.WriteLine("You Won, You Entered: " + input + " And The Random Number Is: " + RandNum);
                }
                else if (GuessCounter == 4) // lose condtion
                {
                    Console.WriteLine("You lost, You Entered: " + input + " And The Random Number Is: " + RandNum);
                }
                else // checks too low or too high 
                {
                    if (input < RandNum) // too low condition
                    {
                        Console.WriteLine("You went too low, You Entered: " + inputGuess);
                    }
                    else  // too high condition
                    {
                        Console.WriteLine("You went too high, You Entered: " + inputGuess);
                    }
                }
            }




        }

        public static void PrimCounter()
        {
            /**
             
            Gör ett program som ska skriva på skärmen de första "x" antal primtal. 
            Det är användare som "bestämmer" hur stort x ska vara. 
            Du skall använda en metod som säger om ett nummer är primtal eller ej
            Exempel:
            Användaren skriver 10, då ska din program skriva på skärmen: 
            1, 2, 3, 5, 7, 11, 13, 17, 19, 23

            **/


            static bool IsPrime(int num)
            {
                if (num == 0) { return false; }
                if (num == 1) { return false; }
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
