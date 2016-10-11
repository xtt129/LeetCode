using System.Linq;
public class Solution {

    private string reverseString(string word)
    {
        char[] chars = word.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    private bool IsPalindrome(string word, int start, int len)
    {
        if(len == 0) return true;
        int last = start + len - 1;
        for(int i = start; i <= (start + last) / 2; ++i)
        {
            if(word[i] != word[last - (i - start)]) return false;
        }
        return true;
    }

    //candidate+word is palindrome
    private List<string> getPreCandidates(string word)
    {
        List<string> subs = new List<string>();
        string reverse = reverseString(word);
        for(int i = 1; i < word.Length; ++i)
        {
             if(IsPalindrome(word, 0, i))
             {
                 subs.Add(reverse.Substring(0, word.Length - i));
             }
        }
        return subs;
    }

    //word+candidate is palindrome
    private List<string>  getLatCandidates(string word)
    {
        List<string> subs = new List<string>();
        string reverse = reverseString(word);
        for(int i = word.Length - 1; i >= 1; --i)
        {
            if(IsPalindrome(reverse, 0, word.Length - i))
            {
                subs.Add(reverse.Substring(word.Length - i, i));
            }
        }
        return subs;
    }

    public IList<IList<int>> PalindromePairs(string[] words) {
        IList<IList<int>> ans = new List<IList<int>>();
        if(words == null || words.Length ==0) return ans;
        Dictionary<string, int> dict = new Dictionary<string, int>();
        for(int i = 0 ; i < words.Length; ++i)
        {
            dict.Add(words[i], i);
        }
        if(dict.ContainsKey(string.Empty))
        {
            foreach(var word in words.Where(w=> w.Length > 0 && IsPalindrome(w, 0 , w.Length)))
            {
                ans.Add(new List<int>(){dict[word], dict[string.Empty]});
                ans.Add(new List<int>(){dict[string.Empty], dict[word]});
            }
        }
        for(int i = 0; i <words.Length; ++i)
        {
            if(words[i].Length == 0) continue;
            string reverse = reverseString(words[i]);
            if(dict.ContainsKey(reverse) && dict[reverse] != i) ans.Add(new List<int>(){ i, dict[reverse] });
            
            var subs = getPreCandidates(words[i]);
            foreach(var word in subs.Where(w=> dict.ContainsKey(w)))
            {
                 ans.Add(new List<int>(){dict[word], i});
            };
            subs = getLatCandidates(words[i]);
            foreach(var word in subs.Where(w=> dict.ContainsKey(w)))
            {
                ans.Add(new List<int>(){i, dict[word]});
            };
        }
        return ans;
    }
}