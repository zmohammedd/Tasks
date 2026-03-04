using System;

class Account
{
    public string Owner { get; set; }
}

class t13
{
    static void ChangeName(Account A)
    {
        A.Owner = "UpdatedUser";
    }

    static void ReplaceAccount(ref Account A)
    {
        A = new Account { Owner = "NewAccount" };
    }

    static void Main()
    {
        Account user = new Account { Owner = "OriginalUser" };

        ChangeName(user);
        Console.WriteLine("After ChangeName: " + user.Owner);

        ReplaceAccount(ref user);
        Console.WriteLine("After ReplaceAccount: " + user.Owner);
    }
}