public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        if(null == nums || nums.Length ==0) return false;
        HashSet<int> set = new HashSet<int>();
        foreach(var num in nums)
        {
            if(set.Contains(num)) return true;
            set.Add(num);
        }
        return false;
    }
}