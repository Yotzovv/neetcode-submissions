public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var rows = new int[9];
        var cols = new int[9];
        var boxes = new int[9];

        for (var r = 0; r < rows.Length; r++)
        {
            for (var c = 0; c < cols.Length; c++)
            {
                var cell = board[r][c];
                if (cell == '.') continue;

                var val = int.Parse(cell.ToString());
                var mask = 1 << val;
                var boxId = (r / 3) * 3 + c / 3;

                if ((rows[r] & mask) != 0 ||
                    (cols[c] & mask) != 0 ||
                    (boxes[boxId] & mask)!= 0)
                    return false;

                rows[r] |= mask;
                cols[c] |= mask;
                boxes[boxId] |= mask;
            }
        }
        
        return true;
    }
}
