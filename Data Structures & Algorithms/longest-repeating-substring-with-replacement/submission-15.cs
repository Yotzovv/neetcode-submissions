public class Solution {
    public int CharacterReplacement(string s, int k) {
        var count = new int[26];
        int l = 0, maxFreq = 0;

        for (var r = 0; r < s.Length; r++)
        {
            maxFreq = Math.Max(maxFreq, ++count[s[r] - 'A']);
            if (r - l + 1 - maxFreq > k) count[s[l++] - 'A']--;
        }

        return s.Length - l;
    }
}
