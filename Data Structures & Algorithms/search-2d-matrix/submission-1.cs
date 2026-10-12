public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        var m = matrix.Length;
        var n = matrix[0].Length;
        
        var row = 0;
        var column = n - 1;

        while (row < m && column >= 0)
        {
            if (matrix[row][column] < target) row++;
            else if (matrix[row][column] > target) column--;
            else return true;
        }
        
        return false;
    }
}
