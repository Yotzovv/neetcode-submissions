    public class Solution {
        public bool IsPalindrome(string s) {
            var reversed = new StringBuilder();
            for(int i = s.Length-1; i >= 0; i--)
                if(char.IsAsciiLetterOrDigit(s[i])) reversed.Append(s[i]);
    
            var normalized = new StringBuilder();
            for(int i = 0; i < s.Length; i++)
                if(char.IsAsciiLetterOrDigit(s[i])) normalized.Append(s[i]);
                
            return normalized.ToString().ToLower().Equals(reversed.ToString().ToLower());
        }
    }