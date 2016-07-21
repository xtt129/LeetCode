public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        if(null == nums) return null;
        if(nums.Length == 0 || nums.Length < k) return new int[0];
        LinkedList<int> window = new LinkedList<int>();
        int[] ans = new int[nums.Length - k + 1];
        for(int i = 0 ; i < nums.Length; ++i)
        {
            if(window.Count > 0 && window.First.Value < i - k + 1) window.RemoveFirst();
            while(window.Count > 0 && nums[window.Last.Value] < nums[i]) window.RemoveLast();
            window.AddLast(i);
            if(i >= k -1)  ans[i - (k - 1)] = nums[window.First.Value];
        }
        return ans;
    }
}