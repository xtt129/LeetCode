public class Solution {
    public string LongestPalindrome(string s) {
        if(null == s || s.Length == 0) return s;
        int maxLen = 0, maxStart = 0;
        for(int start = 0; start < s.Length && s.Length - start > maxLen / 2;)
        {
            int left = start, right = start;
            while(right + 1 < s.Length && s[right] == s[right + 1]) ++right;
            start = right + 1;
            for(; left >=0 && right < s.Length && s[right] == s[left];)
            {
                ++right;
                --left;
            }
            if(right - left - 1 > maxLen)
            {
                maxLen = right - left - 1;
                maxStart = left + 1;
            }
        }
        return s.Substring(maxStart, maxLen);
    }
}