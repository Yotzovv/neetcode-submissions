public class Solution {
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;

        var frequencies = new int[26];
        for (var i = 0; i < s.Length; i++)
        {
            var sIndex = s[i] - 'a';
            var tIndex = t[i] - 'a';
            frequencies[sIndex]++;
            frequencies[tIndex]--;
        }

        return frequencies.All(item => item == 0);
    }
}
