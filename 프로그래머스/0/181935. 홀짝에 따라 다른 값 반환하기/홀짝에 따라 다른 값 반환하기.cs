using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        if(n%2==1)
        {
            while(n>0)
            {
                if(n%2==1)
                    answer += n;
                n -= 1;
            }
        }
        else
        {
            while(n>0)
            {
                if(n%2==0)
                    answer += (n * n);
                n -= 1;
            }
        }
        
        return answer;
    }
}