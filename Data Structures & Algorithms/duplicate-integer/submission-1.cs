public class Solution {
    public bool hasDuplicate(int[] nums) {
        for(var a = 0; a <= nums.Length; a++)
        {
            for(var b = a + 1; b <= nums.Length - 1; b++)
            {
                if(nums[a] == nums[b]) return true;
                else continue;
            }
        }

        return false;
    }
}