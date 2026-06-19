public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var result = new List<List<string>>();

        for(int x = 0; x < strs.Length; x++)
        {
            if(!CanAddToList(strs[x], result)) continue;
                    
            var list = new List<string>() { strs[x] };

            for(int i = x+1; i < strs.Length; i++)
            {
                if(IsAnagram(strs[x], strs[i]))
                {
                    if(CanAddToList(strs[i], result))
                    {
                        list.Add(strs[i]);
                    }
                }
            }

            result.Add(list);
        }

        return result;
    }

    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        var sDict = GetDictionary(s);
        var tDict = GetDictionary(t);

        foreach(var pair in sDict)
        {
            foreach(var pair2 in tDict)
            {
                if(!sDict.ContainsKey(pair2.Key)) return false;

                if(pair.Key != pair2.Key) continue;

                if(pair.Value != pair2.Value)
                    return false;
            }
        }
        
        return true;
    }

    public Dictionary<char, int> GetDictionary(string input)
    {
        var letters = new Dictionary<char, int>();

        for(var a = 0; a < input.Length; a++)
        {
            if(letters.ContainsKey(input[a])) letters[input[a]]++;
            else letters[input[a]] = 1;
        }

        return letters;
    }

    public bool CanAddToList(string word, List<List<string>> lists)
    {
        foreach(var list in lists)
        {
            if(list.Contains(word)) return false;
        }

        return true;
    }
}
