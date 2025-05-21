// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(args.Length);
        Console.WriteLine("Hello, DotNet!");
        int[] varr = { 9, 8, 7, 6 };

        foreach (int i in varr)
        {
            Console.WriteLine(i);
        }

        //*********************************************
        //Palindrome number
        //*********************************************
        Console.Write("Enter a number: ");
        int numip = int.Parse(Console.ReadLine());
        int temp = numip;
        int revNum = 0;
        while (temp > 0) { 
        revNum = (revNum * 10) + (temp % 10);
        temp = temp / 10;
        }
        if (revNum == numip)
        {
            Console.WriteLine($"{numip} Pallindrome");
        }
        else
        {
            Console.WriteLine($"{numip} is Not a Pallindrome");
        }
            Console.WriteLine("Reverse = " + revNum);

        //*********************************************
        //Palindrome string
        //*********************************************
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
        string revStr = string.Empty;
        for (int i = str.Length-1; i >= 0; i-- )
        {
            //revStr += str.Substring(i);
            revStr += str[i];
        }

        Console.WriteLine("Reverse = " + revStr);
        if (str == revStr)
        {
            Console.WriteLine($"{str} is a Pallindrome");
        }
        else
        {
            Console.WriteLine($"{str} is Not a Pallindrome");
        }


        //*********************************************
        //Largest of 3 numbers.
        //*********************************************
        Console.WriteLine("Finding largest of 3 numbers:");
        string cont = "y";
        while(cont != "n" & cont != "N") { 
        Console.WriteLine("Enter 3 numbers:");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());
        int largest = (num1 > num2) ? ((num1 > num3) ? num1 : num3) : ((num2 > num3) ? num2 : num3);
            Console.WriteLine($"{largest} is the largest");
            Console.WriteLine("Do you want to find largest among another 3 numbers? (y/n): ");
            cont=Console.ReadLine();
        }

    }
}
