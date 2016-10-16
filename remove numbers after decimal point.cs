using System;

class Program
{
    static void Main()
    {
        // The input string.
        const string value = "12.100000000";

        // Test with IndexOf method.
        int r;
        if ((r = value.IndexOf('.')) != -1)
        {
            Console.WriteLine(r);
            string sub = value.Substring(0, r);
            Console.WriteLine(sub);
            Console.ReadLine();
        }
    }
}

