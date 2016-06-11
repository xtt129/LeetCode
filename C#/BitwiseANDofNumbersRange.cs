public class Solution {
    public int RangeBitwiseAnd(int m, int n) {
        while(n > m)
        {
            n &= (n - 1);
        }
        return n;
    }
}