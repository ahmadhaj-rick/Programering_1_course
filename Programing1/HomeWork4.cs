using System;
namespace Programing1
{
    public class HomeWork4
    {


        public static void MethodTypes() // 5.1 
        {

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

                Console.WriteLine("");

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


        public static void HomeWork3()
        {



        }




    }

}
