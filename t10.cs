using System;
class t10
{
    static void Main()
    {
        Console.Write("Enter a month (1-12): ");
        int m = int.Parse(Console.ReadLine());
        int daysCount = 0;
        bool invalid = true;

        if (m == 2) daysCount = 28;
        else if (m == 4 || m == 6 || m == 9 || m == 11) daysCount = 30;
        else if (m >= 1 && m <= 12) daysCount = 31;
        else invalid = false;
        if (!invalid) Console.WriteLine("Invalid month.");
        else Console.WriteLine("Number of days in Month: " + daysCount);
    }
}