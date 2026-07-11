public class Solution {
    private HashSet<(int, int)> _visited = new HashSet<(int, int)>();
    
    public bool Exist(char[][] board, string word)
    {
        for (int row = 0; row < board.Length; row++)
            for (int col = 0; col < board[row].Length; col++)
                if (DFS(row, col, 0, board, word)) return true;
        
        return false;
    }
    
    private bool DFS(int row, int col, int i, char[][] board, string word)
    {
        if (i == word.Length) return true;
        if (row < 0 || row >= board.Length) return false;
        if (col < 0 || col >= board[row].Length) return false;
        if (board[row][col] != word[i]) return false;
        if (_visited.Contains((row, col))) return false;
                
        _visited.Add((row, col));
        var result = DFS(row, col+1, i + 1, board, word) ||
            DFS(row, col - 1, i + 1, board, word) ||
            DFS(row + 1, col, i + 1, board, word) ||
            DFS(row - 1, col, i + 1, board, word);
        _visited.Remove((row, col));
        
        return result;
    }
}
