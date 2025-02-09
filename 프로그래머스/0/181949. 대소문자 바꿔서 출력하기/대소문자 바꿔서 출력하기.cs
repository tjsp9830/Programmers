using System;

public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();

        foreach(char a in s)
        {
            if(char.IsUpper(a))
            {
                Console.Write(char.ToLower(a));
            }
            else
            {
                Console.Write(char.ToUpper(a));
            }

            
        }
        
    }
}