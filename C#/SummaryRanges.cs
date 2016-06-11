public class Solution {
    private string GetRange(int left, int right)
    {
        if(left == right) return left.ToString();
        return string.Format("{0}->{1}", left, right);
    }
    public IList<string> SummaryRanges(int[] nums) {
        IList<string> ranges = new List<string>();
        if(null == nums || nums.Length == 0) return ranges;
        int left = 0, current = nums[0], right = 1;
        for(; right < nums.Length; ++right)
        {
            if(nums[right] != current + 1)
            {
                ranges.Add(GetRange(nums[left], current));
                left = right;
            }
            current = nums[right];
        }
        ranges.Add(GetRange(nums[left], current));
        return ranges;
    }
}