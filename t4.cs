using System;

class Vehicle
{
    public string Brand { get; set; }
}

class t4
{
    static void Main()
    {
        Vehicle v1 = new Vehicle { Brand = "BMW" };
        Vehicle v2 = v1;

        v2.Brand = "Audi";

        Console.WriteLine("First object: " + v1.Brand);
        Console.WriteLine("Second object: " + v2.Brand);
    }
}
