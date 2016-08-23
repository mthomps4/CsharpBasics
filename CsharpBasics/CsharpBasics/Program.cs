using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasics //Mailing Address example Namespace (State) class (City) Method (street)  ie: System.Console.Write 
{
    //Command Line Application
    class Program
    { //Everything is in a class 
        static void Main()//Method .. First one always ran is called "Main" all other methods can be named what ever
        {
            //Use .net framework 
            //Terminal csc Program.cs creates Program.exe when not using VS 

            double runningTotal = 0;

            //Repeat until user ends        
            while (true) {

                //Prompt user for minutes exercised 
                Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");
                string entry = Console.ReadLine().ToLower();

                if (entry == "quit")
                {
                    break;
                }

                    try
                    {
                        double minutes = double.Parse(entry); 

                    if (minutes <= 0)
                    {
                        Console.WriteLine("Come ON! Try to exercise.");
                        continue;
                    }
                    else if (minutes <= 10)
                    {
                        Console.WriteLine("Better than nothing right?");
                    }
                    else if (minutes <= 30)
                    {
                        Console.WriteLine("Way to GO!");
                    }
                    else if (minutes <= 60)
                    {
                        Console.WriteLine("***Ninja Warrior***");
                    }
                    else
                    {
                        Console.WriteLine("Show Off... "); 
                    }

                    //Add to total 
                    runningTotal = runningTotal + minutes;

                    //Display to screen 
                    Console.WriteLine("You've exercised " + runningTotal + " minutes.");

                }
                catch (FormatException)
                {
                    Console.WriteLine("Not a vailid input");
                    continue;
                }
               
              }

            Console.WriteLine("Great Job!"); 
            
            
            
            //Keep console window open in debug mode
            //Console.WriteLine("Press any key to exit.");
            //Console.ReadKey();
            //Look into Mono C# REPL when not on Windows VS

        }
    }

}
