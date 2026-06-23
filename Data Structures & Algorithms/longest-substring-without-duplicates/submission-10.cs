public class Solution {
        public int LengthOfLongestSubstring(string s)
        {
            var charSet = new HashSet<char>();
            var maxLgth = 0;
            var left = 0;
            
            for (int right = 0; right < s.Length; right++)
            {
                while(charSet.Contains(s[right]))
                {
                    charSet.Remove(s[left]);
                    left++;
                }
                
                charSet.Add(s[right]);

                var currentLgth = right - left + 1;
                if (currentLgth > maxLgth)
                    maxLgth = currentLgth;
            }
            
            
            return maxLgth;
        }
    }