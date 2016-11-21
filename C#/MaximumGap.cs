public class Solution {
    public int MaximumGap(int[] nums) {
        if(nums == null || nums.Length < 2) return 0;
        int min = int.MaxValue, max = int.MinValue;
        foreach(int num in nums)
        {
            min = Math.Min(min, num);
            max = Math.Max(max, num);
        }
        int bucketSize = (max - min - 1) / (nums.Length - 1) + 1;
        int[] minBucket = new int[nums.Length];
        int[] maxBucket = new int[nums.Length];
        for(int i = 0; i < nums.Length; ++i)
        {
            minBucket[i] = int.MaxValue;
            maxBucket[i] = int.MinValue;
        }
        foreach(int num in nums)
        {
            int bi = (num - min)/bucketSize;
            minBucket[bi] = Math.Min(minBucket[bi], num);
            maxBucket[bi] = Math.Max(maxBucket[bi], num);
        }
        int gap = int.MinValue;
        int preMax = int.MinValue;
        for(int i = 0 ; i < nums.Length; ++i)
        {
            if(minBucket[i] != int.MaxValue)
            {
                if(preMax != int.MinValue)
                {
                    gap = Math.Max(gap, minBucket[i] - preMax);
                }
                gap = Math.Max(gap, maxBucket[i] - minBucket[i]);
                preMax = maxBucket[i];
            }
        }
        return gap;
    }
}