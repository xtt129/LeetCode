public class Solution {
    private void Swap(ref int a, ref int b)
    {
        if( a != b)
        {
            a ^= b;
            b ^= a;
            a ^= b;
        }
    }
    public void Rotate(int[,] matrix) {
        if(null == matrix) return;
        int size = matrix.GetLength(0);
        for(int i = 0; i < size; ++i)
        {
            for(int j = 0; j < i; ++j)
            {
               Swap(ref matrix[i,j], ref matrix[j,i]); 
            }
        }
        for(int i = 0; i < size; ++i)
        {
            for(int j = 0; j < size / 2; ++j)
            {
                Swap(ref matrix[i , j], ref matrix[i , size-1-j]);
            }
        }
    }
}