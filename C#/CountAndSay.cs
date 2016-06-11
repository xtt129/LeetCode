public class Solution {
    private StringBuilder GetNext(StringBuilder s)
    {
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < s.Length;)
        {
            int j = i + 1;
            while(j < s.Length && s[j] == s[i]) ++j;
            sb.Append(j-i).Append(s[i]);
            i = j;
        }
        return sb;
    }
    
    public string CountAndSay(int n) {
        StringBuilder current = new StringBuilder("1");
        for(int i = 2; i <= n; ++i)
        {
            current = GetNext(current);
        }
        return current.ToString();
    }
}