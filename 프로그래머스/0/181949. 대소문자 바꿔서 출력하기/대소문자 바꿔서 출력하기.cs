using System;

public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();

        string res = ""; // 비어있는 string변수를 만들어주고

        for(int i=0; i < s.Length;i++)
        {
            char c = s[i]; //string의 i번째 요소를 char에 담음
            
            if(c >= 65 && c <=90) //그 char이 아스키코드의 대문자라면
                res += (char)(c + 32); //그 char은 int로 계산 가능하니, 32를 더해줘서 소문자로 만듦
            else
                res += (char)(c - 32); //else의 경우 소문자일테니 32를 빼서 대문자로 만듦
        }

        Console.Write(res); //Write()로 공백없이 한글자씩 출력해줌
        
    }
}