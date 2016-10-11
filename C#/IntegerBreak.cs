public class Solution {
    public int IntegerBreak(int n) {
        if(n < 2) return 0;
        if(n == 2) return 1;
        if(n == 3) return 2;
        if(n % 3 == 0) return (int)Math.Pow(3, n / 3);
        if(n % 3 == 1) return (int)Math.Pow(3, n / 3) / 3 * 4;
        return (int)Math.Pow(3, n / 3) * 2;
    }
}