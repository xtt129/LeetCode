public class Solution {
    public int NthSuperUglyNumber(int n, int[] primes) {
        if(n <= 0) return 0;
        List<int> nums = new List<int>() { 1 };
        int[] idxs = new int[primes.Length];
        for(int i = 1 ; i < n; ++ i)
        {
            int min = int.MaxValue;
            for(int j = 0; j < primes.Length; ++j)
            {
                min = Math.Min(min, nums[idxs[j]] * primes[j]);
            }
            for(int j = 0; j < primes.Length; ++j)
            {
                if(nums[idxs[j]] * primes[j] == min) idxs[j] ++;
            }
            nums.Add(min);
        }
        return nums[n - 1];
    }
}