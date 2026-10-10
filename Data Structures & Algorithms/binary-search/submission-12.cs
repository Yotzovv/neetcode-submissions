public class Solution {
    public int Search(int[] nums, int target) // nums = [-1,0,2,4,6,8],   target = 4
    {
        int left = 0;
        int right = nums.Length;

        while (left < right)
        {
            var mid = left + ((right - left) / 2);

            if (nums[mid] >= target) right = mid;
            else if (nums[mid] < target) left = mid+1;
        }

        return (left < nums.Length && nums[left] == target) ? left : -1;
    }
}
