public class Solution {
    private string GetLine(string[] words, int maxWidth, int start, int end, int length, bool lastLine)
    {
        StringBuilder sb = new StringBuilder();
        int whiteSpaces = maxWidth - length;
        for(int i = start; i < end; ++i)
        {
            int whiteSpaceBetween = lastLine ? 1 : (whiteSpaces - 1) / (end - i) + 1;
            whiteSpaces -= whiteSpaceBetween;
            sb.Append(words[i]).Append(' ', whiteSpaceBetween);
        }
        sb.Append(words[end]);
        sb.Append(' ', whiteSpaces);
        return sb.ToString();
    }

    public IList<string> FullJustify(string[] words, int maxWidth) 
    {
        IList<string> text = new List<string>();
        if(null == words) return text;
        int length  = 0, start = 0;
        for(int i = 0; i < words.Length; ++i)
        {
            if((length + words[i].Length + i - start) > maxWidth)
            {
                text.Add(GetLine(words, maxWidth, start, i - 1, length, false));
                length =  0;
                start = i;
            }
            length += words[i].Length;
        }
        if(start < words.Length)
        {
            text.Add(GetLine(words, maxWidth, start, words.Length - 1, length, true));
        }
        return text;
    }
}