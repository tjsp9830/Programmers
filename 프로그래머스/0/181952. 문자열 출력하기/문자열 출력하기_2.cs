// 혼자서 해결할 수 없어 "다른사람의풀이"를 참고했고,
// 문제가 요구하는 기능이 이것인것 같아서 가져왔습니다.
// C#에서 string에 지원해주는 기능들
// ㄴ[링크1](https://blog.naver.com/holyruby/40056224803)
// ㄴ[링크2](https://coding-abc.kr/70#google_vignette)

using System;

public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();


        foreach (char c in s)
        {
            if (char.IsUpper(c))                 // IsUpper() 기능: string이 영어 대문자인지 판별함
            {
                Console.Write(char.ToLower(c));  // ToLower() 기능: 해당 문자열을 모두 대문자로 변경해서 반환함. (원본 문자열은 바뀌지 않음)
            }
            else
            {
                Console.Write(char.ToUpper(c));  // ToUpper() 기능: 해당 문자열을 모두 소문자로 변경해서 반환함. (원본 문자열은 바뀌지 않음)
            }
        }

    }
}
