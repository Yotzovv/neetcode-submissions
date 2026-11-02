public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var mp = new Dictionary<char, int>();
        int l = 0, result = 0;

        for (var r = 0; r < s.Length; r++)
        {
            if (mp.TryGetValue(s[r], out var value)) l = Math.Max(value + 1, l);
            mp[s[r]] = r;
            result = Math.Max(result, r - l + 1);   
        }
        
        return result;
    }
}
