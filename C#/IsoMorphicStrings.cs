public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if(string.Compare(s, t) == 0) return true;
        if(string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t)) return false;
        if(s.Length != t.Length) return false;
        Dictionary<char, char> map = new Dictionary<char, char>();
        Dictionary<char, char> map2 = new Dictionary<char, char>();
        for(int i = 0; i < s.Length; ++i)
        {
            char chs = s[i], cht = t[i];
            if(!map.ContainsKey(chs)) map.Add(chs, cht);
            if(!map2.ContainsKey(cht)) map2.Add(cht, chs);
            if(map[chs] != cht || map2[cht] != chs) return false;
        }
        return true;
    }
}