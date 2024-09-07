// 정석으로 보이는 코드를 가져와서 주석을 달았습니다.
using System;

public class Solution 
{
    public string solution(string my_string, string overwrite_string, int s) 
    {
        string answer = "";

        answer = my_string.Remove(s, overwrite_string.Length);
        //Remove(int 인덱스, int 글자수 ): 문자열의 지정 위치부터 지정된 수까지 삭제 후 반환해줌
        //ㄴ 인덱스로 삭제를 시작할 위치를 지정, 지정된 위치로부터 글자수만큼 내용을 삭제함

        answer = answer.Insert(s, overwrite_string);
        //Insert(int 인덱스, string 내용): 문자열의 지정 위치에 문자열을 삽입 후 반환해줌
        //ㄴ 인덱스로 삽입을 시작할 위치를 지정, 지정된 위치에 있던 내용을 밀어내고 그 위치에 내용을 삽입함

        return answer;
        
    }
    
    
}