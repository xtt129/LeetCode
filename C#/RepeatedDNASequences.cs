public class Solution
{
    public IList<string>  FindRepeatedDnaSequences(string s)
    {
        if(string.IsNullOrEmpty(s)) return new List<string>();
        HashSet<int> set = new HashSet<int>();
        HashSet<int> doubleSet = new HashSet<int>();
        List<string> ans = new List<string>();
        Dictionary<char, int> bits = new Dictionary<char, int>(){{'A', 0}, {'C', 1},{'G', 2},{'T', 3}};
        for(int i = 9; i < s.Length; ++i)
        {
            int hash = 0;
            for(int j = i - 9; j <= i; ++j)
            {
                hash = hash << 2;
                hash |= bits[s[j]];
            }
            if(set.Contains(hash) && !doubleSet.Contains(hash))
            {
                doubleSet.Add(hash);
                ans.Add(s.Substring(i-9, 10));
            }
            set.Add(hash);
        }
        return ans;
    }
}