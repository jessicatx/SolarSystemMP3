//MP3 Main (console app version) 
//This file contains the SimulatorMain with the Main method for the program.

//Complete the Main method. Do not add any new using directive, methods, or fields.

using System;

namespace SolarSystemSimulation
{
    class SimulatorMain
    {
        public static void Main()
        {
            PlanetarySystem planets = new PlanetarySystem(0);
            SimulationTimer timer = new SimulationTimer();
            bool running = false; //set to true when a simulation is running
            bool paused = false; //set to true when a simulation is paused

            Console.WriteLine("Welcome to the solar planet simulator! Select from the menu.");
            while (true)
            {
                Console.WriteLine();
                Console.Write("(s)tart, (p)ause, (r)esume, (g)et status, (q)uit? "); 

                string choice;
                try
                {
                    choice = Console.ReadLine().Trim().ToLower();
                }
                catch (System.IO.IOException e)
                {
                    Console.WriteLine($"IO Exception: {e.Message}");
                    continue;
                }

                string result = "Please choose from the menu";

                if (choice.StartsWith("s"))
                {
                    //To implement
                }
                else if (choice.StartsWith("p"))
                {
                    //To implement
                }
                else if (choice.StartsWith("r"))
                {
                    //To implement
                }
                else if (choice.StartsWith("g"))
                {
                    //To implement
                }
                else if (choice.StartsWith("q"))
                {
                    break;
                }
                Console.WriteLine();
                Console.WriteLine(result);
            }
        }

        /// <summary>
        /// Gets an int from the command line within the range [min, max]. 
        /// If the provided num is not acceptable, str will contain an error message.
        /// </summary>
        /// <param name="num">Nummber received from the user and returned through the out argument.</param>
        /// <param name="min">Min acceptable range for num.</param>
        /// <param name="max">Max acceptable range for num.</param>
        /// <param name="str">Contains an error message if not successful.</param>
        /// <returns>true if successful, false otherwise.</returns>
        private static bool GetInt(out int num, int min, int max, ref string str)
        {
            if (int.TryParse(Console.ReadLine().Trim(), out num))
            {
                if (num >= min && num <= max)
                {
                    return true;
                }
                str = "Number outside range";
            }
            else
            {
                str = "Not an acceptable number";
            }
            return false;
        }
    }
}
