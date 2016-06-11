public class Solution {
    public int[,] GenerateMatrix(int n) {
        if (n < 0) return null;
        int[,] matrix = new int[n, n];
        int lx = 0, ly = 0, rx = n-1, ry = n-1;
        int value = 1;
        while(lx <= rx && ly <= ry)
        {
            for(int i = ly; i <= ry; ++i)
            {
                matrix[lx, i] = value++;
            }
            for(int i = lx + 1; i <= rx; ++i)
            {
                matrix[i, ry] = value++;
            }
            for(int i = ry - 1; lx < rx && i >= ly; --i)
            {
                matrix[rx, i] = value++;
            }
            for(int i = rx -1; ly < ry && i >= lx +1; --i)
            {
                matrix[i, ly] = value++;
            }
            ++lx; ++ly;
            --rx; --ry;
        }
        return matrix;
    }
}