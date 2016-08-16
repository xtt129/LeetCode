class TrieNode {
    // Initialize your data structure here.
    public string value {get; set;}
    private TrieNode[] next;
    
    public TrieNode() {
        next = new TrieNode[26];
    }
    
    public TrieNode SearchMatchedNode(string word, int index)
    {
        if(index == word.Length) return this;
        int idx = (int)(word[index] - 'a');
        if(next[idx] == null) return null;
        return next[idx].SearchMatchedNode(word, index+1);
    }
    
    public TrieNode CreateMatchedNode(string word, int index)
    {
        if(index == word.Length) return this;
        int idx= (int)(word[index] - 'a');
        if(next[idx] == null) next[idx] = new TrieNode();
        return next[idx].CreateMatchedNode(word, index+1);
    }
    
}

public class Trie {
    private TrieNode root;

    public Trie() {
        root = new TrieNode();
    }

    // Inserts a word into the trie.
    public void Insert(String word) {
        if(string.IsNullOrEmpty(word)) return;
        var node = root.CreateMatchedNode(word, 0);
        node.value = word;
    }

    // Returns if the word is in the trie.
    public bool Search(string word) {
        var node = root.SearchMatchedNode(word, 0);
        return node != null && node.value != null;
    }

    // Returns if there is any word in the trie
    // that starts with the given prefix.
    public bool StartsWith(string word) {
        var node = root.SearchMatchedNode(word, 0);
        return node != null;
    }
}

// Your Trie object will be instantiated and called as such:
// Trie trie = new Trie();
// trie.Insert("somestring");
// trie.Search("key");