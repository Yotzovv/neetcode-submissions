public class Solution {
    public int Search(int[] nums, int target) // nums = [-1,0,2,4,6,8],   target = 4
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            var mid = left + ((right - left) / 2);

            if (nums[mid] < target) left = mid + 1;
            else if (nums[mid] > target) right = mid - 1;
            else return mid;
        }

        return -1;
    }
}
