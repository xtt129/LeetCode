public class Solution {
    public int TitleToNumber(string s) {
        if(string.IsNullOrEmpty(s)) return 0;
        int number = 0;
        int factor = 1;
        for(int i = s.Length - 1; i >= 0; --i)
        {
            int digit = s[i] - 'A' + 1;
            number += digit * factor;
            factor *= 26;
        }
        return number;
    }
}