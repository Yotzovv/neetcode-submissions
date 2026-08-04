public class Solution {
    public int[] ProductExceptSelf(int[] nums) //nums=[1,2,4,6]
    {
        var result = new int[nums.Length];
        
        for (int i = 0; i < nums.Length; i++)
        {
            var product = 1;
            for (int x = 0; x < nums.Length; x++)
            {
                if (x == i) continue;
                product *= nums[x];
            }
            
            result[i] = product;
        }

        return result;
    }
}
