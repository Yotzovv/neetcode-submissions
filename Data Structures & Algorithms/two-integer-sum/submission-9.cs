public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        var ht = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) ht[nums[i]] = i;

        for (int i = 0; i < nums.Length; i++)
        {
            var diff = target - nums[i];

            if (ht.ContainsKey(diff) && ht[diff] != i)
            {
                return [i, ht[diff]];
            }
        }

        return [];
    }
}
