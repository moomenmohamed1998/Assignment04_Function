using System.Reflection.Metadata;
using System.Reflection;
using System.Threading.Channels;

namespace Assignment04_Function
{
    internal class Program
    {

        #region 7-Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
        public static void nonrecursive(int Num)
        {
          for(int i = 1; i <= Num; i++)
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


            #region 7-Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            nonrecursive(1);
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
