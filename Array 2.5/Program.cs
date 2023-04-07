
///   1 - MASALA : 

using System.Globalization;

namespace Array_2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Enter length of pattern : ");
            int input = int.Parse(Console.ReadLine());
            int[] array = new int[input];
            for (int i = 0; i <= input; i++)
            {
                for (int j = input; j >= 0; j--)
                {
                    if (j >= i)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("* ");
                    }
                }
                Console.WriteLine();

            }

            for (int i = 0; i <= input; i++)
            {
                for (int j = 0; j <= input; j++)
                {
                    if (j >= i)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();

            }
            


        }
    }
}



 