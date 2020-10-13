using System;
namespace Programing1
{
    public class HomeWork2
    {
        public static void CompTwoNums() //3.1 
        {
            /**
            1.Vi läser från tangentbordet 2 nummer.Visa på skärmen vilket är mindre;
            **/
            Console.WriteLine("Please Enter Two numbers to compare and find the lowest vaule: ");

            double num1 = Convert.ToDouble(Console.ReadLine());

            double num2 = Convert.ToDouble(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("The lowest vaule is: " + num2);
            }
            else
            {
                Console.WriteLine("The lowest Value is: " + num1);
            }

            Console.ReadLine();


        }

        public static void Comp3Nums() // 3.2
        {
            /**
            2.Vi läser från tangentbordet 3 nummer.Visa på skärmen vilket är minst.
            Läs ett nummer från tangentbordet.Kolla om det är positiv eller negativ.
            **/

          Console.WriteLine("Please Enter Three numbers to compare and find the lowest vaule: ");

            // Storing input 
            double num1 = Convert.ToDouble(Console.ReadLine());

            double num2 = Convert.ToDouble(Console.ReadLine());

            double num3 = Convert.ToDouble(Console.ReadLine());

            // if statemnts section

            if (num1 < num2)
            {
                if (num1 < num3)
                {

                    Console.WriteLine("The lowest vaule is: " + num1);

                }
            }
            else if (num2 < num1)
            {
                if (num2 < num3)
                {

                    Console.WriteLine("The lowest Value is: " + num2);

                }
            }
            else
            {
                Console.WriteLine("The Lowest Value is: " + num3);
            }
            // end of if statment section

            //checking if the number is postive or negtive or 0 
            Console.WriteLine("Enter a number to check if it's negtive or postive: ");
            double num = Convert.ToDouble(Console.ReadLine());

            // if statment section 
            if (num > 0 && num != 0)
            {
                Console.WriteLine("The number " + "" + num + "" + "is positve");
            }
            else if (num < 0)
            {
                Console.WriteLine("The Number " + "" + num + "" + "is Negative");
            }
            else
            {
                Console.WriteLine("You have entered Zero");
            }
            //end of if statment section


        }

        public static void HowManyZero() // 3.3 & 3.4
        {
            /**
            * 3. Läs 3 nummer från tangentbordet och skriv om alla 3 är noll.
            * 4. Läs 3 nummer från tangentbordet och skriv om minst ett av dem är noll.
            **/
            Console.WriteLine("Enter three Number to see how Zeros is there");

            // Storing input 
            double num1 = Convert.ToDouble(Console.ReadLine());

            double num2 = Convert.ToDouble(Console.ReadLine());

            double num3 = Convert.ToDouble(Console.ReadLine());

            //if statment for if equals zero
            if ((num1 == 0) && (num2 == 0) && (num3 == 0))
            {
                Console.WriteLine("All Numbers are Zero");
            }
            else if ((num1 == 0) || (num2 == 0) || (num3 == 0))
            {
                Console.WriteLine("One of the Numbers is Zero");
            }
            else
            {
                Console.WriteLine("None of the numbers a Zero");
            }

        }

        public static void Triangle() // 3.5
        {
            /**
            5.Du läser från tangentbordet 3 sidor från en triangel.
            Säg om det är likbent eller liksidig och räkna triangelns omkrets.
            **/

           //input section for Triangle 
           Console.WriteLine("Enter The three sides of the triangle: ");

            double side1 = Convert.ToDouble(Console.ReadLine());
            double side2 = Convert.ToDouble(Console.ReadLine());
            double side3 = Convert.ToDouble(Console.ReadLine());

            //end of input section for Trianlge

            // if statment for Trianlge sides 

            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("The Triangle's Sides are all Equal !");
            }
            if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                Console.WriteLine("The Traingle has two equal sides ! ");
            }
            else
            {
                Console.WriteLine("The Traingle has no equal sides !");
            }
            // End of if statment for Triangle sides 

            //Calculating the traingle omkrets 

            double Circum = side1 + side2 + side3;
            Console.WriteLine(Circum);

