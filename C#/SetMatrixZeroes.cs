public class Solution {
    public void SetZeroes(int[,] matrix) {
        if(null == matrix) return;
        int m = matrix.GetLength(0), n = matrix.GetLength(1);
        bool col0 = false;
        for(int i = 0; i < m; ++i)
        {
            col0 |= matrix[i, 0] == 0;
            for(int j = 1; j < n; ++j)
            {
                if(matrix[i, j] == 0)
                {
                    matrix[i, 0] = 0;
                    matrix[0, j] = 0;
                }
            }
        }
        for(int i = m - 1; i >= 0; --i)
        {
            for(int j = n - 1; j >= 1; --j)
            {
                if(matrix[i, 0] == 0 || matrix[0, j] == 0)
                {
                    matrix[i, j] = 0;
                }
            }
        }
        if(col0)
        {
            for(int i = 0; i < m; ++i)
            {
                matrix[i, 0] = 0;
            }
        }
    }
}