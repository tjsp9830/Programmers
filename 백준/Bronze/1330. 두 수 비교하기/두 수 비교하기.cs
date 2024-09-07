// 두 정수 A와 B가 주어졌을 때, > = <  세 가지 중 하나를 출력한다.
using System;

class Program
{
    
    static void Main(string[] args)
    {
        string[] str = Console.ReadLine().Split();
        
        int A = int.Parse(str[0]);
        int B = int.Parse(str[1]);
        
        if(A==B)
            Console.Write("==");
        else if(A>B)
            Console.Write(">");
        else if(A<B)
            Console.Write("<");
        
    }
    
    
}