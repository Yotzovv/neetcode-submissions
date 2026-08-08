public class Solution {
    public int[] ProductExceptSelf(int[] nums) //nums=[1,2,4,6]
    {
        int prod = 1;
        int zeroCount = 0;

        foreach (var num in nums)
        {
            if (num == 0) zeroCount++;
            else prod *= num;
        }
        
        if (zeroCount > 1) return new int[nums.Length];
        
        var result = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0 && zeroCount==1) result[i] = 0;
            else if (nums[i] != 0) result[i] = prod / nums[i];
            else result[i] = prod;
        }
        
        return result;
    }
}
