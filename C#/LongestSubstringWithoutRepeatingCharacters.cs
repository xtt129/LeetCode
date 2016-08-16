public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(string.IsNullOrEmpty(s)) return 0;
        Dictionary<char, int> pos = new Dictionary<char, int>();
        int start = 0, len = 0;
        int max = 0;
        for(int i = 0; i < s.Length; ++i)
        {            
            if(!pos.ContainsKey(s[i]))
            {
                pos.Add(s[i], -1);
            }
            if(pos[s[i]] < start)
            {
                pos[s[i]] = i;
                ++ len;
            }
            else
            {
                start = pos[s[i]] + 1;
                pos[s[i]] = i;
                max = Math.Max(max, len);
                len = i - start + 1;
            }
        }
        max = Math.Max(max, len);
        return max;
    }
}