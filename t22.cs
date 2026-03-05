using System;
class t22
{
    static void Main()
    {
        Console.Write("Rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Columns: ");
        int cols = int.Parse(Console.ReadLine());
        int[,] first = new int[rows, cols];
        int[,] second = new int[rows, cols];
        Console.WriteLine("Enter first array values:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                first[i, j] = int.Parse(Console.ReadLine());
                second[i, j] = first[i, j];
            }
        }
        Console.WriteLine("Copied array:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                Console.Write(second[i, j] + " ");
            Console.WriteLine();
        }
    }
}