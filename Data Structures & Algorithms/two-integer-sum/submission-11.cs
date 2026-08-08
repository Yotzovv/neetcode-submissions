public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        var hashmap = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            var diff = target - nums[i];
            if (hashmap.TryGetValue(diff, out var value)) return [value, i];
            hashmap[nums[i]] = i;
        }

        return [];
    }
}
