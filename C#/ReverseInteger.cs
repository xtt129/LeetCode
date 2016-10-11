public class Solution {
    public int Reverse(int x) {
        long ans = 0;
        for(int i = x; i != 0;  i = i / 10)
        {
            ans = ans * 10 + i % 10;
            if(ans > Int32.MaxValue || ans < Int32.MinValue) return 0;
        }
        return (int)ans;
    }
}