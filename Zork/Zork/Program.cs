using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            World world = new World();

            Console.WriteLine("Welcome to Zorkish!");
            while (true)
            {
                Console.WriteLine("Enter a command");
                string command = Console.ReadLine();
                switch (command)
                {
                    case "go":

                        break;
                    case "examine":

                        break;
                    case "quit":

                        break;
                    default:
                        Console.WriteLine("I didn't understand that");
                        break;
                }
            }
        }
    }
}
