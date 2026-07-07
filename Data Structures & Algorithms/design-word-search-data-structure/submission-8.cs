public class WordDictionary {
    private static TrieNode _root;

    public WordDictionary() {
        _root = new TrieNode();
    }
    
    public void AddWord(string word) {
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
        Console.WriteLine(result);
        return result;
    }
    
    private static bool SearchHelper(TrieNode? node, string word, int i)
    {
        if (node == null) return false;
        if (i == word.Length) return node.IsEndOfWord;
        
        var index = word[i] - 'a';

        if (index < 0 || index >= node.Children.Length)
        {
            Console.WriteLine(index);
            for (int x = 0; x < 26; x++)
            {
                if (node.Children[x] != null)
                {
                    var foundMatch = SearchHelper(node.Children[x], word, i + 1);
                    
                    if (foundMatch) return true;                }
            }
        }
        else
        {
            return SearchHelper(node.Children[index], word, i + 1);
        }

        return false;
    }
}

public class TrieNode {
    public TrieNode[] Children = new TrieNode[26];
    
    public bool IsEndOfWord = false; 
}

