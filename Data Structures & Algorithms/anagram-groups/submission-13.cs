public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
        var hashmap = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {
            var count = new int[26];

            foreach (var ch in str) count[ch - 'a']++;            
            var newStr = string.Join(",", count);

            if (!hashmap.ContainsKey(newStr)) hashmap[newStr] = [];
            hashmap[newStr].Add(str);
        }
        
        return hashmap.Values.ToList<List<string>>();
    }
}
