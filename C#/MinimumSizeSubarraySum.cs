public class Solution {
    public int MinSubArrayLen(int s, int[] nums) {
        if(null == nums) return 0;
        int left = 0, right = -1;
        int length  = int.MaxValue;
        int sum = 0;
        while(right < nums.Length - 1)
        {
            ++ right;
            sum += nums[right];
            while(sum >= s)
            {
                length =Math.Min(length, right - left + 1);
                sum -= nums[left++];
            }
        }
        return length == int.MaxValue ? 0 : length;
    }
}

