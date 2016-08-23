using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasics //Mailing Address example Namespace (State) class (City) Method (street) System.Console.Write 
{
    //Command Line Application
    class Program
    { //Everything is in a class 
        static void Main()//Method .. First one always ran is called "Main" all other methods can be named what ever
        {
            //Prompt user for minutes exercised 
            //Use .net framework 
            //Terminal csc Program.cs creates Program.exe when not using VS 

            Console.Write("Enter how many minutes you exercised: ");

            string entry = Console.ReadLine();



            //Add to total 
            //Display to screen 
            Console.WriteLine("You've exercised " + entry + " minutes.");

            //Repeat until user ends 


            //Keep console window open in debug mode
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

            //Look into Mono C# REPL when not on Windows VS

        }
    }

}
