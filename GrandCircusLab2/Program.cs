using System;

namespace GrandCircusLab2
{
    class Program
    {
        static void Main(string[] args)
        {

            bool tryAgain = true;  // Loop again? Y or N

            while (tryAgain)
            {

                //Declare Constants
                const double carpetTiles = 5;
                const double paint = 5;

                // User Input
                Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!");
                Console.Write("Please write the length of your room: ");
                string length = Console.ReadLine();
                double L = double.Parse(length);

                Console.Write("Please write the width of your room: ");
                string width = Console.ReadLine();
                double w = double.Parse(width);
                double area = L * w;
                double perimeter = (L * 2) + (w * 2);
                double carpetTotal = area / carpetTiles;
                double paintTotal = perimeter / paint;


                //OutPut of Data
                Console.WriteLine("The Length is: " + length);
                Console.WriteLine("The Width is: " + width);
                Console.WriteLine("The Perimeter is: " + perimeter);
                Console.WriteLine("You will need Carpet Tiles: " + carpetTotal);
                Console.WriteLine("You will need Paint: " + paintTotal);

                Console.WriteLine("Continue? (Hit any key)");
                Console.ReadLine();

                if
                    (Console.ReadLine().ToLower() == "n")
                {
                    break;
                }
            }
        }
    }
}