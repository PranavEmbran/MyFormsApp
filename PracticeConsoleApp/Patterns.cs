using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp
{
    internal class Patterns
    {
        public void invertRightTriangle()
        {
            Console.WriteLine("The Inverted Right Angle Triangle Pattern:");
            for (int row = 8; row > 0; row--)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void rightTriangle()
        {
            Console.WriteLine("The Right Angle Triangle Pattern:");
            for (int row = 1; row <= 8; row++)
            {
                for (int col=1; col<= row; col++)
                {
                    Console.Write('*');
                }
                Console.WriteLine() ;
            }
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("\n*** THE PATTERN PRINTING APPLICATION ***\n");

            Patterns pattObj = new Patterns();

            pattObj.invertRightTriangle();

            pattObj.rightTriangle();
        }
    }
}
