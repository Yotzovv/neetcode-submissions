public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
    {
        var hashmap = new Dictionary<int, int>();
        foreach (var num in nums) if(!hashmap.TryAdd(num, 1)) hashmap[num]++;

        var minHeap = new PriorityQueue<int, int>();
        foreach (var pair in hashmap)
        {
            minHeap.Enqueue(pair.Key, pair.Value);
            if (minHeap.Count > k) minHeap.Dequeue();
        }

        var result = new int[k];
        for (int i = 0; i < k; i++) result[i] = minHeap.Dequeue();
        
        return result;
    }
}
