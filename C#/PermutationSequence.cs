public class Solution {
    private int SkipKthNumber(bool[] used, int k)
    {
        int count = 0;
        for(int  i = 0; i < used.Length; ++i)
        {
            if(!used[i])
            {
                 ++ count;
                 if(count > k) return i;
            }
        }
        return -1;
    }
    public string GetPermutation(int n, int k) {
        if(n == 0) return string.Empty;
        bool[] used = new bool[n];
        int factor = 1;
        for(int i = 1; i < n;  factor *= i,  ++i);
        k = k - 1;
        StringBuilder ans = new StringBuilder();
        for(int i = n - 1; i >= 1; --i)
        {
            int digit = k / factor;
            k = k % factor;
            int index = SkipKthNumber(used, digit);
            used[index]  = true;
            ans.Append(index + 1);
            factor  /= i;
        }
        int last = SkipKthNumber(used, 0);
        ans.Append(last + 1);
        return ans.ToString();
    }
}