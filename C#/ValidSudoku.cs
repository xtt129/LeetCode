public class Solution {
    public const int Size = 9;
    
    private bool hasDuplicate(char[,] board, int leftx, int lefty, int rightx, int righty)
    {
        HashSet<char> set = new HashSet<char>();
        for(int i = leftx; i <= rightx; ++i)
        {
             for(int j = lefty; j <= righty; ++j)
            {
                if(board[i , j] != '.' && set.Contains(board[i , j])) return false;
                set.Add(board[i , j]);
            }
        }
        return true;
    }
    
    public bool IsValidSudoku(char[,] board) {
        if(null == board || board.GetLength(0) != Size || board.GetLength(1) != Size) return false;
        HashSet<char> set = new HashSet<char>();
        for(int i = 0; i < Size; ++i)
        {
            if(!hasDuplicate(board, i, 0, i, Size - 1)) return false;
            if(!hasDuplicate(board, 0, i, Size - 1, i)) return false;
        }
        int leftx = 0, lefty = 0;
        for(int i = 0; i < Size; ++i)
        {
             leftx = (i / 3) * 3;
             lefty = (lefty + 3) % Size;
             if(!hasDuplicate(board, leftx, lefty, leftx + 2, lefty + 2)) return false;
        }
        return true;
        
    }
}