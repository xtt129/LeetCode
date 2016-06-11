public class Solution {
    
    public int LongestConsecutive(int[] nums) {
        if(null == nums.Length) return 0;
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int lcc = 0;
        foreach(int num in nums)
        {
            if(!dict.ContainsKey(num))
            {
                int left = dict.ContainsKey(num - 1)? dict[num - 1] : 0;
                int right = dict.ContainsKey(num + 1)? dict[num + 1] : 0;
                int value = left + right + 1;
                dict.Add(num, value);
                dict[num - left] = value;
                dict[num + right] = value;
                lcc = Math.Max(lcc, value);
            }
        }
        return lcc;
    }
}