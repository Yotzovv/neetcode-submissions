public class Solution {
    public bool SearchMatrix(int[][] matrix, int target)
    {
        var rows = matrix.Length;
        var cols = matrix[0].Length;
        
        var left = 0;
        var right = rows * cols - 1;

        while (left <= right)
        {
            var mid = (left + right) / 2;

            var row = mid / cols;
            var col = mid % cols;
            
            if (matrix[row][col] == target) return true;
            else if (matrix[row][col] < target) left = mid + 1;
            else if (matrix[row][col] > target) right = mid - 1;
        }

        return false;
    }
}
