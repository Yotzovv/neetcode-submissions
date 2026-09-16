public class Solution {
    public int MaxArea(int[] heights)   // height = [1,7,2,5,4,7,3,6]
    {
        var res = 0;
        int left = 0, right = heights.Length - 1;

        while (left < right)
        {
            var width = right - left;
            var height = Math.Min(heights[left], heights[right]);
            var area = width * height;
            
            if (area > res) res = area;

            if (heights[left] <= heights[right]) left++;
            else right--;
        }
        
        return res;
    }
}
