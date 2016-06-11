public class Solution {
    public string Convert(string s, int numRows) {
        if(null == s || numRows <= 1) return s;
        StringBuilder zigzag = new StringBuilder();
        int step = 2 * numRows - 2;
        for(int i = 0; i < numRows; ++i)
        {
            for(int j = i; j < s.Length; j += step)
            {
                zigzag.Append(s[j]);
                int next = (numRows - i - 1) * 2 + j;
                if((next - j) % step != 0 && next < s.Length)
                {
                    zigzag.Append(s[next]);
                }
            }
        }
        return zigzag.ToString();
    }
}