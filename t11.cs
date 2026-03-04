using System;
class t11
{
    static void Main()
    {
        Console.Write("Enter a letter: ");
        string txt = Console.ReadLine().Trim().ToLower();
        if (txt.Length != 1 || !char.IsLetter(txt[0]))
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        char letter = txt[0];
        bool vowel =
            letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u';
        Console.WriteLine(vowel ? "vowel" : "consonant");
    }
}