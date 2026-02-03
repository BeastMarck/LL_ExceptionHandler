using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LL_UserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //John Jenson tacal
            //IT402P

            //LinkedList Declaration
            LinkedList<string> name = new LinkedList<string>();
            int TotalNames;

            CheckPoint:
            Console.Clear();
            //Input Total number of nodes
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You may input Student first names from 5 to 10");
            Console.Write("How many names would you like to input: ");
            
            //Exception Handler
            try
            {
                TotalNames = int.Parse(Console.ReadLine());
                if (TotalNames < 5 || TotalNames > 10)
                    throw new Exception("Please enter numbers from 5-10");//declaring new exception for 5-10 limit
            }
            catch (FormatException)//For string input warning
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter a number");
                Thread.Sleep(1000);
                goto CheckPoint;
            }
            catch(Exception ex)//5-10 Limmit
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Thread.Sleep(1000);
                goto CheckPoint;
            }

            //For Name Input
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nEnter {TotalNames} names of your classmates");
            Console.ForegroundColor = ConsoleColor.White;
            for(int i = 0; i < TotalNames; i++)
            {
                //using if else looping for a clean display of interface
                if (i == 0)
                {
                    i++;
                    Console.Write($"{i}st Name: ");
                    string inputname = Console.ReadLine();
                    name.AddLast(inputname);
                    i--;
                }
                else if (i == 1)
                {
                    i++;
                    Console.Write($"{i}nd Name: ");
                    string inputname = Console.ReadLine();
                    name.AddLast(inputname);
                    i--;
                }
                else if (i == 2)
                {
                    i++;
                    Console.Write($"{i}rd Name: ");
                    string inputname = Console.ReadLine();
                    name.AddLast(inputname);
                    i--;
                }
                else
                {
                    i++;
                    Console.Write($"{i}th Name: ");
                    string inputname = Console.ReadLine();
                    name.AddLast(inputname);
                    i--;
                }
            }

            //Display Inputted Names (Linked LIst)
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("\n-----Inputed Names (Linked List)-----");
            Console.ForegroundColor = ConsoleColor.White;
            int index = 1;
            foreach (string value in name)
            {
                string suffix;

                if (index == 1)
                {
                    suffix = "st";
                }
                else if (index == 2)
                {
                    suffix = "nd";
                }
                else if (index == 3)
                {
                    suffix = "rd";
                }
                else
                {
                    suffix = "th";
                }

                Console.WriteLine($"{index}{suffix}: {value}");
                index++;
            }

            //Turning the linked list into an array
            string[] ArrayNames = new string[name.Count];
            name.CopyTo(ArrayNames, 0);

            Array.Sort(ArrayNames);

            name.Clear();
            foreach (string sortedName in ArrayNames)
            {
                name.AddLast(sortedName);
            }

            // Display Sorted Names (Array)
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n-----Names Sorted (Array)-----");
            Console.ForegroundColor = ConsoleColor.White;

            index = 1;
            foreach (string value in name)
            {
                string suffix;

                if (index == 1)
                {
                    suffix = "st";
                }
                else if (index == 2)
                {
                    suffix = "nd";
                }
                else if (index == 3)
                {
                    suffix = "rd";
                }
                else
                {
                    suffix = "th";
                }

                Console.WriteLine($"{index}{suffix}: {value}");
                index++;
            }

            Console.ReadLine();
        }


    
    }
}
