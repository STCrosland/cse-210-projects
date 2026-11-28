
using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        while (choice != 5)
        {
            Console.Clear();

            Console.WriteLine("Mindfulness Program");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Start gratitude activity");
            Console.WriteLine("  5. Quit");
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                choice = 0;
            }

            switch (choice)
            {
                case 1:
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    break;

                case 2:
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.Run();
                    break;

                case 3:
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    break;

                case 4:
                    GratitudeActivity gratitude = new GratitudeActivity();
                    gratitude.Run();
                    break;

                case 5:
                    Console.WriteLine("Thank you for using the Mindfulness Program!");
                    break;

                default:
                    Console.WriteLine("Please select a valid option.");
                    Thread.Sleep(1500);
                    break;
            }
        }
    }
}
