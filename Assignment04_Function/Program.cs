using System.Reflection.Metadata;
using System.Reflection;
using System.Threading.Channels;

namespace Assignment04_Function
{
    internal class Program
    {

        #region 3-Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

        public static void sumsub(int num01, int num02, int num03, int num04, out int sum, out int sub)
        {
             sum = num01 + num02;
             sub = num01 - num02;

            //return new { sub, sum };

        }

        #endregion
        
        #region 4-Write a program in C# Sharp

        public static int Sum(ref int[] arr)
        {
            int sum = 0;

            if (arr != null)
            {
                for (int i = 0; i < arr.Length; i++)
                    sum += arr[i];
            }
            return sum;

        }

        #endregion

        #region 5-Create a function named "IsPrime"

        public static object sPrime(int Num)
        {
            int i = 2;

            if (Num % i == 0)
            {
                
                return "true";

            }
            else
            {
                return "false";
            }

        }
        #endregion

        #region 7-Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
        public static void nonrecursive(int Num)
        {
            for (int i = 1; i <= Num; i++)
            {
                Console.WriteLine($"{Num}");

            }
        }
        #endregion

        #region 8-Create a function named "ChangeChar"
        public static void ChangeChar(ref string x, ref string y)
        {
            string temp = x;
            x = y;
            y = temp;
        }
        #endregion



        static void Main(string[] args)
        {


            #region 1-Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            /*
            Passing by Value
            ----------------
            1-A copy of the actual value is passed to the method.
            2-Changes made to the parameter inside the method do not affect the original variable.
            3-This is the default behavior for value types.
            *******************************
            Passing by Reference
            --------------------
            1-A reference to the actual variable is passed to the method.
            2-Changes made to the parameter inside the method affect the original variable.
            3-Achieved using the ref or out keyword in C#.
            */

            #endregion

            #region 3-Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

            //int A = 10;
            //int B = 3;
            //int sum, sub;

            //sumsub(A, B,A,B, out sum,out sub);

            //Console.WriteLine($"sum = {sum}");
            //Console.WriteLine($"sub = {sub}");

            #endregion

            #region 4-Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //int[] number = { 3,3 };

            //int result = Sum(ref number); 

            //Console.WriteLine($"The sum of the digits of the {number[0]}{number[1]} is: {result}");

            #endregion

            #region 5-Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            //sPrime(5);
            #endregion

            #region 6-Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters



            #endregion

            #region 7-Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            //nonrecursive(1);
            #endregion

            #region 8-Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
            //string x = "A", y = "B";
            //Console.WriteLine($"X= {x}");
            //Console.WriteLine($"Y= {y}");
            //ChangeChar(ref x,ref y);
            //Console.WriteLine("swaping");
            //Console.WriteLine($"X= {x}");
            //Console.WriteLine($"Y= {y}");

            #endregion




        }
    }
}
