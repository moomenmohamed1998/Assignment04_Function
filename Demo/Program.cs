namespace Demo
{
    internal class Program
    {
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
        }
    }
}
