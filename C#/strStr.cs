public class Solution {
    //TODO: KMP
    public int StrStr(string haystack, string needle) {
        if(null == haystack || null == needle) return -1;
        for(int i = 0; i + needle.Length <= haystack.Length; ++i)
        {
            if(string.Compare(haystack.Substring(i, needle.Length), needle) ==0)
            {
                return i;
            }
        }
        return  -1;
    }
}