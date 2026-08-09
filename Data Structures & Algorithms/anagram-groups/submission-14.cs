public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
        var hashmap = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {
            var count = new int[26];
            foreach (var ch in str) count[ch - 'a']++;  //010101
            
            var key = string.Join(",", count);
            if (!hashmap.ContainsKey(key)) hashmap[key] = [];
            hashmap[key].Add(str);
        }
        
        return hashmap.Values.ToList();
    }
}
