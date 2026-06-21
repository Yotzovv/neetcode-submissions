    public class Solution
    {
        public bool IsValidSudoku(char[][] board)
        {
            foreach (var row in board)
                if (RowHasDuplicates(row))
                    return false;

            for (int i = 0; i < board.Length; i++)
                if (ColumnHasDuplicates(board, i))
                    return false;

            if (!ValidateSubBoxes(board)) return false;

            return true;
        }

        public bool ValidateSubBoxes(char[][] board)
        {
            var cordinates = ExtractSubBoxesCordinates(board);

            foreach (var subBoxCordinates in cordinates)
            { outcome: 
                var subBox = ExtractSubBox(subBoxCordinates[0], subBoxCordinates[1], board);
                if (SubBoxHasDuplicates(subBox)) return false;
            }

            return true;
        }
        
        public int[][] ExtractSubBoxesCordinates(char[][] board)
        {
            var subBoxesCordinates = new List<List<int>>();

            for (int x = 0; x < board.Length; x += 3)
            {
                for (int y = 0; y < board[x].Length; y += 3)
                {
                    var cordinates = new List<int> { x, y };
                    subBoxesCordinates.Add(cordinates);
                }
            }

            return subBoxesCordinates.Select(c => c.ToArray()).ToArray();
        }

        public char[][] ExtractSubBox(int row, int column, char[][] board)
        {
            var subBox = new char[3][];

            for (int x = row; x < row + 3; x++)
            {
                subBox[x - row] = new char[3];
                for (int y = column; y < column + 3; y++)
                {
                    subBox[x - row][y - column] = board[x][y];
                }
            }

            return subBox;
        }

        public bool SubBoxHasDuplicates(char[][] subBox)
        {
            var symbols = new HashSet<char>();

            foreach (var row in subBox)
            {
                foreach (var digit in row)
                {
                    if (digit == '.') continue;

                    if (!symbols.Add(digit))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool RowHasDuplicates(char[] row)
        {
            var digits = new HashSet<char>();

            foreach (var digit in row)
            {
                if (digit == '.') continue;
                if (!digits.Add(digit)) return true;
            }

            return false;
        }

        public bool ColumnHasDuplicates(char[][] board, int currentIndex)
        {
            var digits = new HashSet<char>();

            for (int i = 0; i < board.Length; i++) {
                char val = board[i][currentIndex];
                if (val == '.') continue;
                if (!digits.Add(val))
                    return true;
            }

            return false;
        }
    }