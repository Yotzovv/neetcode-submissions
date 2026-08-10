public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
    {
        var freqMap = new Dictionary<int, int>();
        var frequencies = new List<int>[nums.Length + 1];

        foreach (var num in nums) if (!freqMap.TryAdd(num, 1)) freqMap[num]++;
        for (var i = 0; i < frequencies.Length; i++) frequencies[i] = [];
        foreach (var pair in freqMap) frequencies[pair.Value].Add(pair.Key);

        int[] res = new int[k];
        int index = 0;
        for (var i = frequencies.Length - 1; i > 0 && index < k; i--) {
            foreach (int n in frequencies[i]) {
                res[index++] = n;
                if (index == k) {
                    return res;
                }
            }
        }
        
        return res;
    }
}