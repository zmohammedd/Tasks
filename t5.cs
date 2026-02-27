using System;

class Magazine
{
    public void Show()
    {
        Console.WriteLine("Magazine opened.");
    }
}

class t5
{
    static void Main()
    {
        Magazine item = null;

        if (item == null)
        {
            Console.WriteLine("empty");
            item = new Magazine();
        }

        item.Show();
    }
}