public class Solution {
    public int ThreeSumClosest(int[] nums, int target) 
    {
        Array.Sort(nums);
        int min = int.MaxValue, sum = 0;
        for(int i = 0; i < nums.Length - 2; ++i)
        {
            int low = i+1, high = nums.Length - 1;
            while(low < high)
            {
                int addup = nums[i] + nums[low] + nums[high];
                if(Math.Abs(addup - target) < min)
                {
                    min = Math.Abs(addup - target);
                    sum = addup;
                }
                if(addup < target)
                {
                    ++low;
                }
                else
                {
                    --high;
                }
            }
        }
        return sum;
    }
}