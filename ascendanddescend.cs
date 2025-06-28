// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int [] num = {9, 7, 1, 3, 2};
        Console.WriteLine("Ascending");
         Array.Sort(num);
        foreach (int n in num)
         
         Console.WriteLine(n);
         Console.WriteLine("Descending");
          Array.Reverse(num);
        foreach (int n in num)
         
         Console.WriteLine(n);
         
    }
}
