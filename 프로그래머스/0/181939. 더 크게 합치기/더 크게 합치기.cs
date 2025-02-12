using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        int answer1 = 0;
        int answer2 = 0;

        int numA = a;
        int numB = b;

        int num1 = 10;
        int num2 = 10;
//b나누기 1 10 100 1000 10000을 해서 몫이 0이 되는 때에 그걸 a에 곱해서 둘을 더한다
        while (b / 10 > 0)
        {
            b /= 10;
            num1 *= 10;
        }
        answer1 = (a * num1) + numB;

        while (a / 10 > 0)
        {
            a /= 10;
            num2 *= 10;                                
        }
        answer2 = (numB * num2) + numA;

                
        answer = answer1 >= answer2 ? answer1 : answer2;

        return answer;
    }
}