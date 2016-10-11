public class Solution {
    public int TrailingZeroes(int n) {
        if(n <= 4) return 0;
        long factor = 5, numerator = (long)n;
        int count = 0;
        while(numerator / factor > 0)
        {
            count +=(int)(numerator / factor);
            factor *= 5;
        }
        return count;
    }
}