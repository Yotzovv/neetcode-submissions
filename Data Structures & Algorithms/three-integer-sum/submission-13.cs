public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {   // nums=[-1,0,1,2,-1,-4]
        Array.Sort(nums);                           // nums=[-4,-1,-1,0,1,2]
        var count = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (!count.ContainsKey(num)) count[num] = 0;
            count[num]++;
        }
        
        var res = new List<List<int>>();
        for (var i = 0; i < nums.Length; i++)
        {
            count[nums[i]]--;
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            
            for (var j = i + 1; j < nums.Length; j++)
            {
                count[nums[j]]--;
                if (j > i + 1 && nums[j] == nums[j - 1]) continue;
                
                var target = -(nums[i] + nums[j]);
                if (count.ContainsKey(target) && count[target] > 0)
                {
                    res.Add(new List<int>(){ nums[i], nums[j], target});
                }
            }
            
            for (int j = i + 1; j < nums.Length; j++) {
                count[nums[j]]++;
            }
        }
        
        
        return res;
    }
}
