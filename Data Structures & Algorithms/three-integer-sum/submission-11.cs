public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {   // nums=[-1,0,1,2,-1,-4]
        Array.Sort(nums);                           // nums=[-4,-1,-1,0,1,2]
        
        var hashmap = new Dictionary<int, int>();       // {-4:1, -1:1, 0:1, 1:1, 2:1}
        foreach (var num in nums)
        {
            if (!hashmap.ContainsKey(num)) hashmap[num] = 0;
            hashmap[num]++;
        }

        var res = new List<List<int>>();
        for (var i = 0; i < nums.Length; i++)
        {
            hashmap[nums[i]]--;
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            for (var j = i + 1; j < nums.Length; j++)
            {
                hashmap[nums[j]]--;
                if (j > i + 1 && nums[j] == nums[j - 1]) continue;

                int target = -(nums[i] + nums[j]);
                if (hashmap.ContainsKey(target) && hashmap[target] > 0) res.Add([nums[i], nums[j], target]);
            }

            for (int j = i + 1; j < nums.Length; j++)
            {
                hashmap[nums[j]]++;
            }
        }

        return res;
    }
}
