using System;

namespace Vector_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                float scalar = 2;
                Vector test1 = new Vector(4, 3, 6);
                Vector test2 = new Vector(2, 8, 0);
                Console.WriteLine("your vectors are:\n" + test1 + "\n" + test2 );

                Console.WriteLine("What Funtion do you want to use?\nAdd | Negate | Subtract | Get magnitude | Get direction " +
                    "| Scale | Normalize | Dot product | Cross product | \nAngle between | Project onto");

                string function = Console.ReadLine();

                if (function.Contains("Add"))
                {
                    Console.WriteLine("Add:          " + Vector.Add(test1, test2));
                }

                if (function.Contains("Negate"))
                {
                    Console.WriteLine("Negate:       " + Vector.Negate(test1));
                }

                if (function.Contains("Subtract"))
                {
                    Console.WriteLine("Subtract      " + Vector.Subtract(test1, test2));
                }

                if (function.Contains("Get magnitude"))
                {
                    Console.WriteLine("Magnitude:    " + test1.GetMagnitude());
                }

                if (function.Contains("Get direction"))
                {
                    Console.WriteLine("Direction:    " + test1.GetDirection());
                }

                if (function.Contains("Scale"))
                {
                    Console.WriteLine("Scale:        " + Vector.Scale(test1, scalar));
                }

                if (function.Contains("Normalize"))
                {
                    Console.WriteLine("Normalize:    " + Vector.Normalize(test1));
                }

                if (function.Contains("Dot product"))
                {
                    Console.WriteLine("Dot Product:  " + Vector.DotProduct(test1, test2));
                }

                if (function.Contains("Cross product"))
                {
                    Console.WriteLine("Cross Product:" + Vector.CrossProduct(test1, test2));
                }

                if (function.Contains("Angle between"))
                {
                    Console.WriteLine("Angle Between:     " + Vector.AngleBetween(test1, test2));
                }

                if (function.Contains("Project onto"))
                {
                    Console.WriteLine("Project Onto:      " + Vector.ProjectOnto(test1, test2));
                }

                else
                {
                    Console.WriteLine("Didn't work (Either you're not capitalizing correctly or you're challenged like Jack)");

                }
            }
        }
    }
}
