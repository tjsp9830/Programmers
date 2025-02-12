using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        int answer1 = 0;
        int answer2 = 0;
        
        int numA = a;
        int numB = b;
        
        int num = 10;
        while (b / 10 > 0)
        {
            b /= 10;
            num *= 10;
        }
        answer1 = (numA * num) + numB;
        
        answer2 = (numA * numB) * 2;
        
        answer = answer1 >= answer2 ? answer1 : answer2;
        
        
        return answer;
    }
}