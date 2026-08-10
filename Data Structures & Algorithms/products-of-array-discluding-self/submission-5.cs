public class Solution {
    public int[] ProductExceptSelf(int[] nums) //nums=[1,2,4,6]
    {
        var n = nums.Length;
        var prefix = new int[n];   
        var suffix = new int[n];
        var result = new int[n];

        prefix[0] = 1;
        suffix[n - 1] = 1;
        for (var i = 1; i <= n-1; i++) prefix[i] = nums[i - 1] * prefix[i - 1];
        for (var i = n - 2; i >= 0; i--) suffix[i] = nums[i + 1] * suffix[i + 1];
        for (var i = 0; i < n; i++) result[i] = prefix[i] * suffix[i];
        
        return result;
    }
}
