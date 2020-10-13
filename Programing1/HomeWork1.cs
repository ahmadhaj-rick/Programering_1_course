using System;
namespace Programing1
{
    public class HomeWork1
    {
        public static void SumTwoNums() // 2.1
        {
            /**
            1- Skapa ett program där man matar in två tal,
            sedan lägger programmet ihop dessa tal o skriver resultaten i konsolen.
            **/

            Console.WriteLine("Please enter First number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter second Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = num1 + num2;

            Console.WriteLine("The Sum of " + " " + num1 + " + " + num2 + " " + "Equals = " + result);
            Console.ReadLine();
        }


        public static void Sum3NumsAndMedium() // 2.2
        {
            /**
            2- Skapa ett program där man matar in tretal, sedan lägger programmet ihop
            dessa tal o skriver resultaten i konsolen.Räkna medelvärdet av de 3 tal
            i en variabel o skriv den i konsolen.
            **/

           Console.WriteLine("Please enter First number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter second Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the third Number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int result = num1 + num2 + num3;
            int medium = result / 3;

            Console.WriteLine(result);
            Console.WriteLine(medium);
            Console.ReadLine();
        }


        public static void DecToWhole() // 2.3
        {
            /**
            3- Skapa ett program som omvandlar ett inmatat
            decimaltal till närmasta heltal
            **/

            Console.WriteLine("Enter a Decimal Number to convert to a whole number: ");
            decimal num = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine(Convert.ToInt32(num));
            Console.ReadLine();
        }

        public static void SalaryCalc() // 2.4
        {
            /**
            Skriv ett program som kan läsa in 5 löner och sedan beräkna
            medellön(avrunda till närmaste heltal).Om vi har en skatt på 32 %,
            skriv i konsolen hur mycket av lönen går till skatt, och hur mycket
            kommer man att få som nettolön(pengar i handen).Om man får en lönehöjning
            på 10 % hur mycket blir det den nya lönen? och hur mycket kommer det att
            gå till skatt? nettolön? :D
            **/

            // Reading input from user Start 
            Console.WriteLine("Enter The First salary: ");
            double sal1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter The Second salary: ");
            double sal2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter The Third salary: ");
            double sal3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter The Fourth salary: ");
            double sal4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter The Fifth salary: ");
            double sal5 = Convert.ToDouble(Console.ReadLine());
            // Reading input from user End 


            // the varibles seciton Start
            double tax = 0.32;
            double sumBeforeTax = Convert.ToDouble(sal1 + sal2 + sal3 + sal4 + sal5);
            double medium = Convert.ToInt32(sumBeforeTax / 5);
            double sumAfterTax = sumBeforeTax * tax;
            double taxation1 = sumBeforeTax - sumAfterTax;

            // Varibles after the 10% raise
            double tenPercentUp = 1.10;
            double raiseSalary = Convert.ToInt32(sumBeforeTax * tenPercentUp);
            double raiseTaxSalary = Convert.ToInt32(raiseSalary * tax);
            double taxation2 = Convert.ToInt32(raiseSalary - raiseTaxSalary);

            // Varibels secition Ends 

            // Printing output Section Start 
            Console.WriteLine("The Five Salaries That have been inputed are: " + sal1 + " " + sal2 + " " + sal3 + " " + sal4 + " " + sal5 + " " + "The Tax is: " + tax);
            Console.WriteLine("The Medium is: " + medium);

            Console.WriteLine("The Salary After Tax is : " + sumAfterTax);
            Console.WriteLine("The Ammount that goes to the Tax Agency: " + taxation1);

            // Output After Raise 

            Console.WriteLine("The Salaries after the 10% Rasie is : " + raiseSalary);
            Console.WriteLine("The New Salaries Taxation is : " + raiseTaxSalary);
            Console.WriteLine("The New Ammount that goes to the Taxing Agency is : " + taxation2);

            // Printing output Section End


            Console.ReadLine();  // wait for input to exit the program 

        }


        public void SomeMethod()
        {

        }


    }
}
