public class Solution
    {
        public int CharacterReplacement(string s, int k)
        {
            var charCounts = new int[26];
            var maxCount = 0;
            var left = 0;
            var maxFreq = 0;

            for (int right = 0; right < s.Length; ++right)
            {
                int rightCharIdx = s[right] - 'A';
                charCounts[rightCharIdx]++;
        
                maxFreq = Math.Max(maxFreq, charCounts[rightCharIdx]);

                while ((right - left + 1) - maxFreq > k)
                {
                    int leftCharIdx = s[left] - 'A';
                    charCounts[leftCharIdx]--;
                    left++;
                }

                if (right - left + 1 > maxCount)
                {
                    maxCount = right - left + 1;
                }
            }

            return maxCount;
        }
    }