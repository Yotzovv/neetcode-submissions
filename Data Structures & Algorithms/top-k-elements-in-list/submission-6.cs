public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var result = nums.GroupBy(n => n)
            .OrderByDescending(x => x.Count())
            .Take(k)
            .Select(g => g.Key)
            .ToArray();

        return result;
    }
}
