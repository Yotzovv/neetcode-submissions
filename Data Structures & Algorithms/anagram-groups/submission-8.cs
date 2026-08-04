public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
        var ht = new Dictionary<string, List<string>>();
        var result = new List<List<string>>();

        for(int i=0;i<strs.Length;i++)
        {
            var contains = ht.Any(x => x.Value.Contains(strs[i]));
            
            if (contains) continue;
            
            ht.Add(strs[i], [strs[i]]);
            
            for (var x = i+1; x < strs.Length; x++)
            {
                if (IsAnagram(strs[i].ToCharArray(), strs[x].ToCharArray()))
                {
                    ht[strs[i]].Add(strs[x]);
                }
            }
        }

        foreach (var h in ht)
        {
            result.Add(h.Value);
        }
        
        return result;
    }

    private bool IsAnagram(char[] str1, char[] str2)
    {
        if (str1.Length != str2.Length) return false;
        Array.Sort(str1);
        Array.Sort(str2);

        for (int i = 0; i < str1.Length; i++)
        {
            if (str1[i] != str2[i]) return false;
        }

        return true;
    }
}
