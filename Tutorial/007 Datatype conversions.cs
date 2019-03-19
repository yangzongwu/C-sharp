using System;

namespace part1_ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            float f = i;
            Console.WriteLine(f);//100

            float f1 = 123.45F;
            int i1 = (int)f1;
            Console.WriteLine(i1);//123
            int i2 = Convert.ToInt32(f1);
            Console.WriteLine(i2);//123

            //difference between two ways
            float f2 = 1111111111111113.45F;
            int i11 = (int)f2;
            Console.WriteLine(i11);//-2147483648
            int i21 = Convert.ToInt32(f2);
            Console.WriteLine(i21);//Unhandled Exception:

            //difference between Parse and TryParse
            string strNumber = "100";
            //int k = strNumber; issue
            int k = int.Parse(strNumber);
            Console.WriteLine(k);//100

            string strNumber2 = "100CD";
            int k2 = int.Parse(strNumber2);
            Console.WriteLine(k2);//Unhandled Exception
            int result = 0;
            bool IsConversionSuccessful=int.TryParse(strNumber2, out result);
            if (IsConversionSuccessful)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }

        }
    }
}
