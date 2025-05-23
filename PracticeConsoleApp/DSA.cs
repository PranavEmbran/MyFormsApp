using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Linq; //  Required for .Contains() on arrays


namespace PracticeConsoleApp
{
    internal class DSA
    {

        public void useArray()
        {
            string[] weekDays = new string[7];
            weekDays = ["Sunday","Monday","Tuesday","Wednesday","Thursday","Friday","Saturday"];
            Console.WriteLine("Enter week number (1 to 7):");
            

            int i = 0;
            foreach (string day in weekDays)
            {
                i++;
               Console.WriteLine($"Enter {i} for {day}.");
            }

            int weekNum = int.Parse(Console.ReadLine());

            switch (weekNum)
            {
                case 1: Console.WriteLine(weekDays[0]); break;
                case 2: Console.WriteLine(weekDays[1]); break;
                case 3: Console.WriteLine(weekDays[2]); break;
                case 4: Console.WriteLine(weekDays[3]); break;
                case 5: Console.WriteLine(weekDays[4]); break;
                case 6: Console.WriteLine(weekDays[5]); break;
                case 7: Console.WriteLine(weekDays[6]); break;
                default: Console.WriteLine("Invalid input");break;
            }


        }

        public void useStack()
        {
            int pageNum = 1;
            Stack<string> visitFwdStack = new Stack<string>();
            Stack<string> visitBackStack = new Stack<string>();
            string[] pageArr = new string[10];

            while (pageNum != 0)
            {
                
                pageArr = ["www.google.com", "www.hodo.com", "www.chsarp.com", "www.dotnet.com", "www.java.com", "www.website.com", "www.wordpress.com", "www.github.com", "www.apache.com", "www.ibm.com", "www.oracle.com"];

                Console.WriteLine("Enter the page number to visit:");
                int i = 1;
                foreach (string page in pageArr)
                {
                    Console.WriteLine($"{i} for {page}");
                    i++;
                }
                Console.WriteLine("0 to exit\n");

                pageNum = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                //bool exists = Array.IndexOf(pageArr, pageNum) >= 0;
                bool exists = pageNum >= 1 && pageNum <= pageArr.Length;
                if (pageNum != 0)
                {
                    if (exists)
                    {
                        visitFwdStack.Push(pageArr[pageNum-1]);

                        //##########################################
                        if (visitBackStack.Count > 0)
                        {
                            Console.WriteLine($"Previous page: {visitBackStack.Peek()}");
                        }
                        if (visitFwdStack.Count > 0)
                        {
                            Console.WriteLine($"Current page: {visitFwdStack.Peek()}");
                        }
                        //##########################################

                        Console.WriteLine("");

                        Console.WriteLine("Page navigation: 4[<-] to go back.");
                        //Console.WriteLine("Page navigation: 4[<-] to go back, 6[->] to go forward.");
                        int navigate = int.Parse(Console.ReadLine());

                        if (navigate == 4)
                        {
                            visitBackStack.Push(visitFwdStack.Pop());

                            //##########################################
                            if (visitBackStack.Count > 0)
                            {
                                Console.WriteLine($"Navigated from: {visitBackStack.Peek()}");
                            }
                            if (visitFwdStack.Count > 0)
                            {
                                Console.WriteLine($"Current page: {visitFwdStack.Peek()}");
                            }
                            //##########################################
                        }

                    }
                    else
                    {
                        Console.WriteLine("ERROR 404 | PAGE NOT FOUND");
                    }
                    Console.WriteLine("************************");

                }
            }
            Console.WriteLine("\n***END***");
        }
        public static void Main(string[] args)
        {
            DSA dsObj = new DSA();
            Console.WriteLine("Enter Data Structure number to use:");
            int dsNum = int.Parse(Console.ReadLine());
            switch (dsNum)
            {
                case 1: dsObj.useArray(); break;
                case 2: dsObj.useStack(); break;


            }
        }
    }
}
