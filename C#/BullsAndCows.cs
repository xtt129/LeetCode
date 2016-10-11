public class Solution {
    public string GetHint(string secret, string guess) {
        if(string.IsNullOrEmpty(secret)) return "0A0B";
        Dictionary<char, int> dict = new Dictionary<char, int>();
        foreach(char ch in secret)
        {
             if(!dict.ContainsKey(ch)) dict.Add(ch, 0);
             dict[ch] ++;
        }
        int bulls = 0, cows = 0;
        for(int i =0; i<secret.Length && i<guess.Length; ++i)
        {
             if(secret[i] == guess[i])
             {
                 ++bulls;
                 -- dict[secret[i]];
             }
        }
        for(int i = 0; i <guess.Length; ++i)
        {
             if(i < secret.Length && secret[i] == guess[i]) continue;
             if(dict.ContainsKey(guess[i]) && dict[guess[i]] > 0)
             {
                  ++cows;
                  --dict[guess[i]];
             }
        }
        return string.Format("{0}A{1}B", bulls, cows);
    }
}