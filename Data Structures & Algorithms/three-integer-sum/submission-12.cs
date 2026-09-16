public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {   // nums=[-1,0,1,2,-1,-4]
        Array.Sort(nums);                           // nums=[-4,-1,-1,0,1,2]
        var res = new List<List<int>>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0) break;
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            int left = i+1, right = nums.Length - 1;
            while (left < right)
            {
                var currentSum = nums[left] + nums[right] + nums[i];

                if (currentSum > 0) right--;
                else if (currentSum < 0) left++;
                else
                {
                    res.Add(new List<int> { nums[i], nums[left], nums[right] });
                    left++;
                    right--;
                    while (left < right && nums[left] == nums[left - 1]) left++;
                }
            }
        }
        
        return res;
    }
}
