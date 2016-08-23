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

            int runningTotal = 0;

            //Repeat until user ends        
            bool keepGoing = true;
            while (keepGoing) {

                //Prompt user for minutes exercised 
                Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");
                string entry = Console.ReadLine().ToLower();

                if (entry == "quit")
                {
                    keepGoing = false;
                }
                else
                {
                    int minutes = int.Parse(entry);
                    //Add to total 
                    runningTotal = runningTotal + minutes;

                    //Display to screen 
                    Console.WriteLine("You've exercised " + runningTotal + " minutes.");
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
