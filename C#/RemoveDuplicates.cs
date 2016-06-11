public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(null == nums || nums.Length ==0) return 0;
        int newLength = 1;
        foreach(int num in nums)
        {
            if(num != nums[newLength-1])
            {
                nums[newLength++] = num;
            }
        }
        return newLength;
    }
}