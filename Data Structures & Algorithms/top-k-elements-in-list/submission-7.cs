public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
    {
        Array.Sort(nums);
        var ht = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (!ht.TryAdd(num, 1)) ht[num]++;
        }

        ht = ht.OrderByDescending(x => x.Value).ToDictionary();

        var result = ht.Keys.Take(k).ToArray();

        return result;
    }
}
