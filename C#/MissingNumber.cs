public class Solution {
    public int MissingNumber(int[] nums) {
        int num = nums.Length;
        for(int i = 0; i < nums.Length; ++i)
        {
            num ^= i ^ nums[i];
        }
        return num;
    }
}