            // End Of Triangle onkrets


        }

        public static void Age() // 3.6
        {
            /**
            6.Läser från tangentbordet 3 åldrar för 3 barn.
            Visa vem är äldst och mellanskillnaden mellan yngst och äldst.
            **/

            Console.WriteLine("Enter the ages of the three kids to findout who is " +
                    "the oldest and the diffrence between the oldest and the youngest");

            double child1 = Convert.ToDouble(Console.ReadLine());
            double child2 = Convert.ToDouble(Console.ReadLine());
            double child3 = Convert.ToDouble(Console.ReadLine());
            double Oldest = 0;
            double Young = 0;
            double Diff;
            //Figuring out the Oldest [IF Statments]

            if (child1 > child2)
            {
                if (child1 > child3)
                {

                    Console.WriteLine("The Oldest  is: " + child1);
                    Oldest = child1;

                }

            }
            else if (child2 > child1)
            {
                if (child2 > child3)
                {

                    Console.WriteLine("The Oldest  is: " + child2);
                    Oldest = child2;

                }
            }
            else
            {
                Console.WriteLine("The Oldest is: " + child3);
                Oldest = child3;
            }

            //Figuring out the youngest

            if (child1 < child2)
            {
                if (child1 < child3)
                {

                    Console.WriteLine("The Youngest  is: " + child1);
                    Young = child1;

                }
            }
            else if (child2 < child1)
            {
                if (child2 < child3)
                {

                    Console.WriteLine("The Youngest is: " + child2);
                    Young = child2;

                }
            }
            else
            {
                Console.WriteLine("The Youngest is:  " + child3);
                Young = child3;
            }

            // Figuring out the Difference between oldest and youngest
            
            Diff = Oldest - Young;

            Console.WriteLine("The Age Differenec Between the Oldest and Youngest is:  "
                + Diff);

        }

        public static void Winner() //3.7
        {
            /**
            7.På en tävling så måste du få poängresultaten från 2 atleter.
            Du måste visa på skärmen vem kom först och vem fick andra placering.
            **/

            Console.WriteLine("Enter First athlet points: ");
            double athlet1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second Athlet points: ");
            double athlet2 = Convert.ToDouble(Console.ReadLine());

            if (athlet1 > athlet2)
            {
                Console.Write("The First Place goes to" + "" + athlet1 + "" + "and Second place goes to" + athlet2);
            }
            else
            {
                Console.Write("The First Place goes to" + "" + athlet2 + "" + "and Second place goes to" + athlet1);
            }

        }

        public static void Result() // 3.8
        {
            /**
            8.Du få betyg från 3 elever..du måste visa deras namn/ betyg
            stigande och vissa medelvärdet på betyg;
            **/


            Console.WriteLine("Every student must enter thier names and then thier grades, one after the other! ");
            Console.WriteLine("Write Your Full Name: ");
            string name1 = Console.ReadLine();
            Console.WriteLine("Enter Your grade: ");
            double grade1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Write Your Full Name: ");
            string name2 = Console.ReadLine();
            Console.WriteLine("Enter Your grade: ");
            double grade2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Write Your Full Name: ");
            string name3 = Console.ReadLine();
            Console.WriteLine("Enter Your grade: ");
            double grade3 = Convert.ToDouble(Console.ReadLine());

            string student1 = name1 + grade1;
            string student2 = name2 + grade2;
            string student3 = name3 + grade3;

            // Figure out first Place student ( Highest Value)

            if (grade1 > grade2)
            {
                if (grade1 > grade3)
                {

                    Console.WriteLine("First Place Student is: " + " " + student1);

                }
            }
            else if (grade2 > grade1)
            {
                if (grade2 > grade3)
                {

                    Console.WriteLine("First Place Student is: " + " " + student2);

                }
            }
            else
            {
                Console.WriteLine("First Place Student is: " + " " + student3);
            }


            // Figure out second place student (Middle Value)

            if (grade1 > grade2)
            {
                if (grade2 > grade3)
                {
                    Console.WriteLine("The Second Place Goes to:  " + "" + student2);
                }
                else if (grade1 > grade3)
                {
                    Console.WriteLine("The Second Place Goes to: " + "" + student3);
                }
                else
                {
                    Console.WriteLine("The Second Place Goes to: " + "" + student1);
                }
            }
            else
            {
                if (grade1 > grade3)
                {
                    Console.WriteLine("The Second Place Goes to : " + "" + student1);
                }
                else if (grade2 > grade3)
                {
                    Console.WriteLine("The Second Place Goes to : " + "" + student3);
                }
                else
                {
                    Console.WriteLine("The Second place Goes to : " + "" + student2);
                }
            }


            // Figure out thired place student (Lowest Value)

            if (grade1 < grade2)
            {
                if ( grade1 < grade3)
                {

                    Console.WriteLine("Third Place Student is: " + "" + student1);

                }
            }
            else if (grade2 < grade1)
            {
                if (grade2 < grade3)
                {

                    Console.WriteLine("Thrid Place Student is: " + "" + student2);

                }
            }
            else
            {
                Console.WriteLine("Thrid Place Student is: " + "" + student3);
            }

        }

        public static void Equations() // 3.9
        {
            /**
            9.ax + b = 0.Om du får a och b; hitta x;
            **/
            // double Equation = a * x + b; << refernce 

            double a;
            double x;
            double b;
            int Opetion;
            Console.WriteLine("The Solve the Following Equation [ ax + b = 0 ] you need to know Two Varibles out of the Three!");
            Console.WriteLine("If you want to solve for [a], Enter [1] !");
            Console.WriteLine("If you want to solve for [x], Enter [2] !");
            Console.WriteLine("If you want to solve for [b], Enter [3] !");
            Opetion = Convert.ToInt16(Console.ReadLine());

            if (Opetion == 1)
            {
                Console.WriteLine("Enter the Value for [x]: ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter The Value for [b]");
                b = Convert.ToDouble(Console.ReadLine());
                double Equation = -b / x;
                Console.WriteLine("The Value for [a] is : " + " " + Equation);
            }
            else if (Opetion == 2)
            {
                Console.WriteLine("Enter the Value for [a]: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter The Value for [b]");
                b = Convert.ToDouble(Console.ReadLine());
                double Equation = -b / a;
                Console.WriteLine("The Value for [x] is : " + " " + Equation);
            }
            else
            {
                Console.WriteLine("Enter the Value for [x]: ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter The Value for [a]");
                a = Convert.ToDouble(Console.ReadLine());
                double Equation = -a * x;
                Console.WriteLine("The Value for [b] is : " + " " + Equation);
            }

        }

        public static void EvenOdd() // 3.10
        {
            /**
            10.Läs från tangentbordet ett tal. Skriv på skärmen om det är en jämt eller udda tal.
            **/

            double num;
            Console.WriteLine("Enter a number to Figure out if its odd or even: ");
            num = Convert.ToDouble(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("The Number entered is Even");
            }
            else
            {
                Console.WriteLine("The number enter is Odd");
            }

        }

        public static void LeapOrNot() // 3.11
        {
            /**
            11.Läs från tangentbordet ett år(4 siffror).
            Skriv hur många dagar har året(tänk på skottår eller ej).
            **/

            int year;
            Console.Write("Enter a year to figure out if its Leap year or Not: ");
            year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0 || year % 400 == 0)
            {
                Console.WriteLine("The year is a leap year!, so its 366 days");
            }
            else
            {
                Console.WriteLine("The year is not a leap year!, so its 365 days");
            }

            Console.ReadLine();

        }

        public static void BarOrBolaget() // 3.12
        {
            /**
            12.Läs från tangentbordet ålder på en person.
            Kolla om personen kan köpa alkohol i baren eller på systembolaget
            **/

            Console.WriteLine("Enter Your age to check if can buy Alcohol at a bar or Systembolaget!");
            double age = Convert.ToDouble(Console.ReadLine());

            if (age >= 20)
            {
                Console.WriteLine("You can Buy Alcohol and the Bar ");
            }
            else if (age < 20 && age >= 18)
            {
                Console.WriteLine("You can only buy Alcohol at the bar ");
            }
            else
            {
                Console.WriteLine("You are too young to buy Alcohol!!");
            }
            Console.ReadLine();


        }

        public static void MinutesToHours() // 3.13
        {
            /**
            13.Skriv ett program som ska omvandla
            antal minuter(mer en 60) till timmar/ minuter
            **/

            double hours;
            Console.WriteLine("Enter how many minutes you have to Convert it to hours! ");
            double minutes = Convert.ToDouble(Console.ReadLine());

            hours = minutes / 60;
            Console.WriteLine("You have " + " " + hours + " " + "Hours ");

        }

        public static void OldToNew() // 3.14
        {
            /**
            14.Skriv ett program som ska "omvandla" den nya betyg system till den gamla.
            F blir IG; E är G; D och C är VG och B och A är MVG.
            Programmet ska läsa från tangentbordet en betyg o skriva resultaten
            i den gamla betygssystemet("Pelle, F" blir det "Pelle är inte godkänt!") 
            **/

            Console.WriteLine("Enter Your Grade to Convert it to the new system! ");
            string grade = Console.ReadLine();
            if (grade == "F" || grade == "f")
            {
                Console.WriteLine("Your grade equals (IG) in the new system");
            }
            else if (grade == "E" || grade == "e")
            {
                Console.WriteLine("Your grade equals (G) in the new system");
            }
            else if (grade == "D" || grade == "C" || grade == "d" || grade == "c")
            {
                Console.WriteLine("Your grade equals (VG) in the new system");
            }
            else if (grade == "B" || grade == "A" || grade == "b" || grade == "a")
            {
                Console.WriteLine("Your grade equals (MVG) in the new system");
            }
            else
            {
                Console.WriteLine("The Character you entered is not a grade");
            }


        }

        public HomeWork2()
        {

        }

    }
}