public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        if(null == nums || nums.Length == 0) return null;
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for(int i = 0 ; i < nums.Length; ++i)
        {
            if(!dict.ContainsKey(target - nums[i]))
            {
                if(!dict.ContainsKey(nums[i])) dict.Add(nums[i], i);
            }
            else
            {
                return new int[2] {dict[target - nums[i]], i};
            }
        }
        return null;
    }
}