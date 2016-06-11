public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if(null == strs || strs.Length == 0) return string.Empty;
        for(int start = 0; start < strs[0].Length; ++ start)
        {
           for(int i = 1; i < strs.Length; ++i)
           {
               if(strs[i] == null || strs[i].Length <= start || strs[i][start] != strs[0][start])
               {
                   return strs[0].Substring(0, start);
               }
           }
        }
        return strs[0].ToString();
    }
}