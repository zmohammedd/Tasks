using System;

struct valuepoint
{
    public int Number { get; set; }
}
class refpoint
{
    public int Number { get; set; }
}
class task
{
    static void ChangeData(valuepoint a, refpoint b)
    {
        a.Number = 500;   
        b.Number = 500;   
    }

    static void Main()
    {
        valuepoint first = new valuepoint { Number = 20 };
        refpoint second = new refpoint { Number = 20 };

        ChangeData(first, second);

        Console.WriteLine("Struct value = " + first.Number);
        Console.WriteLine("Class value  = " + second.Number);
    }
}