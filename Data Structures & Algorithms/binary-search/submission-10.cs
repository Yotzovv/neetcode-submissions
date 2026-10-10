public class Solution {
    public int Search(int[] nums, int target) // nums = [-1,0,2,4,6,8],   target = 4
    {
        int left = 0;
        int right = nums.Length;

        while (left < right)
        {
            var mid = left + ((right - left) / 2);

            if (nums[mid] > target) right = mid;
            else left = mid + 1;
        }

        return (left > 0 && nums[left - 1] == target) ? left - 1 : -1;
    }
}
