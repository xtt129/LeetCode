public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        if(nums == null || nums.Length <= 1) return false;
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; ++i)
        {
            if(dict.ContainsKey(nums[i]))
            {
                if(i - dict[nums[i]] <= k) return true;
                dict[nums[i]] = i;
            }
            else dict.Add(nums[i], i);
        }
        return false;
    }
}