public class Solution {
    struct LineInfo
    {
        public int wordLength;
        public int wordCount;
        public LineInfo(int length, int count)
        {
            wordLength = length;
            wordCount = count;
        }
    }
    
    private LineInfo  FindLineEnding(string[] words, int start, int maxWidth)
    {
        int count = 0;
        int length = 0;
        for(int i = start; i < words.Length && length + words[i].Length + count <= maxWidth; ++i)
        {
            ++count;
            length += words[i].Length;
        }
        return new LineInfo(length, count);
    }

    //TODO: Ugly code.
    public IList<string> FullJustify(string[] words, int maxWidth) {
        IList<string> text = new List<string>();
        if(null == words) return text;
        for(int i = 0; i < words.Length;)
        {
            LineInfo info = FindLineEnding(words, i, maxWidth);
            StringBuilder sb = new StringBuilder();
            if(info.wordCount == 1)
            {
                sb.Append(words[i]).Append(' ',maxWidth - words[i].Length);
            }
            else
            {
                int whiteSpaces = i + info.wordCount == words.Length ? info.wordCount - 1 : maxWidth - info.wordLength;
                
                for(int j = i; j < i + info.wordCount - 1; ++j)
                {
                    int whiteSpacesEach = (whiteSpaces - 1) / (info.wordCount - 1 - (j - i)) + 1;
                    sb.Append(words[j]);
                    sb.Append(' ', whiteSpacesEach);
                    whiteSpaces -= whiteSpacesEach;
                }
                string lastWord = words[i + info.wordCount - 1];
                sb.Append(lastWord);
                if(i + info.wordCount == words.Length)
                {
                    sb.Append(' ', maxWidth - sb.Length);
                }
            }
            text.Add(sb.ToString());
            i += info.wordCount;
        }
        return text;
    }
}