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
        
        Console.WriteLine($"Inserting: {word}");
    }

    public bool Search(string word)
    {
        TrieNode? current = _root;
        bool result = true;
        
        for (int i = 0; i < word.Length; i++)
        {
            int index = word[i] - 'a';
            if (current?.Children[index] == null) result = false;
            current = current?.Children?[index];
        }
        
        Console.WriteLine($"Searching for {word} --->> {result && current.IsEndOfWord}.  IsEndOfWord: {current?.IsEndOfWord}");
        return result && current.IsEndOfWord;
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
        
        Console.WriteLine($"Starts with {prefix} --> {true}");
        return true;
    }
}

public class TrieNode {
    public TrieNode[] Children = new TrieNode[26];
    
    public bool IsEndOfWord = false; 
}