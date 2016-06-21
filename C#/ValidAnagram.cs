public class Solution {
    public bool IsAnagram(string s, string t) {
        if(null == s && t == null) return true;
        if(null == s) return false;
        if(null == t) return false;
        Dictionary<char, int> chars = new Dictionary<char, int>();
        foreach(char ch in s)
        {
            if(!chars.ContainsKey(ch)) chars.Add(ch, 0);
            chars[ch] ++;
        }
        foreach(char ch in t)
        {
            if(!chars.ContainsKey(ch) || chars[ch] == 0) return false;
            chars[ch] --;
        }
        return t.Length == s.Length;
    }
}