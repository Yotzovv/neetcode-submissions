public class PrefixTree
{
    private static TrieNode _root;

    public PrefixTree()
    {
        _root = new TrieNode();
    }

    public void Insert(string word)
    {
        TrieNode current = _root;

        foreach (char c in word)
        {
            int index = c - 'a';
            current.Children[index] ??= new TrieNode();
            current = current.Children[index];
        }

        current.IsEndOfWord = true;        
    }

    public bool Search(string word)
    {
        var result = SearchHelper(_root, word, 0);
        return result;
    }
    
    private static bool SearchHelper(TrieNode? node, string word, int i)
    {
        if (node == null) return false;
        if (i == word.Length) return node.IsEndOfWord;
        
        var index = word[i] - 'a';

        return SearchHelper(node.Children[index], word, i + 1);
    }
    

    public bool StartsWith(string prefix)
    {
        var current = _root;
        
        for (int i = 0; i < prefix.Length; i++)
        {
            int index = prefix[i] - 'a';
            
            if (current.Children[index] == null) return false;
            current = current.Children[index];
        }
        
        return true;
    }
}

public class TrieNode {
    public TrieNode[] Children = new TrieNode[26];
    
    public bool IsEndOfWord = false; 
}