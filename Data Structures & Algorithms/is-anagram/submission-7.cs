public class Solution {
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;

        var sHashmap = new Dictionary<char, int>();
        var tHashmap = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            sHashmap[s[i]] = sHashmap.GetValueOrDefault(s[i], 0) + 1;
            tHashmap[t[i]] = tHashmap.GetValueOrDefault(t[i], 0) + 1;
        }
        
        return sHashmap.Count == tHashmap.Count && !sHashmap.Except(tHashmap).Any();
    }
}
