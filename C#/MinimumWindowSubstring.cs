public class Solution {
    public string MinWindow(string s, string t) {
        if(string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t)) return null;
        Dictionary<char, int> chars = new Dictionary<char, int>();
        foreach(char ch in t)
        {
            if(!chars.ContainsKey(ch)) chars.Add(ch, 0);
            chars[ch] ++;
        }
        int index = 0;
        int count = 0;
        for(index= 0 ; index < s.Length && count != t.Length; ++index)
        {
            if(chars.ContainsKey(s[index]))
            {
                 chars[s[index]] --;
                 if(chars[s[index]] >= 0) ++ count;
            }
        }
        if(count != t.Length) return string.Empty;
        int minLen = index, minStart = 0, start = 0;
        while(index <= s.Length)
        {
            while(!chars.ContainsKey(s[start]) || chars[s[start]] < 0)
            {
                 if(chars.ContainsKey(s[start])) chars[s[start]] ++;
                 start ++;
                 if(index - start < minLen)
                 {
                      minLen = index - start;
                      minStart = start;
                 }
            }
            if(index < s.Length && chars.ContainsKey(s[index])) chars[s[index]] --;
            index ++;
        }
        return s.Substring(minStart, minLen);
    }
}