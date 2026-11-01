public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var charset = new HashSet<char>();
        var left = 0;
        var result = 0;

        for (var r = 0; r < s.Length; r++)
        {
            while (charset.Contains(s[r]))
            {
                charset.Remove(s[left]);
                left++;
            }

            charset.Add(s[r]);
            result = Math.Max(result, r - left + 1);
        }
        
        return result;
    }
}
