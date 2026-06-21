public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var result = new List<int>();
        
        for(int i = 0; i < nums.Length; i++)
        {
            var product = 1;
            
            for(int x = 0; x < nums.Length; x++)
            {
                if(x == i) continue;

                product *= nums[x];
            }
            result.Add(product);
        }

        return result.ToArray();
    }
}
