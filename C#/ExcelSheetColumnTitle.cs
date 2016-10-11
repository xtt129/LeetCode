public class Solution {
    public string ConvertToTitle(int n) {
        if(n <= 0) return string.Empty;
        List<char> chars = new List<char>();
        while(n > 0)
        {
            n--;
            chars.Add((char)(n % 26 + 'A'));
            n /= 26;
        }
        chars.Reverse();
        return new string(chars.ToArray());
    }
}