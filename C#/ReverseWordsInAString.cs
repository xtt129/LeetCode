public class Solution {
    
    private void ReverseInWord(char[] s, int startIndex, int start, int end)
    {
        for(int i = start; end > start && i <= (end + start) / 2; ++i)
        {
            char temp = s[i];
            s[i] = s[end - (i - start)];
            s[end - (i - start)] = temp;
        }
        for(int i = start; i <= end; ++i)
        {
            s[startIndex + i - start] = s[i];
        }
    }
    
    public string ReverseWords(string s) {
        if(string.IsNullOrEmpty(s)) return s;
        char[] chars = s.ToCharArray();
        int len = 0;
        for(int i = 0; i < chars.Length; ++i)
        {
            while(i < chars.Length && chars[i] == ' ') ++i;
            if(i < chars.Length)
            {
                if(len > 0) chars[len ++ ] = ' ';
                int start  = i;
                while(i < chars.Length && chars[i] != ' ') ++i;
                ReverseInWord(chars, len, start, i - 1);
                len += i - start;
            }
        }
        ReverseInWord(chars,0, 0, len - 1);
        return new string(chars, 0, len);
    }
}


public class Solution2 {
    public string ReverseWords(string s) {
        if(null == s) return s;
        string[] words = s.Split(new char[1]{' '}, StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(words);
        return string.Join(" ", words);
    }
}