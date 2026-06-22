
    public class Solution {
        public int LongestConsecutive(int[] nums) {
             if (nums.Length == 0) return 0;
            nums = nums.OrderBy(x => x).ToArray();

            int longest = 1, count = 1;
            for (int i = 1; i < nums.Length; i++) {
                int diff = nums[i] - nums[i - 1];
                if (diff == 0) continue;        // duplicate — ignore, don't break the run
                if (diff == 1) count++;         // consecutive — extend
                else count = 1;                 // gap — start a new run
                longest = Math.Max(longest, count);
            }
            return longest;
        }
    }