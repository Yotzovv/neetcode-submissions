public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) 
    {
        for (int level = 0; level < matrix.Length; level++)
        {
            int left = 0;
            int right = matrix[level].Length - 1;
            
            while (left <= right)
            {                
                var mid = (left + right) / 2;
                if (matrix[level][mid] == target) return true;
                else if(matrix[level][mid] < target) left = mid + 1;
                else if (matrix[level][mid] > target) right = mid - 1;                
            }
        }
        
        return false;
    }
}
