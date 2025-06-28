// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] num = { 1, 2, 3, 4 };

        Array.Sort(num);
        Console.WriteLine("Ascending Order: ");
        foreach (int n in num)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine(); 

        Array.Reverse(num);
        Console.WriteLine("Descending Order: ");
        foreach (int n in num)
        {
            Console.Write(n + " ");
        }
    }
}
