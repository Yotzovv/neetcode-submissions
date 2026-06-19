public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var elementsCount = new Dictionary<int, int>();

        for(var i=0; i < nums.Length; i++)
        {
            if(elementsCount.ContainsKey(nums[i])) elementsCount[nums[i]]++;
            else elementsCount[nums[i]] = 1;
        }
        
        elementsCount = elementsCount.OrderByDescending(x => x.Value).ToDictionary();

        var result = new int[k];

        for(int y=0; y < k; y++)
        {
            result[y] = elementsCount.ElementAt(y).Key;
        }

        return result;
    }
}
