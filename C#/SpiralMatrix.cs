public class Solution {
    public IList<int> SpiralOrder(int[,] matrix) {
        IList<int> eles = new List<int>();
        if(null == matrix)    return eles;
        int rx = matrix.GetLength(0) - 1, ry = matrix.GetLength(1) - 1;
        int lx = 0, ly = 0;
        while(lx <= rx && ly <= ry)
        {
            for(int i = ly; i <= ry; ++i)
            {
                eles.Add(matrix[lx, i]);
            }
            for(int i = lx+1; i <= rx; ++i)
            {
                eles.Add(matrix[i, ry]);
            }
            for(int i = ry-1; lx < rx && i >= ly; --i)
            {
                eles.Add(matrix[rx, i]);
            }
            for(int i = rx-1; ly < ry && i >= lx+1; --i)
            {
                eles.Add(matrix[i, ly]);
            }
            ++lx; ++ly;
            --rx; --ry;
        }
        return eles;
    }
}