public class Solution {
    public bool WordPattern(string pattern, string str) {
        if(string.IsNullOrEmpty(str) && string.Equals(pattern, str)) return true;
        if(string.IsNullOrEmpty(str) || string.IsNullOrEmpty(pattern)) return false;
        string[] words = str.Split(new char[1]{' '}, StringSplitOptions.RemoveEmptyEntries);
        if(words.Length != pattern.Length) return false;
        Dictionary<char, string> map1 = new Dictionary<char, string>();
        Dictionary<string, char> map2 = new Dictionary<string, char>();
        for(int i = 0; i < words.Length; ++i)
        {
            if(!map1.ContainsKey(pattern[i])) map1.Add(pattern[i], words[i]);
            if(!map2.ContainsKey(words[i])) map2.Add(words[i], pattern[i]);
            if(map1[pattern[i]] != words[i] || map2[words[i]] != pattern[i]) return false;
        }
        return true;
    }
}