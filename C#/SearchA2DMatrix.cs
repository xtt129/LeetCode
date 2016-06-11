public class Solution {
    public bool SearchMatrix(int[,] matrix, int target) {
        if(null == matrix) return false;
        int m = matrix.GetLength(0), n = matrix.GetLength(1);
        int row = 0, col = n - 1;
        while(row < m && col >= 0)
        {
            int value = matrix[row, col];
            if(value == target) return true;
            if(value < target)
            {
                ++row;
            }
            else
            {
                --col;
            }
        }
        return false;
    }
}