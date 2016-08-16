public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        if( null == strs || strs.Length == 0) return null;
        IList<IList<string>> ans = new List<IList<string>>();
        Dictionary<string, int> index = new Dictionary<string, int>();
        int count = 0;
        foreach(string str in strs)
        {
            char[] bytes = str.ToCharArray();
            Array.Sort(bytes);
            string key = new string(bytes);
            if(!index.ContainsKey(key))
            {
                ans.Add(new List<string>());
                index.Add(key, ans.Count - 1);
            }
            ans[index[key]].Add(str);
        }
        return ans;
    }
}