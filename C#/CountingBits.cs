public class Solution {
    int Lowbit(int num)
    {
        return num & (-num);
    }
    
    public int[] CountBits(int num) 
    {
        if(num < 0) return null;
        int[] ans = new int[num+1];
        for(int i = 1; i <= num; ++i)
        {
             int n = i - Lowbit(i);
             ans[i] = ans[n] + 1;
        }
        return ans;
    }
}