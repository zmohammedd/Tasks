using System;

class t19
{
    static string ChangeCharacter(string text, int position, char newChar)
    {
        char[] letters = text.ToCharArray();
        letters[position] = newChar;
        return new string(letters);
    }
    static void Main()
    {
        Console.Write("Enter a string: ");
        string word = Console.ReadLine();
        Console.Write("Enter position: ");
        int index = int.Parse(Console.ReadLine());
        Console.Write("Enter new character: ");
        char ch = Console.ReadLine()[0];
        string result = ChangeCharacter(word, index, ch);
        Console.WriteLine("New string = " + result);
    }
}