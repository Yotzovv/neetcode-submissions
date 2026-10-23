public class Solution {
    public int FindMin(int[] nums) {
        var left = 0;
        var right = nums.Length - 1;
        var min = nums[0];

        while (left <= right)
        {
            if (nums[left] < nums[right])
            {
                min = Math.Min(min, nums[left]);
                break;
            }

            var mid = left + (right - left) / 2;
            min = Math.Min(min, nums[mid]);

            if (nums[left] <= nums[mid])
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return min;
    }
}
