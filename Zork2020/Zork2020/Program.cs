using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zork2020
{
    class Program
    {
        static void Main(string[] args)
        {
            World world = new World();

            Console.WriteLine("Welcome to Zorkish!");
            while (true)
            {
                Console.WriteLine("You are in " +world.currentArea.name);
                Console.WriteLine("Enter a command");
                string command = Console.ReadLine(); //"go north"
                string[] commands = command.Split(' '); //["go", "north"]
                switch (commands[0])
                {
                    case "go":
                        string dir;
                        if (commands.Length < 2)
                        {
                            Console.WriteLine("Which direction do you want to go?");
                            dir = Console.ReadLine();
                        }
                        else
                        {
                            dir = commands[1];
                        }

                        bool success = false;
                        switch (dir)
                        {
                            case "north":
                            case "n":
                                success = world.Go(Directions.North);
                                break;
                            case "south":
                            case "s":
                                success = world.Go(Directions.South);
                                break;
                            case "east":
                            case "e":
                                success = world.Go(Directions.East);
                                break;
                            case "west":
                            case "w":
                                success = world.Go(Directions.West);
                                break;
                            default:
                                Console.WriteLine("I didn't understand that");
                                break;
                        }
                        if (!success)
                            Console.WriteLine("There's nothing that way!");
                        break;
                    case "examine":
                        Console.WriteLine(world.currentArea.description);
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
