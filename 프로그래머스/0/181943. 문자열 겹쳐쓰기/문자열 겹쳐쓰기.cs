using System;

public class Solution 
{
    public string solution(string my_string, string overwrite_string, int s) 
    {
        string answer = "";

        for (int i = 0; i < my_string.Length; i++)
        {
            //길이 10 (인덱스 0~9) | 숫자2 (인덱스 2부터) | 길이 7(인덱스 0~6) | 분리지점 0~1, 2~ 8, 9. | 2+7=8,   9<10가 맞으므로 남은 9부터 마저 출력
            //길이 14(인덱스 0~13) | 숫자7 (인덱스 7부터) | 길이 7(인덱스 0~6) | 분리지점 0~6, 7~14.    | 7+7=14, 14<14가 아니라서 출력 끝
            if (i < s || s + overwrite_string.Length <= i)
            {
                answer += my_string[i];
            }
            else
            {
                for (int j = 0; j < overwrite_string.Length; j++)
                {
                    answer += overwrite_string[j];
                }
                i += overwrite_string.Length-1;
            }

            if (my_string.Length <= i)
                return answer;



        }


        return answer;
        
    }
    
    
}