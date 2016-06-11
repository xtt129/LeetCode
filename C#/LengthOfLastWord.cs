public class Solution {
    public int LengthOfLastWord(string s) {
        if(null == s) return 0;
        int index = s.Length - 1;
        int length = 0;
        Array.FindLastIndex(s)
        while(index >= 0 && s[index] == ' ') --index;
        while(index >=0 && s[index] != ' ')
        {
            ++length;
            --index;
        }
        return length;
    }
}