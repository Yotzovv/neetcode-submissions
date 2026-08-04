public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        var hashtable = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) hashtable[nums[i]] = i;

        for (int i = 0; i < nums.Length; i++)
        {
            var diff = target - nums[i];
            if (hashtable.ContainsKey(diff) && hashtable[diff] != i)
            {
                return [i, hashtable[diff]];
            }
        }

        return [];
    }
}
