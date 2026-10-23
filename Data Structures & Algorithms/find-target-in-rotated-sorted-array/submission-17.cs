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
        left = 0;
        right = nums.Length - 1;

        if (target >= nums[pivot] && target <= nums[right])
            left = pivot;
        else right = pivot - 1;

        while (left <= right)
        {
            var mid = left + (right - left) / 2;
            if (nums[mid] == target) return mid;
            if (nums[mid] > target)  right = mid - 1;
            else left = mid + 1;
        }
        
        return -1;
    }
}
