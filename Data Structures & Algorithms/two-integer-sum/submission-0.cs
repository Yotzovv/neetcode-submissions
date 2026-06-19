public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int a = 0; a <= nums.Length; a++)
        {
            for(int b = a+1; b <= nums.Length-1; b++)
            {
                if(nums[a] + nums[b] == target)
                    return new[] { a, b };
            }
        }

        return new int[0];
    }
}
