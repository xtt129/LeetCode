public class Solution {
    public int RemoveElement(int[] nums, int val) {
        if(null == nums || nums.Length == 0) return 0;
        int newLength = 0;
        foreach(var num in nums)
        {
            if(num != val)
            {
                nums[newLength++] = num;
            }
        }
        return newLength;
    }
}