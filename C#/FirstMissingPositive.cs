public class Solution {
    public int FirstMissingPositive(int[] nums) {
        if(null == nums) return 1;
        for(int i = 0; i < nums.Length; ++i)
        {
            int x = nums[i];
            while(x > 0 && x <= nums.Length && nums[x - 1] != x)
            {
                int t = nums[x - 1];
                nums[x - 1] = x;
                x  = t;
            }
        }
        for(int i = 0; i < nums.Length; ++i)
        {
            if(i+1 != nums[i])
            {
                return i+1;
            }   
        }
        return nums.Length + 1;
    }
}