public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
        var hashmap = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {
            var sorted = str.ToCharArray();
            Array.Sort(sorted);
            var newStr = new string(sorted);

            if (!hashmap.ContainsKey(newStr)) hashmap[newStr] = [str];
            else hashmap[newStr].Add(str);
        }

        return hashmap.Values.ToList();
    }
}
