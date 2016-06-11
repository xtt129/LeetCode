public class Solution {
    private int GetLiveCount(int[,] board, int u, int v, int m, int n)
    {
        int count = 0;
        for(int i = Math.Max(0, u - 1); i < Math.Min(u + 2, m); ++i)
        {
            for(int j = Math.Max(0, v - 1); j < Math.Min(v + 2, n); ++j)
            {
                count += board[i, j] & 1;
            }
        }
        count -= board[u, v];
        return count;
    }

    public void GameOfLife(int[,] board) {
        if(null == board) return;
        int m = board.GetLength(0), n = board.GetLength(1);
        for(int i = 0; i < m; ++i)
        {
            for(int j = 0; j < n; ++j)
            {
                int liveCount = GetLiveCount(board, i, j, m, n);
                if(board[i, j] == 1 && liveCount >= 2 && liveCount <= 3)
                {
                    board[i, j] |= 2;
                }
                if(board[i, j] == 0 && liveCount == 3)
                {
                    board[i, j] |= 2;
                }
            }
        }
        for(int i = 0; i < m; ++i)
        {
            for(int j = 0; j < n; ++j)
            {
                board[i, j] >>= 1;
            }
        }
    }
}