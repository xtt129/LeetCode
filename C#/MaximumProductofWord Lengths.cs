public class Solution {
    private int Convert(string word)
    {
        int bitValue = 0;
        foreach(var ch in word)
        {
            bitValue |= 1 << (int)(ch - 'a');
        }
        return bitValue;
    }
    
    public int MaxProduct(string[] words) {
        if(words == null) return 0;
        int[] bits = new int[words.Length];
        for(int i = 0; i < words.Length; ++i)
        {
            bits[i] = Convert(words[i]);
        }
        int maxProduct = 0;
        for(int i =0; i < words.Length - 1; ++i)
        {
            for(int j = i+1; j < words.Length; ++j)
            {
                if((bits[i] & bits[j]) == 0)
                {
                    maxProduct = Math.Max(maxProduct, words[i].Length * words[j].Length);
                }
            }
        }
        return maxProduct;
    }
}