using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDiceGame_
{
    public static class ConsoleHelp
    {
        public static void PrintToConsole(this string message)
        {
            Console.WriteLine(message);
        }

        public static void PrintToConsole(this int value)
        {
            Console.WriteLine(value);
        }

        public static string RequestString(this string message) 
        {
            string output = "";
            
            while (true) 
            {
                Console.Write(message);
                output = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(output) == true) 
                {
                    break;
                }
                else
                {
                    "Don't leave blank".PrintToConsole();
                }

            }
            return output;
        }

        public static int RequestNumber(this string message) 
        {
            int output = 0;
            string textOutput;
            while (true) 
            {
                Console.Write(message);
                textOutput = Console.ReadLine();
                if (int.TryParse(textOutput, out output))
                {
                    break;
                }
                else
                {
                    "Enter a integer.".PrintToConsole();
                }
            }
            return output;
        }


    }
}
