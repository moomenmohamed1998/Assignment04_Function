namespace Demo
{
    internal class Program
    {

        public static void printshape()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("(*-*)");
            }
        }

        public static int SumArray(ref int[] Arr)
        {
            int Sum = 0;
            //Arr[0] = 100;

            Arr = new int[] { 4, 5, 6 };

            for (int i = 0; i < Arr.Length; i++) 
            {
                Sum += Arr[i];

            }
            return Sum;
        }

        public static void Summul(int x, int y, out int Sum, out int mul)
        {

             Sum = x + y;
             mul = x * y;

        }

        public static void swap(int x, int y)
        {

            int Temp = x;
            x = y;
            y = Temp;

        }

        static void Main(string[] args)
        {

            #region  casting [Boxing - unBoxing]
            //object obj = new object();
            //obj = "mostafa";
            //obj = 2;

            #region Boxing [safe Code]
            //int x = 10;
            //object obj01 = new object();
            //obj01 = x;

            //Console.WriteLine(obj01);
            #endregion

            #region Un Boxing [Un safe Code]

            //object obj02 = new object();
            //obj02 = 10;
            ////obj02 = "mostafa";
            //int x = (int)obj02;

            //Console.WriteLine(x);

            #endregion

            #endregion

            #region Nullable DataTybe

            #region  Value Type
            //int X;
            //int? X = null;

            //Console.WriteLine(X);

            //int? x = null;
            //int Y;
            //if (x != null)
            //{
            //    Y = (int)x;
            //}
            //else
            //{

            //    Y = 0;

            //}

            //if (x.HasValue)
            //{
            //    Y = x.Value;

            //}
            //else
            //{
            //    Y = 0;
            //}

            //Y = x.HasValue ? x.Value:0 ;
            //Console.WriteLine(Y);
            #endregion

            #region Reference Type

            //string? Name = null;

            //Console.WriteLine(Name);

            #endregion

            #endregion

            #region Null Propagation Operator
            //int[] Number = { 1, 2, 3, 4, 5 };
            //int[] Number = null;


            //if(Number != null)
            //  {
            //      for (int i = 0; i < Number?.Length; i++)
            //      {
            //          Console.WriteLine(Number[i]);
            //      }
            //  }

            //int Length = Number?.Length ?? 0;

            //Console.WriteLine(Length);

            #endregion

            #region Function

            //printshape();


            #endregion

            #region  Value Type Paramters

            #region By Value

            //int A = 5;
            //int B = 9;
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            //swap(A, B);
            //Console.WriteLine(A);
            //Console.WriteLine(B);

            #endregion

            #region By Refrence

            //int A = 5;
            //int B = 9;
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            //swap(ref A,ref B);
            //Console.WriteLine(A);
            //Console.WriteLine(B);

            #endregion

            #endregion

            #region Reference Type

            #region EX01
            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArray(Numbers));
            //Console.WriteLine(Numbers[0]); 
            #endregion

            #region EX02

            #region By value
            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArray(Numbers));
            //Console.WriteLine(Numbers[0]);

            #endregion

            #region By Ref

            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArray(ref Numbers));
            //Console.WriteLine(Numbers[0]);

            #endregion

            #endregion



            #endregion

            #region Function - Passing By Out

            //int A = 10;
            //int B = 20;
            //int sum, mul;
            //Summul(A, B, out sum, out mul);

            //Console.WriteLine(sum);
            //Console.WriteLine(mul);




            #endregion

            #region function - Params

            //int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Console.WriteLine(SumArray(ref number));

            #endregion

        }
    }
}
