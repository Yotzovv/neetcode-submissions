public class Solution {
    public int[] ProductExceptSelf(int[] nums) //nums=[1,2,4,6]
    {
        var n = nums.Length;
        var result = new int[n];
        
        Array.Fill(result, 1);
        for (var i = 1; i < n; i++) result[i] = result[i - 1] * nums[i - 1];
        
        var postfix = 1;
        for (var i = n-1; i >= 0; i--)
        {
            result[i] *= postfix;           
            postfix *= nums[i];
        }
        
        return result;
    }
}
