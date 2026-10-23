public class Solution {
    public int Search(int[] nums, int target) {
        var left = 0;
        var right = nums.Length - 1;
        
        while (left < right)
        {
            var mid = left + (right - left) / 2;

            if (nums[mid] > nums[right]) left = mid + 1;
            else right = mid;
        }

        var pivot = left;
        var result = BS(nums, target, 0, pivot - 1);
        if (result != -1) return result;
        
        return BS(nums, target, pivot, nums.Length - 1);
    }

    private int BS(int[] nums, int target, int left, int right)
    {
        while (left <= right)
        {
            var mid = left + (right - left) / 2;

            if (nums[mid] == target) return mid;
            else if (nums[mid] > target) right = mid - 1;
            else left = mid + 1;
        }

        return -1;
    }
}
