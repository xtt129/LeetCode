public class WordDictionary {

    private class TrieNode
    {
        TrieNode[] nodes = new TrieNode[26];
        public string value;
        public TrieNode()
        {
        }
        
        public void AddWord(string word, int index)
        {
            if(index == word.Length)
            {
                this.value = word;
                return;
            }
            int idx = (int)(word[index] - 'a');
            if(nodes[idx] == null) nodes[idx] = new TrieNode();
            nodes[idx].AddWord(word, index+1);
        }
        
        public bool Search(string word, int index)
        {
            if(index == word.Length) return this.value != null;
            if(word[index] == '.')
            {
                foreach(var value in nodes)
                {
                    if(value != null && value.Search(word, index + 1)) return true;
                }
                return false;
            }
            else
            {
                int idx = (int)(word[index] - 'a');
                return nodes[idx] != null && nodes[idx].Search(word, index + 1);
            }
        }
    }
    
    private TrieNode root = new TrieNode();
    

    // Adds a word into the data structure.
    public void AddWord(String word) {
        if(null == word) return;
        root.AddWord(word, 0);
    }

    // Returns if the word is in the data structure. A word could
    // contain the dot character '.' to represent any one letter.
    public bool Search(string word) {
        if(null == word) return false;
        return root.Search(word, 0);
    }
}

// Your WordDictionary object will be instantiated and called as such:
// WordDictionary wordDictionary = new WordDictionary();
// wordDictionary.AddWord("word");
// wordDictionary.Search("pattern");