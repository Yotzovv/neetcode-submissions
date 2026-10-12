public class Solution {
    public bool SearchMatrix(int[][] matrix, int target)
    {
        var m = matrix.Length;
        var n = matrix[0].Length;

        var row = 0;
        var col = 0;

        // nums = [[1,3,5,7],[10,11,16,20],[23,30,34,60]];
        // target = 3;
        while (row < m && n > col)
        {
            if (matrix[row][col] == target) return true;

            if (matrix[row][0] <= target && target <= matrix[row][n - 1])
                return BS(matrix[row], target, 0, n);
             
            row++;
        }
        
        return false;
    }
    
    public bool BS(int[] row, int target, int left, int right)
    {
        if (left > right) return false;
        
        var mid = left + (right - left) / 2;
    
        if (row[mid] == target) return true;
        if (row[mid] < target) return BS(row, target, mid+1, right);
        if (row[mid] > target) return BS(row, target, left, mid-1);
    
        return false;
    }
}
