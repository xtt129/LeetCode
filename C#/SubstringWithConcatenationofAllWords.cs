public class Solution {
    public IList<int> FindSubstring(string s, string[] words) {
        if(string.IsNullOrEmpty(s) || words == null || words.Length == 0) return new List<int>();
        int len = words[0].Length;
        Dictionary<string, int> set = new Dictionary<string, int>();
        foreach(var word in words)
        {
            if(!set.ContainsKey(word)) set.Add(word, 0);
            set[word] ++;
        }
        IList<int> ans = new List<int>();
        Dictionary<string, int> count = new Dictionary<string, int>();
        for(int i = 0; i <= s.Length - len * words.Length; ++i)
        {
            string word = s.Substring(i, len);
            count.Clear();
            int num = 0;
            while(set.ContainsKey(word) && (!count.ContainsKey(word) || count[word] < set[word]) && num < words.Length)
            {
                ++num;
                if(!count.ContainsKey(word)) count.Add(word, 0);
                count[word] ++;
                if(num < words.Length) word = s.Substring(i + len * num, len);
            }
            if(num == words.Length) ans.Add(i);
        }
        return ans;
    }
}