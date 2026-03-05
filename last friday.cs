using System;
using System.Collections;
using System.Collections.Generic;
class FixedSizeList<T>
{
    private ArrayList storage;
    private int capacity;
    public FixedSizeList(int capacity)
    {
        if (capacity <= 0)
            throw new Exception("capacity must be greater than zero");
        this.capacity = capacity;
        storage = new ArrayList();
    }
    public void Add(T value)
    {
        if (storage.Count >= capacity)
            throw new Exception("The list reached maximum capacity");
        storage.Add(value);
    }
    public T Get(int index)
    {
        if (index < 0 || index >= storage.Count)
            throw new Exception("invalid index");
        return (T)storage[index];
    }
}
class TASK
{
    static void PrintArrayList(ArrayList list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Console.Write(list[i]);
            if (i < list.Count - 1)
                Console.Write("  ");
        }
        Console.WriteLine();
    }
    static void PrintList(List<int> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Console.Write(list[i]);
            if (i < list.Count - 1)
                Console.Write(", ");
        }
        Console.WriteLine();
    }
    static void ReverseArrayList(ArrayList original)
    {
        ArrayList temp = new ArrayList();
        for (int i = original.Count - 1; i >= 0; i--)
        {
            temp.Add(original[i]);
        }
        for (int i = 0; i < original.Count; i++)
        {
            original[i] = temp[i];
        }
    }
    static List<int> GetEvenNumbers(List<int> numbers)
    {
        List<int> evenList = new List<int>();
        int index = 0;
        while (index < numbers.Count)
        {
            if (numbers[index] % 2 == 0)
            {
                evenList.Add(numbers[index]);
            }
            index++;
        }

        return evenList;
    }
    static void Main()
    {
        ArrayList items = new ArrayList();
        items.Add(99);
        items.Add(6);
        items.Add("l");
        items.Add("p");
        Console.WriteLine("Before Reverse:");
        PrintArrayList(items);
        ReverseArrayList(items);
        Console.WriteLine("After Reverse:");
        PrintArrayList(items);
        List<int> nums = new List<int> { 3, 4, 7, 8, 11, 12 };
        List<int> evens = GetEvenNumbers(nums);
        Console.WriteLine("\nEven numbers:");
        PrintList(evens);

        Console.WriteLine("\nFixedSizeList Demo:");
        FixedSizeList<string> myList = new FixedSizeList<string>(2);
        myList.Add("W");
        myList.Add("K");
        Console.WriteLine(myList.Get(0));
        Console.WriteLine(myList.Get(1));
    }
}