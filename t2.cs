using System;

class Learner
{
    public string FullName { get; set; }
}

class Program
{
    static void Main()
    {
        Learner objA = new Learner { FullName = "Omar" };
        Learner objB = new Learner { FullName = "Omar" };
        Learner objC = objA;

        Console.WriteLine("A == B : " + (objA == objB));
        Console.WriteLine("A == C : " + (objA == objC));
    }
}