public class Solution {
    
    
    public bool IsNumber(string s) {
        if(string.IsNullOrWhiteSpace(s)) return false;
        s = s.Trim();
        bool isNumberic = false;
        int start = 0;
        if(s[start] == '+' || s[start] == '-') ++start;
        while(start < s.Length && char.IsNumber(s[start]))
        {
            ++ start;
            isNumberic = true;
        }
        if(start < s.Length && s[start] == '.')
        {
            ++start;
            while(start < s.Length && char.IsNumber(s[start]))
            {
                ++start;
                isNumberic = true;
            }
        }
        if(start < s.Length && s[start] == 'e' && isNumberic)
        {
            ++start;
            isNumberic = false;
            if(start < s.Length && (s[start] == '+' || s[start] == '-')) ++ start;
            while(start < s.Length && char.IsNumber(s[start]))
            {
                ++start;
                isNumberic = true;
            }
        }
        return isNumberic && start == s.Length;
    }
}