public class Solution {
    int next(int n)
    {
        int sum = 0;
        while(n > 0)
        {
            int mod = n % 10;
            sum += mod * mod;
            n /= 10;
        }
        return sum;
    }
    public bool IsHappy(int n) {
        if(n <= 0) return false;
        HashSet<int> set = new HashSet<int>();
        while(n != 1)
        {
            if(set.Contains(n)) return false;
            set.Add(n);
            n = next(n);
        }
        return true;
    }
}