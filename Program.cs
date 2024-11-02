using System;

class Program
{
    const double fivemMagicConstant = 1678106.125; // Updated constant

    // Converts cm/360 to Profile_MouseOnFootScale using the provided formula.
    static double ComputeMouseOnFootScale(double cm360, double dpi)
    {
        return Math.Round((fivemMagicConstant / (dpi * cm360)) - 60.25);
    }

    // Converts Profile_MouseOnFootScale back to cm/360 using reverse calculation.
    static double ComputeCm360(double sens, double dpi)
    {
        return fivemMagicConstant / (dpi * (sens + 60.25));
    }

    static void Main()
    {
        Console.WriteLine("FiveM Sensitivity Converter");
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Convert cm/360 to Profile_MouseOnFootScale");
        Console.WriteLine("2. Convert Profile_MouseOnFootScale back to cm/360");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.Write("Enter cm/360: ");
            double cm360 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter DPI: ");
            double dpi = Convert.ToDouble(Console.ReadLine());

            double fivemSens = ComputeMouseOnFootScale(cm360, dpi);
            Console.WriteLine($"Profile_MouseOnFootScale: {fivemSens:F2}");
        }
        else if (choice == "2")
        {
            Console.Write("Enter Profile_MouseOnFootScale: ");
            double sens = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter DPI: ");
            double dpi = Convert.ToDouble(Console.ReadLine());

            double cm360Result = ComputeCm360(sens, dpi);
            Console.WriteLine($"Cm/360: {cm360Result:F2}");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please run the program again.");
        }
    }
}

