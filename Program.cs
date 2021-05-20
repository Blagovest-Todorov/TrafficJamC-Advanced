using System;
using System.Collections.Generic;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // n cars allowed to pass on green

            string command = Console.ReadLine();
            Queue<string> cars = new Queue<string>();
            int count = 0;

            while (command != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (cars.Count > 0 ) // if there is some cars at the Queue
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            count++;
                        }
                        else //if the cars are <= 0, there is no cars, move out of the loop
                        {
                            break;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
