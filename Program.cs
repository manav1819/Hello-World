using System;
using System.Diagnostics;

namespace ConsoleApp1
{   
    class Program
    {
        static void Main(string[] args)
        {
            string doubleForwardSlash = new string((char)47, 2); //ASCII Code 47 = Forward Slash:/
            string doubleBackSlash = new string((char)92, 2); //ASCII Code 92 = Backward Slash:\
            string vs_2019 = doubleForwardSlash + " Visual Studio 2019 (Preview) " + doubleBackSlash;
            string hello = "C# Hello World! Happy new Year 2019";

            //Declaring and initialising string array.
            string[] pages = new string[] {"Code Like Coder A","Manav Patel's Piano",
                                          "Play like last day", "Fuck everyone else"};

            // Escaping double quotes in string using 'Escape characters or Escape Characters Sequences' : \",\',\\,\n etc
            string result = "\\ Like us on youtube and follow me on twitter:\n";

            //Convert a string to uppercase using ToUpper() method.
            Console.WriteLine(vs_2019.ToUpper() + Environment.NewLine);
            Console.WriteLine("{0} {1}", hello, "\n"); //new line

            Console.WriteLine("Please enter your name: ");
            string doubleName;
            doubleName = Console.ReadLine();

            Console.WriteLine("Please enter your partner's name: ");
            string doublePartnerName;
            doublePartnerName = Console.ReadLine();

            



            
            

        }

       
    }
}
