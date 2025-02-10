// 
// 
using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        int numInput = int.Parse(Console.ReadLine());

        string[] input = new string[numInput];
        int a = 0;
        while (a < numInput)
        {
            input[a] = Console.ReadLine();
            a += 1;
        }

        for (int i = 0; i < numInput; i++)
        {
            string s = input[i];
            Console.Write(s[0].ToString());
            Console.Write(s[s.Length-1].ToString());
            Console.WriteLine();

        }
        

    }



}

